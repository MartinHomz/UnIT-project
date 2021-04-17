using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class ContentReaction
	{
		public int Id { get; set; }
		public eContentType ContentType { get; set; }
		public int ContentId { get; set; }
		public int? Rating { get; set; }
		public string Comment { get; set; }
	}
}
