﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fabu.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPageView : TabbedPage
    {
        public MainTabbedPageView()
        {
            InitializeComponent();
        }
    }
}