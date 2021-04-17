using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public enum eGenre
	{
		man,
		woman,
		other
	}
	public class User
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public string Short { get; set; }
		public bool Genre { get; set; }
		public string email { get; set; }
		public int SocialSiteId { get; set; }
		public List<SawedContent> SawedContent { get; set; }
		public List<ContentLists> ContentLists { get; set; }

	}
}
