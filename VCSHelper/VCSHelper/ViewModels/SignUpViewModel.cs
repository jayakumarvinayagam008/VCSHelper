using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VCSHelper.ViewModels.Base;
using Xamarin.Forms;

namespace VCSHelper.ViewModels
{
    class SignUpViewModel: ViewModelBase
    {
        private ValidatableObject<string> _email;
        private ValidatableObject<string> _password;
        private ValidatableObject<string> _firstName;
        private ValidatableObject<string> _lastName;
        private ValidatableObject<string> _phoneNumber;
        public SignUpViewModel()
        {
            _email = new ValidatableObject<string>();
            _password = new ValidatableObject<string>();
            _firstName = new ValidatableObject<string>();
            _lastName = new ValidatableObject<string>();
            _phoneNumber = new ValidatableObject<string>();
            AddValidations();
        }

        public ValidatableObject<string> Email
        {
            get{ return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged(() => Email);
            }
        }

        public ValidatableObject<string> FirstName
        {
            get { return _firstName; }
            set {
                _firstName = value;
                RaisePropertyChanged(() => FirstName);
            }
        }

        public ValidatableObject<string> LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChanged(() => LastName);
            }
        }

        public ValidatableObject<string> PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                RaisePropertyChanged(() => PhoneNumber);
            }
        }

        public ValidatableObject<string> Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public ICommand CreateCommand => new Command(async () => await CreateAsync());

        private async Task CreateAsync()
        {
            await NavigationService.NavigateToAsync<UserActivationViewModel>();
        }

        public ICommand CancelCommand => new Command(async () => await CancelAsync());

        private async Task CancelAsync()
        {
            await NavigationService.NavigateToAsync<LoginViewModel>();
        }

        private void AddValidations()
        {
            _email.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A email is required." });
            _password.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A password is required." });
            _firstName.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A first name is required." });
            _lastName.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A last name is required." });
            _phoneNumber.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A phone number is required." });
        }
    }
}
