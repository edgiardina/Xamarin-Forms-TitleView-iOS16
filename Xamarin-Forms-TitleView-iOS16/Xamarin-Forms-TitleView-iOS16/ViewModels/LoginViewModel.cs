using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin_Forms_TitleView_iOS16.Views;

namespace Xamarin_Forms_TitleView_iOS16.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
