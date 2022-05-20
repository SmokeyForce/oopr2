using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace WpfTilt
{
    /// <summary>
    /// Interaction logic for AddMouse.xaml
    /// </summary>
    public partial class AddMouse : Window
    {
        List<Mouse> Mouses = new List<Mouse>();
        public AddMouse()
        {
            InitializeComponent();


            using (ApplicationContext db = new ApplicationContext())
            {
                // Read
                var mousesDB = db.Mouses.ToList();

                foreach (var mouse in mousesDB)
                {
                    this.Mouses.Add(mouse);
                }
                ReloadList();

            }

        }
        private void ReloadList()
        {
            this.MousesList.Items.Clear();

            foreach (Mouse s in Mouses)
            {
                this.MousesList.Items.Add(s);
            }
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            // Create
            Mouse mouse = new Mouse();
            mouse.Brand = this.Brand.Text;
            mouse.NumOfButtons = int.Parse(this.NumOfButtons.Text);
            mouse.Colour = this.Colour.Text;
            mouse.Backlight = this.Backlight.Text;
            mouse.Model = this.Model.Text;
            mouse.Price = int.Parse(this.Price.Text);            

            using (ApplicationContext db = new ApplicationContext())
            {
                db.Mouses.Add(mouse);
                db.SaveChanges();
            }

            this.Mouses.Add(mouse);

            ReloadList();
        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

            if (this.MousesList.SelectedIndex == -1) return;

            Mouse mouse = (Mouse)this.MousesList.SelectedItem;

            mouse.Brand = this.Brand.Text;
            mouse.NumOfButtons = int.Parse(this.NumOfButtons.Text);
            mouse.Colour = this.Colour.Text;
            mouse.Backlight = this.Backlight.Text;
            mouse.Model = this.Model.Text;
            mouse.Price = int.Parse(this.Price.Text);

            using (ApplicationContext db = new ApplicationContext())
            {
                db.Mouses.Update(mouse);
                db.SaveChanges();
            }

            ReloadList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.MousesList.SelectedIndex == -1) return;

            Mouse mouse= (Mouse)this.MousesList.SelectedItem;

            using (ApplicationContext db = new ApplicationContext())
            {
                db.Mouses.Remove(mouse);
                db.SaveChanges();
            }

            this.Mouses.Remove(mouse);

            ReloadList();
        }

        private void MousesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
