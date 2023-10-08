using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D3_DM1
{
    public class Acteur
    {
        private DateTime anneeNaissance;
        private int id;
        private string nom;
        private string prenom;
        


        public DateTime AnneeNaissance
        {
            get { return anneeNaissance; }
            set { anneeNaissance = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        { 
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        

        public Acteur()
        {

        }

        public Acteur(DateTime anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;

        }

        

        public void getIstance(DateTime anneeNaissance, int id, string nom, string prenom)
        {
            Acteur unActeur = new Acteur(anneeNaissance, id, nom, prenom);
        }

        public override string ToString()
        {
            string afficher = "\n\nAnnée de naissance de l'acteur : " + this.anneeNaissance + "\nId de l'acteur : " + this.id + "\nNom de l'acteur : " + this.nom + "\nPrénom de l'acteur : " + this.prenom;
            return afficher;
        }






    }
}
