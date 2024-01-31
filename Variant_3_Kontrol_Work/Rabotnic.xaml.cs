using System;
using System.Collections.Generic;
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

namespace Variant_3_Kontrol_Work
{
    /// <summary>
    /// Логика взаимодействия для Rabotnic.xaml
    /// </summary>
    public partial class Rabotnic : Window
    {
        public Rabotnic()
        {
            InitializeComponent();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }
    }
}
