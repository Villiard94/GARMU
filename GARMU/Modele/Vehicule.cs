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
    
    public partial class Vehicule
    {
        public Vehicule()
        {
            this.Patrouilleur = new HashSet<Patrouilleur>();
        }
    
        public int ID { get; set; }
        public string NoVehicule { get; set; }
    
        public virtual ICollection<Patrouilleur> Patrouilleur { get; set; }
    }
}
