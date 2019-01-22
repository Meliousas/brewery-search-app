using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyBeerDetailPage : ContentPage
    {
        BeerDetailViewModel viewModel;


        public MyBeerDetailPage(BeerDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

//        public MyBeerDetailPage()
//        {
//            InitializeComponent();
//
//            var Beer = new Beer
//            {
//                Name = "Item 1",
//                Description = "This is an item description."
//            };
//
//            viewModel = new BeerDetailViewModel(Beer);
//            BindingContext = viewModel;
//        }

//        async void Update(object sender, EventArgs e)
//        {
//            MessagingCenter.Send(this, "AddToMyBeer", viewModel.Beer);
//        }
    }
}