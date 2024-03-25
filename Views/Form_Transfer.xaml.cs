﻿using ListOfCustomers_New.VIewModel;
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
using System.Windows.Shapes;

namespace ListOfCustomers_New.Views
{
    /// <summary>
    /// Логика взаимодействия для Form_Transfer.xaml
    /// </summary>
    public partial class Form_Transfer : Window
    {
        object Obj;

        public Form_Transfer(object obj)
        {
            InitializeComponent();
            Loaded += CustomersAccountsForm_Loaded;
            this.Obj = obj;
        }

        private void CustomersAccountsForm_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new TransferAccountsViewModel(Obj, this);
        }
    }
}



