﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TryApp
{
    public class View1 : ContentView
    {
        public View1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Content View" }
                }
            };
        }
    }
}