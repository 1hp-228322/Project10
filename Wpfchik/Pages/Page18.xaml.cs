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
    /// Логика взаимодействия для Page18.xaml
    /// </summary>
    public partial class Page18 : Page
    {
        public Page18()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            Class18 class18 = new Class18();

            MessageBox.Show(("Первые 100 простых чисел:"), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            MessageBox.Show("2 3 5 7 11 13 17 19 23 29\n31 37 41 43 47 53 59 61 67 71\n73 79 83 89 97 101 103 107 109 113\n127 131 137 139 149 151 157 163 167 173\n179 181 191 193 197 199 211 223 227 229\n233 239 241 251 257 263 269 271 277 281\n283 293 307 311 313 317 331 337 347 349\n353 359 367 373 379 383 389 397 401 409\n419 421 431 433 439 443 449 457 461 463\n467 479 487 491 499 503 509 521 523 541\n");

             

        }
    }
}
