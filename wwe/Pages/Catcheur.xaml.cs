using wwe.ViewModels;

namespace wwe.Pages;

public partial class Catcheur : ContentPage
{
	public Catcheur()
	{
		InitializeComponent();

        // On met le ViewModel comme BindingContext
        BindingContext = new CatcheurViewModel();
    }
}
