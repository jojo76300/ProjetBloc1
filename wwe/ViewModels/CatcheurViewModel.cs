namespace wwe.ViewModels;

public partial class CatcheurViewModel
{
    private string Nom;
    
    private DateOnly DateNaissance;

    public int Age
    {
        get
        {
            var aujourdhui = DateOnly.FromDateTime(DateTime.Today);
            var age = aujourdhui.Year - DateNaissance.Year;

            // Ajustement si l'anniversaire n'est pas encore passé cette année
            if (DateNaissance.DayOfYear > aujourdhui.DayOfYear)
            {
                age--;
            }

            return age;
        }
    }
    
    private string Alias;

    private string Nationalite;

    private string Palmares;

    private string Ring;

    private bool HOF;

    private bool Actif;

    public CatcheurViewModel()
    {
        Nom = "Mark William Calaway";
        DateNaissance = new DateOnly(1965, 3, 24);
    }

}