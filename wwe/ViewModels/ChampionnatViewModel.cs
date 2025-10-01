using System;
using System.Collections.ObjectModel;
using wwe.Models;

namespace wwe.ViewModels;

public class ChampionnatViewModel
{
    public ObservableCollection<Championnat> Championnats { get; set; }

    // Constructeur
    public ChampionnatViewModel()
    {
        Championnats = new ObservableCollection<Championnat>
        {
            new Championnat
            {
                Nom = "WWE Championship",
                Info = "Le WWE Championship est le titre principal de la WWE, créé en 1963. Il est considéré comme le championnat le plus prestigieux de la compagnie et a été détenu par des légendes comme Bruno Sammartino, Hulk Hogan, Stone Cold Steve Austin, The Rock et John Cena. Il est défendu dans tous les grands shows et pay-per-views et représente le sommet de la carrière d’un catcheur dans le monde du catch professionnel.",
                DateCreation = new DateTime(1963, 4, 11),
                Periode = " ",
                TenantTitre = "Cody Rhodes",
                Image = "wwechampionship.png"
            },
            new Championnat
            {
                Nom = "WWE World Heavyweight Championship",
                Info = "Le Championnat du monde des poids lourds est un championnat du monde de catch masculin créé et promu par la promotion américaine WWE , défendu dans la division Raw . C'est l'un des deux titres mondiaux masculins du roster principal de la WWE, avec le Championnat incontesté de la WWE à SmackDown . Le champion actuel est Seth Rollins , qui en est à son deuxième règne, un record égalé. Il a remporté le titre en battant l'ancien champion CM Punk lors de son match de cash-in Money in the Bank lors de la première soirée de SummerSlam le 2 août 2025, peu après que Punk ait battu Gunther pour le titre.",
                DateCreation = new DateTime(2023, 4, 12),
                Periode = " ",
                TenantTitre = "Seth Rollins",
                Image = "worldheavyweightchampionship.png"
            },
        };
    }
}
