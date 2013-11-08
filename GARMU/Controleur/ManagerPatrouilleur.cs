using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GARMU.Modele;

namespace GARMU.Controleur
{
    class ManagerPatrouilleur : Manager<Patrouilleur>
    {
        public ManagerPatrouilleur(garmuBDEntities context)
            : base(context)
        {

        }


        public string Add(string Nom, string Prenom, string Matricule, string NoEquipe, string NoVehicule)
        {
            Patrouilleur pat = new Patrouilleur();

            pat.Employee.Nom = Nom;
            pat.Employee.Prenom = Prenom;
            pat.Matricule = int.Parse(Matricule);
            pat.EquipeNoEquipe = int.Parse(NoEquipe);
            pat.VehiculeID = int.Parse(NoVehicule);

            return Add(pat);

        }

        //public bool Delete(string NomComplet, Patrouilleur nouveauPatrouilleur)
        //{
        //    Employee employe = Context.Employee.FirstOrDefault(x => x.Fullname == NomComplet);

        //    if (employe == null)
        //    {
        //        return false;
        //    }

        //    foreach (DemandeSpeciale demande in employe.DemandeSpeciale)
        //    {
        //        demande.Employee.Patrouilleur = nouveauPatrouilleur;
        //    }


        //    Context.Employee.Remove(employe);

        //    return Save();
        //}




        public override List<Patrouilleur> GetList()
        {
            return Context.Patrouilleur.ToList<Patrouilleur>();
        }

        protected override string Add(Patrouilleur entity)
        {

            if (Exists(entity.Matricule.ToString()))
            {
                return "L'employé existe déja. Impossbile de l'ajouté.";
            }
            Context.Patrouilleur.Add(entity);
            return "Réussite. L'employé a été ajouté";
        }

        private bool Exists(string FullName)
        {


            if (Context.Employee.Where(x => x.Fullname == FullName) == null)
            {
                return false;
            }
            return true;
        }

        internal List<Patrouilleur> SearchFor(string Nom, string Prenom, string Matricule, string NoEquipe, string NoVehicule)
        {
            Patrouilleur[] patrouilleurs = Context.Patrouilleur.ToArray();

            int matricule = 0;
            int noEquipe = 0; 
            int noVehicule = 0;


            if (Matricule != null && NoEquipe == null && NoVehicule == null)
            {
                matricule = int.Parse(Matricule);
                noEquipe = 0;
                noVehicule = 0;
            }
            else if (Matricule == null && NoEquipe != null && NoVehicule == null)
            {
                matricule = 0;
                noEquipe = int.Parse(NoEquipe);
                noVehicule = 0;
            }
            else if (Matricule == null && NoEquipe == null && NoVehicule != null)
            {
                matricule = 0;
                noEquipe = 0;
                noVehicule = int.Parse(NoVehicule);
            }
            else
            {
                matricule = 0;
                noEquipe = 0;
                noVehicule = 0;
            }



            //if (Matricule == "")
            //{
            //    noEquipe = 0;
            //}
            //else if (Matricule != "")
            //{
            //    matricule = int.Parse(Matricule);
            //}

            //else if (NoEquipe != "")
            //{
            //    noEquipe = int.Parse(NoEquipe);
            //}
            //else if (NoEquipe == "")
            //{
            //    noEquipe = 0;
            //}

            //else if (NoVehicule != "")
            //{
            //    noVehicule = int.Parse(NoVehicule);
            //}
            //else if (NoVehicule == "") 
            //{
            //    noVehicule = 0;
            //}


            return patrouilleurs.Where(x => x.Nom == Nom || x.Prenom == Prenom ||
                x.Matricule == matricule|| x.EquipeNoEquipe == noEquipe || x.VehiculeID == noVehicule).ToList<Patrouilleur>();






        }

        //protected override string Add(Employee entity)
        //{

        //    throw new NotImplementedException();
        //}

    }
}
