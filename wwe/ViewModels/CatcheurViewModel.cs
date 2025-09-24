using System;
using System.Collections.ObjectModel;
using wwe.Models;

namespace wwe.ViewModels
{
    public class CatcheurViewModel
    {
        // Liste de catcheurs pour le binding
        public ObservableCollection<Catcheur> Catcheurs { get; set; }

        public CatcheurViewModel()
        {
            Catcheurs = new ObservableCollection<Catcheur>
            {
                new Catcheur
                {
                    Nom = "Mark William Calaway",
                    Alias = "The Undertaker",
                    Nationalite = "USA",
                    DateNaissance = new DateOnly(1965,3,24),
                    Palmares = "1 fois champion poids lourds unifié de l'USWA, 1 fois champion poids lourds de la WCWA Texas, 4 fois champion de la WWF / WWE, 6 fois champion du monde par équipes de la WWE, 1 fois champion Hardcore de la WWE",
                    Actif = false,
                    HOF = true,
                    Image = "undertaker.png"
                },
                new Catcheur
                {
                    Nom = "Leati Joseph « Joe » Anoa'i",
                    Alias = "Roman Reigns",
                    Nationalite = "USA",
                    DateNaissance = new DateOnly(1985,5,25),
                    Palmares = "4 fois champion Universel, 3 fois champion du monde poids lourds",
                    Actif = true,
                    HOF = false,
                    Image = "romanreigns.png"
                },
                new Catcheur
                {
                    Nom = "Gionna Jene Daddio",
                    Alias = "Liv Morgan",
                    Nationalite = "USA",
                    DateNaissance = new DateOnly(1994,6,8),
                    Palmares = "Double championne du monde et détentrice du Money in the Bank 2022.",
                    Actif = true,
                    HOF = false,
                    Image = "livmorgan.png"
                }
            };
        }
    }
}
