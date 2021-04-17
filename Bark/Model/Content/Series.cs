using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class Series : Movie
	{
		public List<Part> Parts { get; set; }
	}
}
