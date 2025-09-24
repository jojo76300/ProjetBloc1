using wwe.ViewModels;

namespace wwe.Pages;

public partial class Championnat : ContentPage
{
	public Championnat()
	{
		InitializeComponent();

        // On met le ViewModel comme BindingContext
        BindingContext = new ChampionnatViewModel();
    }
}