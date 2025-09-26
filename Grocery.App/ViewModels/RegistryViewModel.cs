
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.App.Views;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels
{
    public partial class RegistryViewModel : BaseViewModel
    {
        private readonly IAuthService _authService;
        private readonly IClientService _clientService;
        private readonly GlobalViewModel _global;

        [ObservableProperty]
        private string email = "";

        [ObservableProperty]
        private string password = "";

        [ObservableProperty]
        private string name = "";

        [ObservableProperty]
        private string loginMessage;

        public RegistryViewModel(IAuthService authService, IClientService clientService, GlobalViewModel global)
        { //_authService = App.Services.GetServices<IAuthService>().FirstOrDefault();
            _authService = authService;
            _clientService = clientService;
            _global = global;
        }

        [RelayCommand]
        private void ConfirmRegistry()
        {
            bool ok = _authService.CheckEmail(Email);
            if (ok == false)
            {
                LoginMessage = "Voer een geldig emailadres in.";
            }
            else
            {
                _clientService.AddClient(Name, Email, Password);
                ToLogin();
            }
            return;
        }

        [RelayCommand]
        public async Task ToLogin()
        {
            Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
            await Shell.Current.GoToAsync(nameof(LoginView));
        }
    }
}
