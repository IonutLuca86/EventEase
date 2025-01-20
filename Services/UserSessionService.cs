using EventEase.Models;
using Blazored.LocalStorage;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public bool IsLoggedIn { get; private set; }
        public RegistrationModel CurrentUser { get; private set; }
        private readonly ILocalStorageService _localStorage;
        private const string UserKey = "currentUser";

        public UserSessionService(ILocalStorageService localStorage) 
        { 
            _localStorage = localStorage; InitializeUser(); 
        }
        private async void InitializeUser() 
        { 
            CurrentUser = await _localStorage.GetItemAsync<RegistrationModel>(UserKey); 
            IsLoggedIn = CurrentUser != null; 
        }
        public async Task Register(RegistrationModel registration)
        {
            CurrentUser = registration;
            IsLoggedIn = true;
            await _localStorage.SetItemAsync(UserKey, registration);
        }

        public async Task Logout()
        {
            CurrentUser = null;
            IsLoggedIn = false;
            await _localStorage.RemoveItemAsync(UserKey);
        }

        public RegistrationModel GetCurrentUser()
        {
            return CurrentUser;
        }
    }
}
