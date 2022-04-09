using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTilt
{
    class Driver
	{ 
	string Name { get; set; }
	string Date { get; set; }
	public Driver() : this("driver", "14.01.2014")
		{
		}
	public Driver(string _name,string _date)
	{
	}
	void instalDriver(string _name)
		{
			string  s = "This driver " + this.Name + " is installed";
		}
	}
}
