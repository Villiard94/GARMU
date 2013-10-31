using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GARMU.Modele
{
    public class ModelBDGarmu
    {
        public garmuBDEntities Context { get; private set; }

        public ModelBDGarmu()
        {
            if (Context == null)
            {
                Context = new garmuBDEntities();
            }
        }
    }
}
