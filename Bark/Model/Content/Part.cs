using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bark.Model
{
	public class Part
	{
		public int Id { get; set; }
		public List<Episode> Episodes { get; set; }
	}
}
