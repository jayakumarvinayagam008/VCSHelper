using System.Threading.Tasks;
using VCSHelper.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VCSHelper
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new MainPage();
            ViewModelLocator.RegisterDependencies(false);
        }

        private void InitApp()
        {
            ViewModelLocator.RegisterDependencies(false);
        }
        protected override async void OnStart()
        {
            // Handle when your app starts
            base.OnStart();

            if (Device.RuntimePlatform != Device.UWP)
            {
                await InitNavigation();
            }

            //if (!Settings.UseMocks && !string.IsNullOrEmpty(Settings.AuthAccessToken))
            //{
            //    await SendCurrentLocation();
            //}

            base.OnResume();
        }

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }
    }
}
