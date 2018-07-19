using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VCSHelper.ViewModels.Base;
using Xamarin.Forms;

namespace VCSHelper.ViewModels
{
    public class UserActivationViewModel: ViewModelBase
    {
        private ValidatableObject<string> _activationKey;
        public UserActivationViewModel()
        {
            _activationKey = new ValidatableObject<string>();
        }

        public ValidatableObject<string> ActivationKey {
            get { return _activationKey; }
            set
            {
                _activationKey = value;
                RaisePropertyChanged(() => ActivationKey);
            }
        }
        public ICommand ActivateCommand => new Command(async () => await ActivateAsync());

        private async Task ActivateAsync()
        {
            await NavigationService.NavigateToAsync<LoginViewModel>();
        }
    }
}
