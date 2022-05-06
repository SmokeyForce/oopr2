using System.IO;

namespace WpfTilt
{
	public class Monitor : Devices
	{
		public int Hhz { get; set; }
		public int Inch { get; set; }

		public void readFromFile(StreamReader sr)
		{
			Brand = sr.ReadLine();
			Model = sr.ReadLine();
			Price = int.Parse(sr.ReadLine());
		    Hhz = int.Parse(sr.ReadLine());
			Inch = int.Parse(sr.ReadLine());
		}
		public void writeToFile(StreamWriter sw)
		{
			sw.WriteLine(this.Brand);
			sw.WriteLine(this.Model);
			sw.WriteLine(this.Price);
			sw.WriteLine(this.Hhz);
			sw.WriteLine(this.Inch);
		}

		public Monitor() : this("Brand", "Model")
		{
		}
		public Monitor(string _brand, string _model):this(_brand,_model,300,144,14){
		
		}
		public Monitor(string _brand, string _model, int _price, int _hhz, int _inch):base(_brand,_model,_price)
        {
			Hhz = _hhz;
			Inch = _inch;
		}
		public override string selfDescribe()
		{
			return "This is " + FullName +" monitor";
		}
	}
}
