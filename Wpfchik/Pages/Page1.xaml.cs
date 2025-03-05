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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA1.Text) && string.IsNullOrEmpty(TbB1.Text) && string.IsNullOrEmpty(TbB1.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                Class1 myTask1Class = new Class1(Convert.ToDouble(TbA1.Text), Convert.ToDouble(TbB1.Text), Convert.ToDouble(TbC1.Text));

                MessageBox.Show((myTask1Class.IsOnlyOneEven(), MessageBoxButton.OK, MessageBoxImage.Information);

                TbA1.Text = string.Empty;
                TbB1.Text = string.Empty;
                TbC1.Text = string.Empty;
            }
        }
    }
}
