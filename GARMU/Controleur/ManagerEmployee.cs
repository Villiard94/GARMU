using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GARMU.Modele;

namespace GARMU.Controleur
{
    class ManagerEmployee : Manager<Employee>
    {
   

        public ManagerEmployee(garmuBDEntities context)
            : base(context)
        {

        }


        public string Add(string Nom, string Prenom, string Matricule, string NoEquipe, string NoVehicule)
        {
            Employee emp = new Employee();

            emp.Nom = Nom;
            emp.Prenom = Prenom;

            if (Prenom == null || NoEquipe == null || NoVehicule == null)
            {

                return Add(emp);
            }
            //BUG ICI STACK OVERFLOW
            
            //emp.Matricule = Matricule;
            //emp.NoEquipe = NoEquipe;
            //emp.NoVehicule = NoVehicule;
            return Add(emp);

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

 


        public override List<Employee> GetList()
        {
            return Context.Employee.ToList<Employee>();
        }

        //protected override string Add(Employee entity)
        //{

        //    if (Exists(entity.Fullname))
        //    {
        //        return "L'employé existe déja. Impossbile de l'ajouté.";
        //    }
        //    Context.Employees.Add(entity);
        //    return "Réussite. L'employé a été ajouté";
        //}

        //private bool Exists(string FullName)
        //{
            

        //    if (Context.Employees.Where(x => x.Fullname == FullName) == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        internal List<Employee> SearchFor(string Nom, string Prenom, string Matricule, string NoEquipe, string NoVehicule)
        {
            Employee[] employees = Context.Employee.ToArray();

            return employees.Where(x => x.Nom == Nom || x.Prenom == Prenom ||
                x.Matricule == Matricule || x.NoEquipe == NoEquipe || x.NoVehicule == NoVehicule).ToList<Employee>();

            //PROBLEME ICI MATIRCUL NO EQUIPE NO VEHICULE

            //return Context.Employees.Where(x => x.Nom == Nom  || x.Prenom == Prenom || 
            //    x.Matricule == Matricule || x.NoEquipe == NoEquipe || x.NoVehicule == NoVehicule).ToList<Employee>();





        }

        protected override string Add(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
