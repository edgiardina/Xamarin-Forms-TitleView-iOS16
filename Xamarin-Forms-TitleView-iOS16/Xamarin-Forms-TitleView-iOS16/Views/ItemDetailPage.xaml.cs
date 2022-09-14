using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Forms_TitleView_iOS16.ViewModels;

namespace Xamarin_Forms_TitleView_iOS16.Views
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