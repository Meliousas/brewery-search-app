using System;
using App1.Models;
using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BeerDetailPage : ContentPage
    {
        BeerDetailViewModel viewModel;


        public Beer Beer { get; set; }

        public BeerDetailPage(BeerDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public BeerDetailPage()
        {
            InitializeComponent();

            var Beer = new Beer
            {
                Name = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new BeerDetailViewModel(Beer);
            BindingContext = viewModel;
        }

        async void Add_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddToMyBeer", viewModel.Beer);
        }
    }
}