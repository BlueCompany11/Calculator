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

namespace ExceptionalCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calculator;
        string currentEquasion;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            calculator.Add(Convert.ToDouble(Value.Text));
            Value.Text = calculator.Value.ToString();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Inverse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void C_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
