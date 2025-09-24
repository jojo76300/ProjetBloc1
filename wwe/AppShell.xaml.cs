namespace wwe;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // On enregistre la route de la page Accueil
        Routing.RegisterRoute(nameof(Pages.Accueil), typeof(Pages.Accueil));
    }
}