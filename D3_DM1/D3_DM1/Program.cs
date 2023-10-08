using D3_DM1;
using Acteur = D3_DM1.Acteur;


internal class Program
{
    private static void Main(string[] args)
    {
        //A - La classe Film 
        //7.
        Console.WriteLine("A - La classe Film");
        Console.WriteLine("7.");

        /*Film monFilm = new Film(1982, "Science-Fiction", "001", "L'action du film se situe à Los Angeles en 2019 et met en\nscène Rick Deckard (interprété par Harrison Ford), un ancien policier\nqui reprend du service pour traquer un groupe de réplicants, des\nandroïdes créés à l'image de l'Homme, menés par l'énigmatique Roy\nBatty (interprété par Rutger Hauer).", "Blade Runner");*/

        Film monFilm = new Film();

        //monFilm.getInstance();
        
        monFilm.getInstance(1982,"Science-Fiction","001","L'action du film se situe à Los Angeles en 2019 et met en\nscène Rick Deckard (interprété par Harrison Ford), un ancien policier\nqui reprend du service pour traquer un groupe de réplicants, des\nandroïdes créés à l'image de l'Homme, menés par l'énigmatique Roy\nBatty (interprété par Rutger Hauer).","Blade Runner", new Acteur (new DateTime(1942, 06, 13), 01, "Ford", "Harisson"));

        Console.WriteLine(monFilm.ToString());


        //B - La classe Acteur 
        //7.
        Console.WriteLine("\nB - La classe Film");
        Console.WriteLine("7.");

        Acteur monActeur = new Acteur();

        monActeur.getIstance(new DateTime(1942, 06, 13), 01, "Ford", "Harisson");
        monActeur.getIstance(new DateTime(1956, 07, 09), 02, "Hanks", "Tom");

        Console.WriteLine(monActeur.ToString());

        Console.WriteLine("\n***********************************");
        Console.WriteLine("\n***********************************");

        Cinema monCinema = new Cinema();

        monCinema.setActeur(new DateTime(1942, 06, 13), 001, "Ford", "Harisson");
        monCinema.setActeur(new DateTime(1956, 07, 09), 002, "Hanks", "Tom");

        monCinema.setFilm(1982, "Science-Fiction", "L'action du film se situe à Los Angeles en 2019 et met en\nscène Rick Deckard (interprété par Harrison Ford), un ancien policier\nqui reprend du service pour traquer un groupe de réplicants, des\nandroïdes créés à l'image de l'Homme, menés par l'énigmatique Roy\nBatty (interprété par Rutger Hauer).", "001", "Blade Runner", new Acteur(new DateTime(1942, 06, 13), 001, "Ford", "Harisson"));
        monCinema.setFilm(1992, "Animation", "Le film met en scène un groupe de jouets. Woody,\nune poupée représentant un cow_boy, et Buzz\nl'Eclaire, une figurine d'astronaute, en sont les\npersonnages principaux.", "002", "Toy Story", new Acteur(new DateTime(1956, 09, 07), 002, "Hanks", "Tom"));

        Console.WriteLine(monCinema.ToString());



        Console.WriteLine("\n\nVoici les caractéristiques des filmes : ");

        foreach (Film unfilm in monCinema.LesFilms)
        { 
            Console.WriteLine("\nTitre : " + unfilm.Titre + "\nAnnée : " + unfilm.Annee + "\nGenre : " + unfilm.Genre + "\nRésumé : " + unfilm.Resume);
            Console.WriteLine("Acteur principal : " + unfilm.ActeurPrincipal.Prenom + " " + unfilm.ActeurPrincipal.Nom);
        }












    }
}