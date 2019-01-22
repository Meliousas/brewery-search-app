using System;
using App1.Models;
using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BeersPage : ContentPage
    {
        BeersViewModel viewModel;

        public BeersPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new BeersViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var beers = args.SelectedItem as Beer;
            if (beers == null)
                return;

            await Navigation.PushAsync(new BeerDetailPage(new BeerDetailViewModel(beers)));

            // Manually deselect item.
            BeersListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewBeerPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Beers.Count == 0)
                viewModel.LoadBeersCommand.Execute(null);
        }
    }
}