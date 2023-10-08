using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_DM1
{
    public class Cinema
    {
        private Cinema cine;
        private List<Acteur> lesActeurs;
        private List<Film> lesFilms;

        public Cinema Cine
        {
            get { return cine; }
            set { cine = value; }
        }

        public List<Acteur> LesActeurs
        {
            get { return lesActeurs; }
            set { lesActeurs = value; }
        }

        public List<Film> LesFilms
        {
            get { return lesFilms; }
            set { lesFilms = value; }
        }

        public Cinema()
        {
            this.lesActeurs = new List<Acteur>();
            this.lesFilms = new List<Film>();
        }

        public Cinema(Cinema cine)
        {
            this.cine = cine;
            this.lesActeurs = new List<Acteur>();
            this.lesFilms = new List<Film>();
            

        }
            
        

        public void getInstance()
        {
            Cinema unCinema = new Cinema();

        }

        public Acteur getActeur(int id)
        {
            Acteur acteurCherche = new Acteur();

            foreach(Acteur unActeurCourant in this.LesActeurs)
            {
                if(unActeurCourant.Id == id)
                {
                    acteurCherche = unActeurCourant;
                    break;
                }

            }

            return acteurCherche;

        }

        public Film getFilm(string id)
        {
            Film filmCherche = new Film();

            foreach(Film unFilmCourant in this.LesFilms)
            {
                if(filmCherche.IdFilm == id)
                {
                    filmCherche = unFilmCourant;
                    break;
                }

            }

            return filmCherche;

        }

        public List<Acteur> nbActeurs()
        {
            List<Acteur> nbActeur = new List<Acteur>();

            foreach(Acteur unActeur in this.LesActeurs)
            {
                nbActeur.Add(unActeur);
                Console.WriteLine("Nombre d'acteurs: {0}", LesActeurs.Count);

            }

            return nbActeur;


        }

        public void setFilm(int annee, string genre, string idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.lesFilms.Add(new Film(annee, genre, idFilm, resume, titre, acteurPrincipal));
        }

        public void setActeur(DateTime anneeNaissance, int id, string nom, string prenom)
        {
            this.lesActeurs.Add(new Acteur(anneeNaissance, id, nom, prenom));
        }



        public override string ToString()
        {
            string afficher = "\nNom du cinéma : " + this.cine + "\n";

            string listeDesActeursaAfficher = "";
            foreach(Acteur unacteur in this.LesActeurs)
            {

                listeDesActeursaAfficher += unacteur.ToString();

            }

            string listeDesFilmsaAfficher = "";
            foreach(Film unfilm in this.LesFilms)
            {

                listeDesFilmsaAfficher += unfilm.ToString();

            }

            afficher += listeDesFilmsaAfficher;

            return afficher;
        }


    }
}
