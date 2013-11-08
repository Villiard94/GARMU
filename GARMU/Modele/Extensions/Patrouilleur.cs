using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GARMU.Modele
{
    public partial class Patrouilleur
    {
        public string Nom
        {
            get
            {
                return Employee.Nom.ToString();
            }
        }

        public string Prenom
        {
            get
            {
                return Employee.Prenom.ToString();
            }
        }

        public string Id
        {
            get { return Employee.ID.ToString(); }
        }

    }
}
