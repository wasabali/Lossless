using Lossless.MainPages;

namespace Lossless;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    void Login_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }

    void Register_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new RegisterUser());
    }
}


