using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class MenuService
	{
		private static MenuService menuServ;

		public static MenuService MenuServ
		{
			get
			{
				if (menuServ == null)
					menuServ = new MenuService();
				return menuServ;
			}
		}

		private MenuService()
		{
		}

		public List<Menu> BaseMenu { get; set; } = new List<Menu>
		{
			new Menu(0, "Home", ""),
			new Menu(0, "Series", "Series"),
			new Menu(0, "Movies", "Movies"),
			new Menu(0, "My Lists", "Lists"),
		};
	}

	public class Menu
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public string Url { get; set; }

		public Menu()
		{

		}

		public Menu(int id, string text, string url)
		{
			Id = id;
			Text = text;
			Url = url;
		}
	}
}
