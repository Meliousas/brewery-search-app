using System;
using App1.Models;
using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyBeersPage : ContentPage
    {
        MyBeerViewModel viewModel;

        public MyBeersPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MyBeerViewModel();
        }

        async void OnBeerSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Beer;
            if (item == null)
                return;

            await Navigation.PushAsync(new MyBeerDetailPage(new BeerDetailViewModel(item)));

            // Manually deselect item.
            BeersListView.SelectedItem = null;
        }

        async void AddBeer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewBeerPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.MyBeers.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}