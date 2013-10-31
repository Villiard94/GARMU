using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace GARMU.Modele
//{
//    public partial class Employee
//    {
//        public string Fullname { get { return String.Format("{0} {1}", this.Prenom, this.Nom); } }

//        public string Matricule
//        {
//            get
//            {
//                if (this.Patrouilleur == null)
//                {
//                    return String.Empty;
//                }


//                return Patrouilleur.Matricule.ToString();
//            }
//            set
//            {
//                if (this.Patrouilleur == null)
//                {
//                    Matricule = null;
//                }
//                Matricule = value;
//            }
//        }

//        public string NoEquipe
//        {
//            get
//            {
//                if (this.Patrouilleur == null)
//                {
//                    return String.Empty;
//                }
//                return Patrouilleur.Equipe.NoEquipe.ToString();
//            }
//            set
//            {
//                if (this.Patrouilleur == null)
//                {
//                    NoEquipe = null;
//                }
//                NoEquipe = value;
//            }

//        }

//        public string NoVehicule
//        {
//            get
//            {
//                if (this.Patrouilleur == null)
//                {
//                    return String.Empty;
//                }
//                return Patrouilleur.Vehicule.NoVehicule.ToString();
//            }
//            set
//            {
//                if (this.Patrouilleur == null)
//                {
//                    NoVehicule = null;
//                }
//                NoVehicule = value;
//            }
//        }
//    }
//}
