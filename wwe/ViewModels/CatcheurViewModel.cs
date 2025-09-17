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

    private bool HOF;

    private bool Actif;

    public CatcheurViewModel()
    {
        Nom = "Mark William Calaway";
        DateNaissance = new DateOnly(1965, 3, 24);
        Alias = "The Undertaker";
        Nationalite = "Americaine";
        Palmares = "1 fois champion poids lourds unifié de l'USWA, 1 fois champion poids lourds de la WCWA Texas, 4 fois champion de la WWF / WWE, 6 fois champion du monde par équipes de la WWE, 1 fois champion Hardcore de la WWE  ";
        HOF = true;
        Actif = false;
    }

}