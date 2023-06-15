using Lossless.MainPages;
using Lossless.Domain.Auth0;
using ThreadNetwork;

namespace Lossless;

public partial class MainPage : ContentPage
{
    private readonly Auth0Client auth0Client;

    public MainPage(Auth0Client client)
    {
        InitializeComponent();
        auth0Client = client;
    }


    private async void OnLoaded(object sender, EventArgs e)
    {
        var user = await auth0Client.GetAuthenticatedUser();

        if (user != null)
        {
            LoginView.IsVisible = false;
            HomeView.IsVisible = true;
        }
    }


    private async void Login_Clicked(object sender, EventArgs e)
    {
        var loginResult = await auth0Client.LoginAsync();

        if (!loginResult.IsError)
        {
            

            LoginView.IsVisible = false;
            HomeView.IsVisible = true;
            await Navigation.PushAsync(new LoginPage());
        }
        else
        {
            await DisplayAlert("Error", loginResult.ErrorDescription, "OK");
        }
    }


    private async void Register_Clicked(object sender, EventArgs e)
    {
        var logoutResult = await auth0Client.LogoutAsync();

        if (!logoutResult.IsError)
        {
            HomeView.IsVisible = false;
            LoginView.IsVisible = true;
            await Navigation.PushAsync(new RegisterUser());
        }
        else
        {
            await DisplayAlert("Login Failed", logoutResult.ErrorDescription, "OK");
        }
    }
}


