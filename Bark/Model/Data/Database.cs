using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class Database
	{
		private static Database current;
		public static Database Current
		{
			get
			{
				if (current == null)
					current = new Database();
				return current;
			}
		}

		private Database()
		{
		}

		public List<Movie> Movies { get; set; }
		public List<Series> Series { get; set; }
		public List<User> Users { get; set; }
		public List<SocialSiteUser> SocUsers { get; set; }
		public List<Achievment> Achievments { get; set; }
		public List<Chat> Chats { get; set; }
		public int LoggedUserId { get; set; } = 0;
		public bool DbLoaded { get; set; } = false;

		public async Task InitializeDB(HttpClient http)
		{
			string json = await http.GetStringAsync("data/movies.json");
			Movies = JsonConvert.DeserializeObject<List<Movie>>(json);

			json = await http.GetStringAsync("data/series.json");
			Series = JsonConvert.DeserializeObject<List<Series>>(json);

			json = await http.GetStringAsync("data/users.json");
			Users = JsonConvert.DeserializeObject<List<User>>(json);

			json = await http.GetStringAsync("data/socialusers.json");
			SocUsers = JsonConvert.DeserializeObject<List<SocialSiteUser>>(json);

			json = await http.GetStringAsync("data/achievments.json");
			Achievments = JsonConvert.DeserializeObject<List<Achievment>>(json);

			json = await http.GetStringAsync("data/chats.json");
			Chats = JsonConvert.DeserializeObject<List<Chat>>(json);

			DbLoaded = true;
		}

		public User GetUserById(int id)
		{
			return Users.Find(x => x.Id == id);
		}

		public SocialSiteUser GetSocUserById(int id)
		{
			return SocUsers.Find(x => x.Id == id);
		}

		public List<User> GetFriends()
		{
			if (SocUsers != null && SocUsers.Count > 0)
			{
				SocialSiteUser socUser = SocUsers.Find(x => x.Id == GetUserById(LoggedUserId).SocialSiteId);
				List<User> frinds = new List<User>();
				foreach (int id in socUser.FriendsIds)
				{
					frinds.Add(Users.Find(x => x.SocialSiteId == id));
				}
				return frinds;
			}
			else
				return new List<User>();
		}

		public Chat GetChat(int friendSocId)
		{
			if (Chats != null && Chats.Count > 0)
				return Chats.Find(x => x.Users.Contains(LoggedUserId) && x.Users.Contains(friendSocId));
			else
				return new Chat();
		}
	}
}
