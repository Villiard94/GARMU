//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GARMU.Modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipe
    {
        public Equipe()
        {
            this.JourMois = new HashSet<JourMois>();
            this.Patrouilleur = new HashSet<Patrouilleur>();
        }
    
        public int NoEquipe { get; set; }
        public string Nom { get; set; }
    
        public virtual ICollection<JourMois> JourMois { get; set; }
        public virtual ICollection<Patrouilleur> Patrouilleur { get; set; }
    }
}
