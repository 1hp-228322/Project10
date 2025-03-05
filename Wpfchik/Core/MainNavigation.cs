using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Wpfchik.Pages;

namespace Wpfchik.Core
{
    public static class MainNavigation
    {
        public static Frame MainFrameNav { get; set; }
    }

    public class SwitchToTask
    {
        private readonly int _sw;

        public SwitchToTask(int sw)
        {
            _sw = sw;
        }

        public void SwitchTask()
        {
            switch (_sw)
            {
                case 1:
                    MainNavigation.MainFrameNav.Navigate(new Page1());
                    break;
                case 2:
                    MainNavigation.MainFrameNav.Navigate(new Page2());
                    break;
                case 3:
                    MainNavigation.MainFrameNav.Navigate(new Page3());
                    break;
                case 4:
                    MainNavigation.MainFrameNav.Navigate(new Page4());
                    break;
                case 5:
                    MainNavigation.MainFrameNav.Navigate(new Page5());
                    break;
                case 6:
                    MainNavigation.MainFrameNav.Navigate(new Page6());
                    break;
                case 7:
                    MainNavigation.MainFrameNav.Navigate(new Page7());
                    break;
                case 8:
                    MainNavigation.MainFrameNav.Navigate(new Page8());
                    break;
                case 9:
                    MainNavigation.MainFrameNav.Navigate(new Page9());
                    break;
                case 10:
                    MainNavigation.MainFrameNav.Navigate(new Page10());
                    break;
                case 11:
                    MainNavigation.MainFrameNav.Navigate(new Page11());
                    break;
                case 12:
                    MainNavigation.MainFrameNav.Navigate(new Page12());
                    break;
                case 13:
                    MainNavigation.MainFrameNav.Navigate(new Page13());
                    break;
                case 14:
                    MainNavigation.MainFrameNav.Navigate(new Page14());
                    break;
                case 15:
                    MainNavigation.MainFrameNav.Navigate(new Page15());
                    break;


                case 16:
                    MainNavigation.MainFrameNav.Navigate(new Page16());
                    break;

                case 17:
                    MainNavigation.MainFrameNav.Navigate(new Page17());
                    break;

                case 18:
                    MainNavigation.MainFrameNav.Navigate(new Page18());
                    break;

                case 19:
                    MainNavigation.MainFrameNav.Navigate(new Page19());
                    break;

                case 20:
                    MainNavigation.MainFrameNav.Navigate(new Page20());
                    break;

                case 21:
                    MainNavigation.MainFrameNav.Navigate(new Page21());
                    break;

                case 22:
                    MainNavigation.MainFrameNav.Navigate(new Page22());
                    break;

                case 23:
                    MainNavigation.MainFrameNav.Navigate(new Page23());
                    break;

                case 24:
                    MainNavigation.MainFrameNav.Navigate(new Page24());
                    break;

                case 25:
                    MainNavigation.MainFrameNav.Navigate(new Page25());
                    break;

                case 26:

                    MainNavigation.MainFrameNav.Navigate(new Page26());

                    break;

                case 27:
                    MainNavigation.MainFrameNav.Navigate(new Page27());
                    break;

                case 28:
                    MainNavigation.MainFrameNav.Navigate(new Page28());
                    break;

                case 29:
                    MainNavigation.MainFrameNav.Navigate(new Page29());
                    break;

                case 30:
                    MainNavigation.MainFrameNav.Navigate(new Page30());
                    break;

                default:
                    MessageBox.Show("Неверный номер задания.");
                    break;
            }
        }
    }
}
