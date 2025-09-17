namespace wwe.ViewModels;

public class ChampionnatViewModel
{
    private string Nom;
    
    private string Info;
    
    private DateOnly DateCreation;
    
    private string Periode;
    
    private string TenantTitre;
    
    public ChampionnatViewModel()
    {
        Nom = "WWE Championship";
        Info = "Le WWE Championship est le titre principal de la WWE, créé en 1963. Il est considéré comme le championnat le plus prestigieux de la compagnie et a été détenu par des légendes comme Bruno Sammartino, Hulk Hogan, Stone Cold Steve Austin, The Rock et John Cena. Il est défendu dans tous les grands shows et pay-per-views et représente le sommet de la carrière d’un catcheur dans le monde du catch professionnel.";
        DateCreation = new DateOnly(1963, 4, 11);
        Periode = " ";
        TenantTitre = "Cody Rhodes";
    }
}