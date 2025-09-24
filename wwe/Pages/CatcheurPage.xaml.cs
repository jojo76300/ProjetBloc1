using wwe.ViewModels;

namespace wwe.Pages;

public partial class Catcheur : ContentPage
{
	public Catcheur(CatcheurViewModel catcheurViewModel)
	{
		InitializeComponent();

        // On met le ViewModel comme BindingContext
        BindingContext = catcheurViewModel;
    }
}
