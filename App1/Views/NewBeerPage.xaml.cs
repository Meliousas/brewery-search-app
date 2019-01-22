using System;
using App1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewBeerPage : ContentPage
    {
        public Beer Beer { get; set; }

        public NewBeerPage()
        {
            InitializeComponent();

            Beer = new Beer
            {
                Name = "Beer name",
                Description = "This is a beer description."
            };
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Beer);
            await Navigation.PopModalAsync();
        }
    }
}