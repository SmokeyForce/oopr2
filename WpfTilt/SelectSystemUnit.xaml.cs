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
using System.Windows.Shapes;

namespace WpfTilt
{
    /// <summary>
    /// Логика взаимодействия для SelectSystemUnit.xaml
    /// </summary>
    public partial class SelectSystemUnit : Window
    {
        public static SystemUnit selSU;
        List<SystemUnit> systemunits;
        public SelectSystemUnit()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("su.txt");
            systemunits = new List < SystemUnit > ();
            while (!sr.EndOfStream)
            {
                SystemUnit  unit = new SystemUnit();
                unit.readFromFile(sr);
                systemunits.Add(unit);
                suList.Items.Add(unit);
            }
            sr.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
        public void SendMessage(string message)
        {
           MessageBox.Show(message);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SystemUnit su1 = new SystemUnit("roflan","vitalya",100);
            su1.Brand = "F1";
            IDrawable printable = su1;
            printable.Print(SendMessage);
            printable = su1;
            printable.Print(x => MessageBox.Show(x));
            MessageBox.Show(printable[0]);
            printable.Draw(printable.PrintContent, SendMessage);
        }

       private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           selSU = this.systemunits[suList.SelectedIndex];
           /* for each(ListViewItem  k in suList.Items){
                k.BackColor = SystemColors::Window;
            }
            suList.Items[suList.SelectedIndex].BackColor = Color::LightBlue;
            this.Refresh();*/
        }
    }
}
