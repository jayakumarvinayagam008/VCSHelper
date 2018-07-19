using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSHelper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VCSHelper.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
		}
        protected override async void OnAppearing()
        {
            var content = this.Content;
            this.Content = null;
            this.Content = content;
            var vm = BindingContext as LoginViewModel;
        }
    }
}