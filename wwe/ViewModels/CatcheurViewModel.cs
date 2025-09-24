using System;

namespace wwe.ViewModels;

public class CatcheurViewModel
{
    // Propriétés publiques pour le binding
    public string Nom { get; set; }
    public DateOnly DateNaissance { get; set; }
    public string Alias { get; set; }
    public string Nationalite { get; set; }
    public string Palmares { get; set; }
    public bool HOF { get; set; }
    public bool Actif { get; set; }

    // Calcul de l'âge automatiquement
    public int Age
    {
        get
        {
            var aujourdHui = DateOnly.FromDateTime(DateTime.Today);
            var age = aujourdHui.Year - DateNaissance.Year;

            if (DateNaissance.DayOfYear > aujourdHui.DayOfYear)
                age--;

            return age;
        }
    }

    // Constructeur par défaut avec exemple de catcheur
    public CatcheurViewModel()
    {
        Nom = "Mark William Calaway";
        DateNaissance = new DateOnly(1965, 3, 24);
        Alias = "The Undertaker";
        Nationalite = "Americaine";
        Palmares = "1 fois champion poids lourds unifié de l'USWA, 1 fois champion poids lourds de la WCWA Texas, 4 fois champion de la WWF / WWE, 6 fois champion du monde par équipes de la WWE, 1 fois champion Hardcore de la WWE";
        HOF = true;
        Actif = false;
    }
}
