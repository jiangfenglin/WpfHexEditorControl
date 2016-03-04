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

namespace WPFHexaEditorExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //TEMPS
            HexEdit.FileName = @"C:\Test\NETwsw01.sys";
        }

        private void SetPositionButton_Click(object sender, RoutedEventArgs e)
        {
            HexEdit.SetPosition("0x20FF");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            HexEdit.BytePerLine = 26;
        }
    }
}