using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTilt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SystemUnit selSU;
		public static Monitor selMon;
        public static Mouse selMouse;
        public MainWindow()
        {
			InitializeComponent();
			StreamWriter  sw = new StreamWriter("su.txt");
			SystemUnit  s = new SystemUnit("Papucious1", "Vinnytsya", 100, "black", "intelcorei14.1", "mid-tower", "asusgromyako",  32);
			s.writeToFile(sw);
			s = new SystemUnit("Papuas", "Venecia", 100, "black", "intelcorei14.1", "full-tower", "asusgromyako",  32);
			s.writeToFile(sw);
			s = new SystemUnit("Vitold", "Rivia", 100, "black", "intelcorei14.1", "low-tower", "asusgromyako",  32);
			s.writeToFile(sw);
			sw.Close();
			sw = new StreamWriter("mouses.txt");
			Mouse m = new Mouse("Razer", "Deathadder", 300, 5, "black", "blue");
			m.writeToFile(sw);
			m = new Mouse("Steelseries", "prikol", 300, 5, "blue", "black");
			m.writeToFile(sw);
			m = new Mouse("a4tech", "n7", 100, 5, "black", "none");
			m.writeToFile(sw);
			sw.Close();
			sw = new StreamWriter("monitors.txt");
			Monitor mo = new Monitor("Samsung", "roflan300", 300, 69, 27);
			mo.writeToFile(sw);
			mo = new Monitor("Vitold", "iz Rivii", 300,69,27);
			mo.writeToFile(sw);
			sw.Close();
		}


    private void Button_Click(object sender, RoutedEventArgs e)
        {
            SelectSystemUnit  form = new SelectSystemUnit();
            form.ShowDialog();
            selSU = SelectSystemUnit.selSU;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SelectDevices form = new SelectDevices();
            form.ShowDialog();
            selMon = SelectDevices.selMon;
            selMouse = SelectDevices.selMouse;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
			if (selSU == null || selMon == null || selMouse == null)
			{
				MessageBox.Show(this, "You have not selected one or more components", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				UpdateDrivers form = new UpdateDrivers(selSU, selMon, selMouse);
				form.ShowDialog();
			}
		}
    }
}
