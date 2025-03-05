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
    /// Логика взаимодействия для Page16.xaml
    /// </summary>
    public partial class Page16 : Page
    {
        public Page16()
        {
            InitializeComponent();
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbm.Text) && string.IsNullOrEmpty(Tbn.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                Class16 class16 = new Class16(Convert.ToInt32(Tbm.Text), Convert.ToInt32(Tbn.Text));

                MessageBox.Show(($"Делители числа {Tbm.Text}, взаимно просты с {Tbn.Text}:"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                foreach (int devider in class16.GetGeneralDivider())
                {
                    MessageBox.Show(devider + " ");
                }

                Tbm.Text = string.Empty;
                Tbn.Text = string.Empty;
            }
        }
    }
}
