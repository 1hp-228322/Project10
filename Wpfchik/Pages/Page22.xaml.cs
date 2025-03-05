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
    /// Логика взаимодействия для Page22.xaml
    /// </summary>
    public partial class Page22 : Page
    {
        public Page22()
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
                Class22 class22 = new Class22(Convert.ToInt32(Tbm.Text), Convert.ToInt32(Tbn.Text));

                MessageBox.Show(($"Квадрат разности чисел от {Tbm.Text} до {Tbn.Text}: {class22.CalculateSquareOfDifference()}"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);


                Tbm.Text = string.Empty;
                Tbn.Text = string.Empty;
            }
        }
    }
}
