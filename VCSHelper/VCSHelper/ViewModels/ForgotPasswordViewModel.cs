using System.Threading.Tasks;
using System.Windows.Input;
using VCSHelper.ViewModels.Base;
using Xamarin.Forms;

namespace VCSHelper.ViewModels
{
    public class ForgotPasswordViewModel: ViewModelBase
    {
        private ValidatableObject<string> _userName;
        public ForgotPasswordViewModel()
        {
            _userName = new ValidatableObject<string>();
        }

        public ValidatableObject<string> UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }
        public ICommand PasswordRequestCommand => new Command( async () => await PasswordRequest());

        private async Task PasswordRequest()
        {
          await NavigationService.NavigateToAsync<LoginViewModel>();
        }
    }
}
