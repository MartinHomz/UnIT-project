using Bark.Model;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bark.Shared
{
	public partial class MainLayout : IDisposable
	{
		public enum eSidebarState
		{
			Opened = 1,
			Closed = 2
		}

		[Inject] public NavigationManager NavigationManager { get; set; }
		[Inject] public HttpClient Http { get; set; }
		[Inject] public ISyncLocalStorageService localStorage { get; set; }

		private eSidebarState LeftSidebarStatus = eSidebarState.Closed;
		private Menu CurrentPage { get; set; } = MenuService.MenuServ.BaseMenu[0];
		public bool DarkMode { get; set; } = true;
		public bool ChatMode { get; set; } = false;
		public Movie SelectedContent { get; set; }
		bool PopupVisible { get; set; } = false;
		public bool DisplayRightSidebar { get; set; }

		/// <summary>
		/// Inicializace - nastavení původních hodnot
		/// </summary>
		protected override async Task OnInitializedAsync()
		{
			await base.OnInitializedAsync();
			//uživatelské nastavení
			UserSettings.Current.PropertyChanged += (o, e) => { StateHasChanged(); };
			UserSettings.Current.LocalStorage = localStorage;
			//menu
			NavigationManager.LocationChanged += OnLocationChanged;
			SetCurrentPage(NavigationManager.Uri);

			await Database.Current.InitializeDB(Http);
		}

		void IDisposable.Dispose()
		{
			NavigationManager.LocationChanged -= OnLocationChanged;
		}

		/// <summary>
		/// Přesměrování
		/// </summary>
		private void OnLocationChanged(object sender, LocationChangedEventArgs args)
		{
			SetCurrentPage(args.Location);
			InvokeAsync(StateHasChanged);
		}

		private void SetCurrentPage(string currentUrl)
		{
			CurrentPage = MenuService.MenuServ.BaseMenu.Find(x => currentUrl.Substring(NavigationManager.BaseUri.Length) == x.Url);
		}

		public void SearchBar_SelectionChanged(Menu menuItem)
		{
			NavigationManager.NavigateTo(menuItem.Url);
		}

		public void MenuItemClick(string url)
		{
			NavigationManager.NavigateTo(url);
		}

		public void ToggleLeftSidebar()
		{
			switch (LeftSidebarStatus)
			{
				case eSidebarState.Closed:
					LeftSidebarStatus = eSidebarState.Opened;
					break;
				default:
					LeftSidebarStatus = eSidebarState.Closed;
					break;
			}
		}

		public void ToggleChatMode()
		{
			ChatMode = !ChatMode;
		}
	}
}
