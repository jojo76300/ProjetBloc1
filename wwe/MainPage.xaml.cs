namespace wwe;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        // Navigation vers la page Accueil
        await Shell.Current.GoToAsync(nameof(Pages.Accueil));
    }

}