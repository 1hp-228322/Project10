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
    /// Логика взаимодействия для Page26.xaml
    /// </summary>
    public partial class Page26 : Page
    {
        public Page26()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
                Class26 class7 = new Class26();
               
                MessageBox.Show($"Ответ ={class7.GetOddNumbers()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }
    }
}
