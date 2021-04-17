using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class Chat
	{
		public int Id { get; set; }
		public List<int> Users { get; set; }
		public List<ChatContent> ChatContents { get; set; }
	}
}
