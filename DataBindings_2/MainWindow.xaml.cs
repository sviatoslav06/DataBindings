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

namespace DataBindings_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel model = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = model;
        }
    }
    class ViewModel
    {
        public User MyUser { get; set; }
        public User MyUser2 { get; set; }
        public ViewModel()
        {
            MyUser = new User()
            {
                Name = "Bob",
                Email = "bob@gmail.com"
            };
            MyUser2 = new User()
            {
                Name = "Tom",
                Email = "tom@gmail.com"
            };
        }
    }
}
