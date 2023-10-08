using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace D3_DM1
{
    public class Film
    {
        private int annee;
        private string genre;
        private string idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }


        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string IdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public Acteur ActeurPrincipal
        {
            get { return acteurPrincipal; }
            set { acteurPrincipal = value; }

        }

        public Film()
        {

        }


        public Film(int annee, string genre, string idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal;

        }

        public override string ToString()
        {
            string afficher = "\nAnnée de sortie du film : " + this.annee + "\nGenre du Film : " + this.genre + "\nId du Film : " + this.idFilm + "\nResume du Film : " + this.resume + "\nTitre du film : " + this.titre + "Acteur principal : " + this.ActeurPrincipal;
            return afficher;
        }

        public void getInstance(int annee, string genre, string idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            Film unFilm = new Film(annee, genre, idFilm, resume, titre, acteurPrincipal);
        }

        public string getActeurPrincipal()
        {
            Acteur unacteur = new Acteur();

            string ActeurP = unacteur.Nom;

            return ActeurP;
        }


    }
}

/*public Film getInstance(int annee, string genre, int idFilmI, string resumeI, string titreI)
        {
            Film filmI = new Film();

        
            anneeI = this.annee;
            genreI = this.genre;
            idFilmI = this.idFilm;
            resumeI = this.resume;
            titreI = this.titre;



            return filmI;

        }*/
