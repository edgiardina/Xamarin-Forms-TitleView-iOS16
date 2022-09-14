using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin_Forms_TitleView_iOS16.Models;
using Xamarin_Forms_TitleView_iOS16.ViewModels;

namespace Xamarin_Forms_TitleView_iOS16.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}