using App1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class BeerViewModel : BaseViewModel{
        public Command LoadItemsCommand { get; set; }
        public ObservableCollection<Beer> Beers { get; set; }

        public BeerViewModel()
        {
            Title = "Beers";
            Beers = new ObservableCollection<Beer>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadBeersCommand());

        }

        async Task ExecuteLoadBeersCommand()
        {
            if (IsBusy)
            {
                return;
            }
            IsBusy = true;
            try
            {
                
            }
        }


    }
}
