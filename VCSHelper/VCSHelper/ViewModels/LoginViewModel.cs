using System;
using System.Threading.Tasks;
using System.Windows.Input;
using VCSHelper.ViewModels.Base;
using Xamarin.Forms;

namespace VCSHelper.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
        private ValidatableObject<string> _userName;
        private ValidatableObject<string> _password;
        public LoginViewModel()
        {
            _userName = new ValidatableObject<string>();
            _password = new ValidatableObject<string>();
            AddValidations();
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

        public ValidatableObject<string> Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }
        public ICommand SignInCommand => new Command(async () => await SignInAsync());

        private Task SignInAsync()
        {
            throw new NotImplementedException();
        }

        public ICommand ForgotPasswordCommand => new Command(async () => await ForgotPasswordAsync());

        private async Task ForgotPasswordAsync()
        {
            await NavigationService.NavigateToAsync<ForgotPasswordViewModel>();
        }

        public ICommand SignUpCommand => new Command(async () => await SignUpAsync());

        private async Task SignUpAsync()
        {
            await NavigationService.NavigateToAsync<SignUpViewModel>();
        }

        private bool ValidateUserName()
        {
            return _userName.Validate();
        }

        private bool ValidatePassword()
        {
            return _password.Validate();
        }
        private void AddValidations()
        {
            _userName.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A username is required." });
            _password.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A password is required." });
        }
    }
}
