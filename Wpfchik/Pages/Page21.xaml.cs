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
    /// Логика взаимодействия для Page21.xaml
    /// </summary>
    public partial class Page21 : Page
    {
        public Page21()
        {
            InitializeComponent();
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbm.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                Class21 class21 = new Class21(Convert.ToInt32(Tbm.Text));

                MessageBox.Show(($"Разность кубов {Tbm.Text} нечетных чисел: {class21.CalculateDifferenceOfCubes()}"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);


                Tbm.Text = string.Empty;
            }
        }
    }
}
