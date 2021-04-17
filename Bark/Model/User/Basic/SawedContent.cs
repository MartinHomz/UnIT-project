using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public enum eContentType
	{
		movie,
		series
	}
	public class SawedContent
	{
		public int ContentId { get; set; }
		public eContentType ContentType { get; set; }
		public int EndTime { get; set; }
		public bool Sawed { get; set; }

	}
}
