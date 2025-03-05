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
    /// Логика взаимодействия для Page19.xaml
    /// </summary>
    public partial class Page19 : Page
    {
        public Page19()
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
                Class19 class19 = new Class19(Convert.ToInt32(Tbm.Text), Convert.ToInt32(Tbn.Text));

                MessageBox.Show(($"Произведение квадратов четных чисел в интервале [{Tbm.Text}, {Tbn.Text}]: {class19.CalculateProductOfSquares()}"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                Tbm.Text = string.Empty;
                Tbn.Text = string.Empty;
            }
        }
    }
}
