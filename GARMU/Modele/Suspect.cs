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
    
    public partial class Suspect
    {
        public Suspect()
        {
            this.DemandeSpeciale = new HashSet<DemandeSpeciale>();
        }
    
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DDN { get; set; }
        public string DescriptionPhysique { get; set; }
    
        public virtual ICollection<DemandeSpeciale> DemandeSpeciale { get; set; }
    }
}
