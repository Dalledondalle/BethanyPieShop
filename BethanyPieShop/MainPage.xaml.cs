﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BethanyPieShop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DemoButton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was clicked";
        }
    }
}
