﻿using System;
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
using Wpfchik.Core;

namespace Wpfchik.Pages
{

    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnTask_Click(object sender, RoutedEventArgs e)
        {
            int sw = Convert.ToInt32(NumTask.Text);

            SwitchToTask choice = new SwitchToTask(Convert.ToInt32(NumTask.Text));
            choice.SwitchTask();
            NumTask.Clear();
        }

    }
}
