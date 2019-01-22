﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.brewerydb.com/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}