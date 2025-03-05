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
    /// Логика взаимодействия для Page24.xaml
    /// </summary>
    public partial class Page24 : Page
    {
        public Page24()
        {
            InitializeComponent();
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            Class24 class24 = new Class24();

            MessageBox.Show(($"Сумма положительных чисел, кратных 4 и меньших 100: {class24.CalculateSum()}"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
