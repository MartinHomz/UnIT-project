using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class ContentLists
	{
		public int ContentListId { get; set; }
		public eContentType ContentType { get; set; }
		public List<int> SharedToFriendsId { get; set; }
		public string Name { get; set; }
		public List<int> Content { get; set; }
	}
}
