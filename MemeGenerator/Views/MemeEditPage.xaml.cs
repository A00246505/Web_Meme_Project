using System;
using System.Collections.Generic;
using System.Diagnostics;
using MemeGenerator.Services;
using MemeGenerator.ViewModels;
using Xamarin.Forms;

namespace MemeGenerator.Views
{
    
    public partial class MemeEditPage : ContentPage
    {


        public MemeEditPage()
        {
            InitializeComponent();
            BindingContext = new MemeEditViewModel();
        }

        
    }
}
