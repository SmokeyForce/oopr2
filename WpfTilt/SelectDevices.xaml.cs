using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WpfTilt
{
    /// <summary>
    /// Логика взаимодействия для SelectDevices.xaml
    /// </summary>
    public partial class SelectDevices : Window
	{
		public static Monitor selMon;
        public static Mouse selMouse;
		List<Monitor> monitors;
		List<Mouse> mouses;
		public SelectDevices()
		{
			InitializeComponent();
			StreamReader  sr = new StreamReader("monitors.txt");
			monitors = new List < Monitor > ();
			while (!sr.EndOfStream)
			{
				Monitor  m = new Monitor();
				m.readFromFile(sr);
				monitors.Add(m);
				monitorList.Items.Add(m);
			}
			sr.Close();
			sr = new StreamReader("mouses.txt");
			mouses = new List < Mouse > ();
			while (!sr.EndOfStream)
			{
				Mouse  mo = new Mouse();
				mo.readFromFile(sr);
				mouses.Add(mo);
				mouseList.Items.Add(mo);
			}
			sr.Close();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			this.Close();
		}
		public void SendMessage(string message)
		{
			MessageBox.Show(message);
		}
		private void Button_Click_1(object sender, RoutedEventArgs e)
        {
			Mouse mouse1 = new Mouse("Gromyako","Dishonored", 100, 3, "None", "Black");
			mouse1.Brand = "F1";
			IDrawable printable = mouse1;
			printable.Print(SendMessage);
			printable = mouse1;
			printable.Print(x => MessageBox.Show(x));
			MessageBox.Show(printable[0]);
			printable.Draw(printable.PrintContent, SendMessage);
		}

        private void monitorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			selMon = this.monitors[monitorList.SelectedIndex];
		}

        private void mouseList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			selMouse = this.mouses[mouseList.SelectedIndex];
		}
    }
}
