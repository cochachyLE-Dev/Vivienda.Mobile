using Vivienda.Domain.Common;
using Vivienda.Mobile.ViewModels;
using Vivienda.Service.Contract;

using System.Linq;
using System.Threading.Tasks;

namespace Vivienda.Mobile.Presenters
{
    public class LoginPresenter : IOutputPort<Response<string>>
    {
        private readonly LoginViewModel _loginViewModel;

        public LoginPresenter(LoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
        }

        public Task Handler(Response<string> response)
        {
            if (response.Succeeded)
                _loginViewModel.StatusText = "Signed in!";
            else
            {
                _loginViewModel.StatusText = response.Errors.First();
                _loginViewModel.CanLogin = true;
                _loginViewModel.IsBusy = false;
            }
            return Task.CompletedTask;
        }
    }
}
