using StoreConePantallas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StoreConePantallas.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}