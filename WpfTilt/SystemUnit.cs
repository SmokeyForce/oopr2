using System.IO;

namespace WpfTilt
{
	public class SystemUnit : IDrawable
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Price { get; set; }
		public string GetUnitName {get{ return this.Brand + " " + this.Model; } }
		public string this[int index] => "System Unit" + index;
		public string Colour { get; set; }
	public string CPU { get; set; }
	public string Size { get; set; }
	public string Motherboard { get; set; }
	public int Ram { get; set; }
	public string PrintContent { get => Brand; }
		public SystemUnit() :this("Papuas","Venecia",300)
		{
			
		}
	public SystemUnit(string _brand,string _model, int _price):this(_brand,_model,_price,"black","intelcorei14.1","mid-tower","asusgromyako",32)
		{

		}
	public SystemUnit(string _brand, string _model, int _price,string _colour,string _cpu,string _size,string _motherboard,int _ram)
        {
			Brand = _brand;
			Model = _model;
			Price = _price;
			Colour = _colour;
			Size = _size;
			Motherboard = _motherboard;
			CPU = _cpu;
			Ram = _ram;
        }
	public void readFromFile(StreamReader sr)
		{
			this.Brand= sr.ReadLine();
			this.Model = sr.ReadLine();
			this.Price = int.Parse(sr.ReadLine());
			this.Colour = sr.ReadLine();
			this.Size = sr.ReadLine();
			this.Motherboard = sr.ReadLine();
			this.CPU = sr.ReadLine();
			this.Ram = int.Parse(sr.ReadLine());
		}
	public void writeToFile(StreamWriter sw)
		{
			sw.WriteLine(Brand);
			sw.WriteLine(Model);
			sw.WriteLine(Price);
			sw.WriteLine(Colour);
			sw.WriteLine(Size);
			sw.WriteLine(Motherboard);
			sw.WriteLine(CPU);
			sw.WriteLine(Ram);
		}
		public void Print(MessageSender sender)
		{
			sender(PrintContent);
		}

		public void Draw(string something, MessageSender sender)
		{
			sender("Showed System Unit " + something);
		}
	}
}
