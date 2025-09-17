namespace wwe.Models;

public class Catcheur
{
    public string Nom { get; set; }
    public DateTime DateDeNaissance { get; set; }

    // Méthode pour obtenir l'âge
    public int GetAge()
    {
        var aujourdhui = DateTime.Today;
        var age = aujourdhui.Year - DateDeNaissance.Year;

        if (DateDeNaissance.Date > aujourdhui.AddYears(-age))
        {
            age--;
        }

        return age;
    }
    
}