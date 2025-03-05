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
    /// Логика взаимодействия для Page30.xaml
    /// </summary>
    public partial class Page30 : Page
    {
        public Page30()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbN1.Text) && string.IsNullOrEmpty(TbM1.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                Class30 class7 = new Class30(Convert.ToInt32(TbN1.Text), Convert.ToInt32(TbM1.Text));

                MessageBox.Show($"Ответ = {class7.CalculateProductOfSquares()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                TbN1.Text = string.Empty;
                TbM1.Text = string.Empty;
            }
        }
    }
}
