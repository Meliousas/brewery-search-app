using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using App1.Models;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MyBeerViewModel : BaseViewModel
    {
        public Command LoadItemsCommand { get; set; }
        public ObservableCollection<Beer> MyBeers { get; set; }

        public MyBeerViewModel()
        {
            Title = "MyBeers";
            MyBeers = new ObservableCollection<Beer>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadBeersCommand());

            MessagingCenter.Subscribe(this, "AddToMyBeer",
                (Action<BeerDetailPage, Beer>) (async (obj, item) =>
                {
                    var newItem = item;
                    MyBeers.Add(newItem);
                    await BeerStore.AddMyBeer(newItem);
                }));
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
                MyBeers.Clear();
                var beers = await BeerStore.GetMyBeersAsync(true);
                foreach (var beer in beers)
                {
                    MyBeers.Add(beer);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}