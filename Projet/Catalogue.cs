using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Catalogue
    {
        Lesjeux lstjeu;
        DateTime MSA;
        Leskonsoles lstk;
        public Lesjeux Ljeux
        {
            get { return lstjeu; }
            // set { lstjeu = new Lesjeux(); }

        }
        public Leskonsoles Lstk
        {
            get { return lstk; }
            // set { lstjeu = new Lesjeux(); }

        }

        public Catalogue()
        {
            lstjeu = new Lesjeux();
            lstk = new Leskonsoles();

        }

        public void Init()
        {
            Categenre course = (Categenre)Enum.Parse(typeof(Categenre), "Course_Auto", false);
            Categenre action = (Categenre)Enum.Parse(typeof(Categenre), "Action_RPG", false);
            Categenre aventure = (Categenre)Enum.Parse(typeof(Categenre), " Action_Aventure", false);
            DateTime f = new DateTime(1998, 12, 12);
            DateTime q = new DateTime(2010, 12, 12);
            DateTime p = new DateTime(2005, 12, 12);
            DateTime l = new DateTime(2000, 12, 12);
            Image gt5 = (Image)(Properties.Resources.gt5);
            Image mfh = (Image)(Properties.Resources.mfh);
            Image dbz = (Image)(Properties.Resources.dbz);
            Image mk = (Image)(Properties.Resources.mk);
            Jeu c = new Jeu("Grand Trusmo 5", "ffff", "playstation4", "2009", course, 1000, l, true, gt5);
            Jeu d = new Jeu("medail of honor", "solo", "playstation4", "2009", aventure, 1000, p, true, mfh);
            Jeu b = new Jeu("DBZ", "solo", "playstation4", "2009", action, 1000, q, true, dbz);
            Jeu Z = new Jeu("Mortal Kombat", "solo", "playstation4", "2009", action, 1000, f, true, mk);
            JeuRetro r = new JeuRetro("ancien", true, "DBZ", "solo", "playstation4", action, "2009", 1000, true, f, dbz);

            lstjeu.Ajoutjeu(b);
            lstjeu.Ajoutjeu(Z);
            lstjeu.Ajoutjeu(d);
            lstjeu.Ajoutjeu(c);
            lstjeu.Ajoutjeu(r);

        }


        public void Ajoutjeu(Jeu j)
        {
            lstjeu.Ajoutjeu(j);
        }
        public void Ajoutkonsole(Konsole j)
        {
            lstk.AjoutKonsole(j);
        }

        //suprime jeu
        public void Supprimejeu(Jeu j)
        {
            lstjeu.Supprimejeu(j);
        }
        public void GetJeu(Jeu j)
        {
            lstjeu.GetJeu(j);

        }
        public int GetNB()
        {
            return lstjeu.GetNB();
        }

        //affichage du jeux à partir d'un nom
        public void GetJeuNom(string n)
        {
            lstjeu.GetJeuNom(n);

        }

        //reherche d'un jeux et affichage à partir de son genre
        public void GetJeucat(Categenre c)
        {
            lstjeu.GetJeucat(c);

        }

    }
}
