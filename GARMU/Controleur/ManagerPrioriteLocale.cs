using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GARMU.Modele;

namespace GARMU.Controleur
{
    class ManagerPrioriteLocale : Manager<PrioriteLocale>
    {
        public ManagerPrioriteLocale(garmuBDEntities context)
            : base(context)
        {

        }

        public string Add(string priorite)
        {
            PrioriteLocale prio = new PrioriteLocale();
            prio.Nom = priorite;

            return Add(prio);
        }

        public string Delete(int prioriteId, PrioriteLocale newPrioriteLocale)
        {
            PrioriteLocale Priorite = Context.PrioriteLocale.FirstOrDefault(x => x.ID == prioriteId);

            if (Priorite == null)
            {
                return "erreur";
            }
            foreach (DetailPlanificationMensuelle detail in Priorite.DetailPlanificationMensuelle)
            {
                detail.PrioriteLocale = newPrioriteLocale;
            }
            

            Context.PrioriteLocale.Remove(Priorite);
            return Save();
        }

        public override List<PrioriteLocale> GetList()
        {
            return Context.PrioriteLocale.ToList<PrioriteLocale>();
        }

        protected override string Add(PrioriteLocale entity)
        {
            if (Exists(entity.Nom))
            {
                return "La priorité locale existe déja. Impossible de l'ajoutée.";
            }

            Context.PrioriteLocale.Add(entity);
            return "Réussite. La priorité locale à été ajoutée";
        }

        private bool Exists(string priorite)
        {
            if (Context.PrioriteLocale.Where(x => x.Nom == priorite) == null)
            {
                return false;
            }
            return true;
        }

        internal List<PrioriteLocale> SearchFor(string priorite)
        {
            return Context.PrioriteLocale.Where(x => x.Nom == priorite).ToList<PrioriteLocale>();
        }

    }
}
