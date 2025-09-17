namespace wwe.Models;

public class Catcheur
{
    public string Nom { get; set; }
    
    public DateOnly DateNaissance { get; set; }
    
    public string Alias { get; set; }
    
    public string Nationalite{get;set;}
    
    public string Ring{get;set;}
    
    public string Palmares{get;set;}

    public bool HOF{get;set;}
    
    public bool Actif{get;set;}
    
}