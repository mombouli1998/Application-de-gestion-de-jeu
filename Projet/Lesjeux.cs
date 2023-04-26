using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
   public class Lesjeux
    {
        private List<Jeu> lstjeu;//initialisation d'une liste de jeu.
      
        public Lesjeux()
        {
            lstjeu = new List<Jeu>();
          
        }

        public void InitLstjeux()
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
           
            Jeu Z = new Jeu("Mortal Kombat", "solo", "playstation4", "2009", action, 1000, f, true, mk);
            JeuRetro r = new JeuRetro("ancien", true, "DBZ", "solo", "playstation4", action, "2009", 1000, true, f, dbz);
            r.AjoutPhot(gt5);
            
            lstjeu.Add(Z);
            lstjeu.Add(d);
            lstjeu.Add(c);
            lstjeu.Add(r);
        }


        //ajout d'un jeu
        public void Ajoutjeu(Jeu j)
        {
            lstjeu.Add(j);// on ajoute le jeu situé en paramètre dans la liste de jeu
        }

        //suprime jeu
        public void Supprimejeu(Jeu j)
        {
            for (int i = 0; i < lstjeu.Count(); i++)
                if(j.Nom.Equals(lstjeu[i].Nom)==true)
                {
                    lstjeu.Remove(j);
                }
        }
        //Trie
        public void Trie()
        {
            Jeu j = new Jeu();// initialisation d un jeu
            int k, i;
            for (i = 0; i < lstjeu.Count(); i++)//on parcout la liste de jeu
            {
                j = lstjeu[i];//on affecte au jeu initialisé le jeu d'indice i dans 
                k = i - 1;// on affecte une valeur inférieur à i
                while (k >= 0 && lstjeu[k].Nom.CompareTo(j.Nom) == 1)//condition: tant que k est inferieur à 0 et que le jeu
                                                                     // d'indice k est supeérieur au jeu j
                {
                    lstjeu[k + 1] = lstjeu[k];//on échange le jeux d'indice K+1 et le jeu d'indice K;
                    k = k - 1;//on décrémente la valeur de K
                }
                lstjeu[k + 1] = j;//on echange le jeu d'indice (k+1) au nouveu jeu.
            }
        }

        //affichage du jeux à l'indice i
        public Jeu GetJeu(Jeu j)
        {
            Jeu r = new Jeu();
            for (int i = 0; i < lstjeu.Count(); i++)//on parcourt la liste de jeu
            {
                if (j.Nom.Equals(lstjeu[i].Nom))//si le nom d'un jeu de la liste correspond au nom du jeu mis en paramètre
               
                r = lstjeu[i];
            }
              
            return r;

        }
        public JeuRetro GetJeuRetr(Jeu j)
        {
            JeuRetro r = new JeuRetro();
            if(j is JeuRetro)
            {
                for (int i = 0; i < lstjeu.Count(); i++)//on parcourt la liste de jeu
                {
                    if (j.Nom.Equals(lstjeu[i].Nom))//si le nom d'un jeu de la liste correspond au nom du jeu mis en paramètre

                        r = (JeuRetro)lstjeu[i];
                }
            }
            

            return r;

        }
      
        public JeuRetro GetJeuR(int j)
        {
            JeuRetro p = new JeuRetro();

            if (lstjeu[j] is JeuRetro)
            {
                p = (JeuRetro)lstjeu[j];
            }
            return p;
        }
        public Jeu Getindice(int j)
        {
            Jeu p = new Jeu();

            if (j < lstjeu.Count)
            {
                p = lstjeu[j];
            }
            return p;


        }
        //le nombre d'élément de la liste
        public int GetNB()
        {
            //  Console.WriteLine();//affiche le nombre d'élément de la liste
            return lstjeu.Count();
        }

        //affichage du jeux à partir d'un nom
        public Jeu GetJeuNom(string n)
        {
            Jeu h = new Jeu();
            for (int i = 0; i < lstjeu.Count(); i++) //on parcour la liste de jeu   
            {
                if (n.Equals(lstjeu[i].Nom) == true)//si le nom d'un jeu de la liste correspond au nom mis en parametre

                    h = lstjeu[i];
            }
            //on affiche le jeu correspond
            return h;

        }

        //reherche d'un jeux et affichage à partir de son genre
        public List<Jeu> GetJeucat(Categenre c)
        {           // Jeu h = new Jeu();
            List<Jeu> genre = new List<Jeu>();
            for (int i = 0; i < lstjeu.Count(); i++)//on parcour la liste de jeux

            {
                if (c.Equals(lstjeu[i].Genre) == true)// si un genre d'un jeu de la liste correspond au genre mise en paramètre
                    genre.Add(lstjeu[i]);
                // h = lstjeu[i];
            }

            // return h;
            return genre;
        }
        //recuperation et affectation des jeux reto dans une nouvelle liste
        //affichage des jeux reto
        public List<JeuRetro> GetJeuRetro()
        {

            List<JeuRetro> lstretro = new List<JeuRetro>();
            for (int i = 0; i < lstjeu.Count(); i++)// on parcourt tout les éléments de la liste
            {
                if (lstjeu[i] is JeuRetro)//si il existe un jeu reto dans la liste
                    lstretro.Add((JeuRetro)lstjeu[i]);// on l'affecte dans la nouvelle liste

            }


            return lstretro;
        }

        public string Retro()
        {
            string d = "";
            for (int i = 0; i < lstjeu.Count(); i++)// on parcourt tout les éléments de la liste
            {
                if (lstjeu[i] is JeuRetro)//si il existe un jeu reto dans la liste

                    d += this.lstjeu[i] + "\n";
            }
            return d;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < lstjeu.Count(); i++)
            {
                s += "\n indice" + i + "\njeu\n" + lstjeu[i] + "\n";
            }

            return s;
        }
        //affichage de la liste de jeux
        public virtual void Affiche()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
