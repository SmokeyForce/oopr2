using System.Windows;

namespace WpfTilt
{
    /// <summary>
    /// Логика взаимодействия для UpdateDrivers.xaml
    /// </summary>
    public partial class UpdateDrivers : Window
    {
        SystemUnit su;
		Monitor mon;
		Mouse mouse;
        public UpdateDrivers()
        {
            InitializeComponent();
        }
        public UpdateDrivers(SystemUnit _su, Monitor _mon, Mouse _mouse) :this()
        {
            su = _su;
            mon = _mon;
            mouse = _mouse;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "Drivers installed! Monitor and mouse connected to system unit!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.label2.Content = "You have selected system unit:\n" +
            "Brand: " + su.Brand + "\n" +
            "Model: " + su.Model + "\n" +
            "Price: " + su.Price.ToString() + "\n" +
            "Color: " + su.Colour + "\n" +
            "CPU: " + su.CPU + "\n" +
            "Size: " + su.Size + "\n" +
            "Motherboard: " + su.Motherboard + "\n" +
            "Ram: " + su.Ram + "GB \n" + "\n" +
            "Monitor:\n" +
            "Brand: " + mon.Brand + "\n" +
            "Model: " + mon.Model + "\n" +
            "Price: " + mon.Price + "\n" +
            "HHz: " + mon.Hhz.ToString() + "\n" +
            "Inch: " + mon.Inch.ToString() + "\n\n" +
            "Mouse:\n" +
            "Brand: " + mouse.Brand + "\n" +
            "Model: " + mouse.Model + "\n" +
            "Price: " + mouse.Price + "\n" +
            "Backlight: " + mouse.Backlight + "\n" +
            "Color: " + mouse.Colour + "\n" +
            "Num of buttons: " + mouse.NumOfButtons + "\n";
        }
    }
}
