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
    /// Логика взаимодействия для Page20.xaml
    /// </summary>
    public partial class Page20 : Page
    {
        public Page20()
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
                Class20 class20 = new Class20(Convert.ToInt32(Tbm.Text));

                MessageBox.Show(($"Результат выражения для n = {Tbm.Text}: {class20.CalculateExpression()}"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                Tbm.Text = string.Empty;
            }
        }
    }
}
