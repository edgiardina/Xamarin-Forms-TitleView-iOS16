using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin_Forms_TitleView_iOS16.ViewModels;
using Xamarin_Forms_TitleView_iOS16.Views;

namespace Xamarin_Forms_TitleView_iOS16
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
