using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class SocialSiteUser
	{
		public int Id { get; set; }
		public int Rank { get; set; }
		public List<ContentReaction> ContentReactions { get; set; }
		public List<int> DoneAchievmentsIds { get; set; }
		public List<int> FriendsIds { get; set; }
	}
}
