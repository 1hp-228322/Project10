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
    /// Логика взаимодействия для Page23.xaml
    /// </summary>
    public partial class Page23 : Page
    {
        public Page23()
        {
            InitializeComponent();
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            Class23 class23 = new Class23();

            MessageBox.Show(($"Сумма отрицательных чисел, кратных 5 от -20 до 20: {class23.CalculateSum()}"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
