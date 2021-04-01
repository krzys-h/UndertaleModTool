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
using System.Windows.Shapes;

namespace UndertaleModTool
{
    /// <summary>
    /// Logika interakcji dla klasy StringUpdateWindow.xaml
    /// </summary>
    public partial class StringUpdateWindow
    {
        public enum ResultType
        {
            Cancel = 0,
            ChangeOneValue,
            ChangeReferencedValue
        }

        public ResultType Result { get; private set; } = ResultType.Cancel;

        public StringUpdateWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Result = ResultType.ChangeOneValue;
            Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Result = ResultType.ChangeReferencedValue;
            Close();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Result = ResultType.Cancel;
            Close();
        }
    }
}
