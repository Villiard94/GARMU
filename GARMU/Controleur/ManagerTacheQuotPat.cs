using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GARMU.Modele;

namespace GARMU.Controleur
{
    internal class ManagerTacheQuotPat : Manager<TacheQuotidienne>
    {
        public ManagerTacheQuotPat(garmuBDEntities context)
            : base(context)
        {

        }

        internal string Add()
        {
            TacheQuotidienne tache = new TacheQuotidienne();

            //Ajout des champs
            tache.DixVingt = "";
            tache.JourMois = new JourMois();
            tache.Patrouilleur = new List<Patrouilleur>();
            tache.Secteur = new Secteur();
            tache.TacheQuotidienne_Assignation = new List<TacheQuotidienne_Assignation>();

            return "";
        }

        public override List<TacheQuotidienne> GetList()
        {
            throw new NotImplementedException();
        }

        protected override string Add(TacheQuotidienne entity)
        {
            throw new NotImplementedException();
        }
    }
}
