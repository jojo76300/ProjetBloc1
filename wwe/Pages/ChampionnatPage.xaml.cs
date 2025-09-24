using wwe.ViewModels;

namespace wwe.Pages;

public partial class Championnat : ContentPage
{
	public Championnat(ChampionnatViewModel championnatViewModel)
	{
		InitializeComponent();

        // On met le ViewModel comme BindingContext
        BindingContext = championnatViewModel;
    }
}