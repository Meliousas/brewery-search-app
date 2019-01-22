using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using App1.Models;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class BeersViewModel : BaseViewModel
    {
        public ObservableCollection<Beer> Beers { get; set; }
        public Command LoadBeersCommand { get; set; }

        public BeersViewModel()
        {
            Title = "Browse";
            Beers = new ObservableCollection<Beer>();
            LoadBeersCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe(this, "AddItem",
                (Action<NewBeerPage, Beer>) (async (obj, item) =>
                {
                    var newItem = item;
                    Beers.Add(newItem);
                    await BeerStore.AddItemAsync(newItem);
                }));
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Beers.Clear();
                var items = await BeerStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Beers.Add(item);
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