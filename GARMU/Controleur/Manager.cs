using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GARMU.Modele;

namespace GARMU.Controleur
{
    public abstract class Manager<TEntity>
    {
        protected garmuBDEntities Context { get; private set; }

        public Manager(garmuBDEntities context)
        {
            Context = context;
        }

        public abstract List<TEntity> GetList();

        protected abstract string  Add(TEntity entity);

        /// <summary>
        /// Tente de sauvegarger les modifications apportées au modèle
        /// </summary>
        /// <returns>Si la sauvegarde a réussi</returns>
        protected string Save()
        {
            try
            {
                Context.SaveChanges();
                return AppCst.SUCCESS;
            }
            catch { return AppCst.ERROR; }
        }
    }
}
