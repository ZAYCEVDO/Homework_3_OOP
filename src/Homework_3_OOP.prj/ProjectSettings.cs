using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class ProjectSettings
	{
		public string Path { get; set; }
		public int Count { get; set; }
		public ProjectSettings()
		{
			Path = "random path";
			Count = 1;
		}
	}
}
