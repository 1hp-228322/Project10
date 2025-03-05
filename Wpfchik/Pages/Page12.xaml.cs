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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Project10.Classes;

namespace Wpfchik.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        public Page12()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
                //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                Class12 class7 = new Class12();

                MessageBox.Show($"Ответ = {class7.G1()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            

        }
        


    }
}