using QrPassTermRegist.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace QrPassTermRegist.Views
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