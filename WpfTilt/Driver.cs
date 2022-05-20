
namespace WpfTilt
{
    class Driver
	{
		public int Id { get; set; }
	public string Name { get; set; }
	public string Date { get; set; }
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
