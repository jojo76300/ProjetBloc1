namespace wwe.Models;

public class Catcheur
{
    public string Nom { get; set; }

    public DateOnly DateNaissance { get; set; }

    public string Alias { get; set; }

    public string Nationalite { get; set; }

    public string Palmares { get; set; }

    public bool HOF { get; set; }

    public bool Actif { get; set; }

    public string Image { get; set; }

    public int Age
    {
        get
        {
            var aujourdhui = DateOnly.FromDateTime(DateTime.Today);
            int age = aujourdhui.Year - DateNaissance.Year;
            if (DateNaissance.DayOfYear > aujourdhui.DayOfYear)
                age--;
            return age;
        }

    }

    public string AgeTexte => $"Age : {Age}";
    public string ActifTexte => $"Actif : {Actif}";
    public string HOFTexte => $"Hall Of Fame : {HOF}";
    public string DateNaissanceTexte => $"Né le : {DateNaissance.ToString("dd/MM/yyyy")}";
    public string NationaliteTexte => $"Nationalité : {Nationalite}";
    public string AliasTexte => $"Nom de ring : {Alias}";
    public string PalmaresTexte => $"Palmarès : {Palmares}";


}