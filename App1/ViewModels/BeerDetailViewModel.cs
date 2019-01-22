using App1.Models;

namespace App1.ViewModels
{
    public class BeerDetailViewModel : BaseViewModel
    {
        public Beer Beer { get; set; }

        public BeerDetailViewModel(Beer item = null)
        {
            Title = item?.Name;
            Beer = item;
        }
    }
}