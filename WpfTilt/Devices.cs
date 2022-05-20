
namespace WpfTilt
{
    public delegate void MessageSender(string message);
    public abstract class Devices
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string FullName { get { return this.Brand + " " + this.Model; } }
        public Devices() : this("Asus", "Gromyako", 100)
        {

        }
        public Devices(string _brand, string _model, int _price)
        {
            Brand = _brand;
            Model = _model;
            Price = _price;
        }
        public abstract string selfDescribe();
    }
}
