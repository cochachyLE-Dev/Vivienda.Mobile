namespace Vivienda.Mobile.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        private bool _canLogin = true;
        public bool CanLogin
        {
            get => _canLogin;
            set => SetProperty(ref _canLogin, value);
        }
    }
}
