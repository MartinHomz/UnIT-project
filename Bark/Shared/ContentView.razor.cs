using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Shared
{
	public partial class ContentView
	{
		[CascadingParameter(Name = "MainLayout")] public MainLayout MainLayout { get; set; }

        public bool BasicInfoView { get; set; } = true;
        bool PopupVisible { get; set; } = false;

		protected override void OnInitialized()
		{
			base.OnInitialized();
            MainLayout.DisplayRightSidebar = true;

        }

		public void OnBasicInfo()
        {
            BasicInfoView = true;
        }

        public void OnUserInfo()
        {
            BasicInfoView = false;
        }
    }
}
