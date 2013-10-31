using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GARMU.Modele;

namespace GARMU.Controleur
{
    class ManagerVehicule : Manager<Vehicule>
    {
        public ManagerVehicule(garmuBDEntities context)
            : base(context)
        {

        }

        public string Add(string numeroVeh)
        {
            Vehicule veh = new Vehicule();

            //Ajout des champs
            veh.NoVehicule = numeroVeh;

            // Création de la liste d'entités pouvant pointer vers celle-ci.
            // Relation un à plusieurs (Un Véhicule peut être utilisé par plusieurs Patrouilleurs)
            veh.Patrouilleur = new List<Patrouilleur>();

            return Add(veh);
        }

        /// <summary>
        /// Supprimer l'entité spécifier
        /// </summary>
        /// <param name="noVeh">Numéro du véhicule à supprimer</param>
        /// <param name="nouveauVehicule">Nouveau véhicule à assigner aux patrouilleurs qui avaient ce véhicule de préférence (spécifier null au besoin)</param>
        /// <returns>Retourne vrai si l'opération est réussite</returns>
        public string Delete(string noVeh, Vehicule nouveauVehicule)
        {
            //Aller chercher le véhicule à supprimer
            Vehicule vehicule = Context.Vehicule.FirstOrDefault(x => x.NoVehicule == noVeh);

            // Vérifier si le véhicule à supprimer existe vraiment
            if (vehicule == null)
                return "erreur";

            //Assigne le vehicule aux patrouilleurs (ou spécifie null)
            foreach (Patrouilleur pat in vehicule.Patrouilleur)
            {
                pat.Vehicule = nouveauVehicule;
            }

            //Enlever l'entitée
            Context.Vehicule.Remove(vehicule);
            

            return Save();
        }

        public override List<Vehicule> GetList()
        {
            // Retourne la liste complète
            return Context.Vehicule.ToList<Vehicule>();
        }

        /// <summary>
        /// Cette méthode sert à s'assurer que le véhicule n'existe pas déja
        /// </summary>
        /// <param name="entity">Le véhicule à ajouter dans le context</param>
        /// <returns>Retourne l'entité si cela a fonctionné</returns>
        protected override string Add(Vehicule entity)
        {
            //S'il existe déja on sort et retourne null
            if (Exists(entity.NoVehicule))
            {
                return AppCst.ERROR_VEHICULE_EXISTS;
            }

            //Àjouter l'entité en question
            Context.Vehicule.Add(entity);

            return Save();
        }

        //Vérifier si l'entité existe
        private bool Exists(string noVeh)
        {
            if (Context.Vehicule.Any(x => x.NoVehicule == noVeh))
            {
                return true;
            }

            return false;
        }

        internal List<Vehicule> SearchFor(string numeroVeh)
        {
            return Context.Vehicule.Where(x => x.NoVehicule == numeroVeh).ToList<Vehicule>();

        }

        internal string Modify(Vehicule v, string newNoVeh)
        {
            if (Exists(newNoVeh))
                return AppCst.ERROR_VEHICULE_EXISTS;

            v.NoVehicule = newNoVeh;

            return Save();
        }
    }
}
