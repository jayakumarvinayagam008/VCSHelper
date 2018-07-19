using VCSHelper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VCSHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserActivationView : ContentPage
	{
		public UserActivationView ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            var content = this.Content;
            this.Content = null;
            this.Content = content;
            var vm = BindingContext as UserActivationViewModel;
        }
    }
}