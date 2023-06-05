using Lossless.MainPages;

namespace Lossless;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void Login_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }

    private void Register_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new RegisterUser());
    }
}


