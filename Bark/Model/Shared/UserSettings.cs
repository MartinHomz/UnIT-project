using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class UserSettings : INotifyPropertyChanged
	{
		private ISyncLocalStorageService localStorage;
		public ISyncLocalStorageService LocalStorage
		{
			get => localStorage;
			set
			{
				localStorage = value;
				LoadData();
			}
		}

		private bool? darkMode;
		/// <summary>
		/// Barevné schéma
		/// </summary>
		public bool? DarkMode
		{
			get => darkMode;
			set
			{
				darkMode = value;
				LocalStorage.SetItem(nameof(DarkMode), value);
				NotifyPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private static UserSettings current;
		public static UserSettings Current
		{
			get
			{
				if (current == null)
					current = new UserSettings();
				return current;
			}
		}

		private UserSettings()
		{
		}

		private void LoadData()
		{
			try
			{
				DarkMode = LocalStorage.GetItem<bool>(nameof(DarkMode));
			}
			catch
			{
				DarkMode = true;
			}
			if (DarkMode is null)
				DarkMode = true;
		}
	}
}
