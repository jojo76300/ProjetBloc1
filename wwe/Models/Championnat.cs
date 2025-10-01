namespace wwe.Models;

public class Championnat
{
    public string Nom { get; set; }
    
    public string Info { get; set; }
    
    public DateTime DateCreation { get; set; }
    
    public string Periode { get; set; }
    
    public string TenantTitre { get; set; }

    public string Image { get; set; }

    public string DateCreationTexte => $"Créé le : {DateCreation:dd/MM/yyyy}";
    public string PeriodeTexte => $"Période : {Periode}";
    public string TenantTitreTexte => $"Tenant du titre : {TenantTitre}";
    public string InfoTexte => $"Info : {Info}";
    public string NomTexte => $"Nom : {Nom}";

}