using System.Linq;
using System.Windows;


namespace WpfTilt
{
    /// <summary>
    /// Interaction logic for LINQForm.xaml
    /// </summary>
    public partial class LINQForm : Window
    {
        public LINQForm()
        {
            InitializeComponent();
        }

        private void WhereButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var whereLinq = from s in context.Mouses
                                where s.Brand == "Papich"
                                select s;
                MousesList.Items.Clear();

                foreach (var s in whereLinq)
                {
                    MousesList.Items.Add(s);
                }
            }
        }

        private void GroupButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var groupLinq = from s in context.Mouses.ToList()
                                group s by s.Brand into g
                                select new
                                {
                                    Name = g.Key,
                                    Count = g.Count(),
                                    Mouses = from p in g select p

                                };


                MousesList.Items.Clear();

                foreach (var brandgroups in groupLinq)
                {
                    foreach (var mouse in brandgroups.Mouses)
                    {
                        MousesList.Items.Add(mouse);
                    }
                    MessageBox.Show(brandgroups.Name + " Count = " + brandgroups.Count);

                }


            }
        }

        private void WhereExtenstionButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var whereLinq = context.Mouses.Where(s => s.Brand == "Papich");

                MousesList.Items.Clear();
                foreach (var s in whereLinq)
                {
                    MousesList.Items.Add(s);
                }
            }
        }

        private void MaxButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                int maxPrice = context.Mouses.Max(x=>x.Price);

                MessageBox.Show("Max mouse price = " + maxPrice);
                MousesList.Items.Clear();
            }
        }
    }
}
