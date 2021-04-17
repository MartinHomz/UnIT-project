using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Note { get; set; }
		public int CreateDate { get; set; }
		public float Rating { get; set; }
		public int Time { get; set; }
		public List<int> Achievments { get; set; }
	}
}
