using System.IO;

namespace WpfTilt
{
	public sealed class Mouse : Devices, IDrawable
	{
		public int NumOfButtons { get; set; }
		public string Backlight { get; set; }
		public string Colour { get; set; }
		public string PrintContent { get => Brand; }
		public string this[int index] => "Mouse" + index;
		public Mouse() : this("A4Tech", "COC100", 100, 3, "None", "Black")
		{

		}
		public Mouse(string _brand, string _model, int _price) : this(_brand, _model, _price, 3, "white", "black")
		{

		}
		public Mouse(string _brand, string _model, int _price, int _numOfButtons, string _backlight, string _colour) : base(_brand, _model, _price)
		{
			NumOfButtons = _numOfButtons;
			Backlight = _backlight;
			Colour = _colour;
		}
		public void readFromFile(StreamReader sr)
		{
			this.Brand = sr.ReadLine();
			this.Model = sr.ReadLine();
			this.Price = int.Parse(sr.ReadLine());
			this.Colour = sr.ReadLine();
		}
		public void writeToFile(StreamWriter sw)
		{
			sw.WriteLine(Brand);
			sw.WriteLine(Model);
			sw.WriteLine(Price);
			sw.WriteLine(Colour);
		}
		public override string selfDescribe()
		{
			return "I am " + FullName + " mouse";
		}
		public void Print(MessageSender sender)
		{
			sender(PrintContent);
		}

		public void Draw(string something, MessageSender sender)
		{
			sender("Showed Device " + something);
		}

	}
}
