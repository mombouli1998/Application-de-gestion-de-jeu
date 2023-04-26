using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
   public class Leskonsoles
    {
       private  List<Konsole> lstk;
        
        
        public Leskonsoles()
        {
            lstk = new List<Konsole>();
          
        }

        public void InitLstK()
        {
           
            
            DateTime f = new DateTime(1998, 12, 12);
            DateTime q = new DateTime(2010, 12, 12);
            DateTime p = new DateTime(2005, 12, 12);
            DateTime l = new DateTime(2000, 12, 12);

		 Entreprise Sony = (Entreprise)Enum.Parse(typeof(Entreprise), "Sony", false);
		 Entreprise Sega = (Entreprise)Enum.Parse(typeof(Entreprise), "Sega", false);
		 Entreprise Microsoft = (Entreprise)Enum.Parse(typeof(Entreprise), "Microsoft", false);
		 Entreprise Nintendo = (Entreprise)Enum.Parse(typeof(Entreprise), "Nintendo", false);

            Image ps4 = (Image)(Properties.Resources.ps4);
            Image ps3 = (Image)(Properties.Resources.ps3);
            Image nintendo = (Image)(Properties.Resources.Nintendo);
            Image xbox = (Image)(Properties.Resources.xbox);
            Image sega = (Image)(Properties.Resources.sega);

            Konsole c = new Konsole("PS4", 400, l,Sony , ps4 );
            Konsole d = new Konsole("PS3", 250, q, Sony, ps3);
            Konsole b = new Konsole("Nintendo", 100,p, Nintendo, nintendo);
            Konsole Z = new Konsole("Xbox", 250, f,Microsoft, xbox);
            KonsoleRetro r = new KonsoleRetro("ancien", true, "Sega", 100, f, Sega, sega);

            lstk.Add(b);
            lstk.Add(Z);
            lstk.Add(d);
            lstk.Add(c);
            lstk.Add(r);

        }


        //ajout d'un jeu
        public void AjoutKonsole(Konsole j)
        {
            lstk.Add(j);
        }

        //suprime jeu
        public void SupprimeKonsole(Konsole j)
        {
            int ind = lstk.IndexOf(j);
            if (ind != -1)
                lstk.Remove(j);
        }
        public void Trie()
        {
            Konsole j = new Konsole();
            int k, i;
            for (i = 0; i < lstk.Count(); i++)
            {
                j = lstk[i];
                k = i - 1;
                while (k >= 0 && lstk[k].Nom.CompareTo(j.Nom) == 1)
                {
                    lstk[k + 1] = lstk[k];
                    k = k - 1;
                }
                lstk[k + 1] = j;
            }
        }

        //affichage du jeux à l'indice i
        public Konsole Getkonso(Konsole j)
        {
            Konsole r = new Konsole();
            for (int i = 0; i < lstk.Count(); i++)//on parcourt la liste de jeu
            {
                if (j.Nom.Equals(lstk[i].Nom))//si le nom d'un jeu de la liste correspond au nom du jeu mis en paramètre

                    r = lstk[i];
            }

            return r;
        }
        public int GetNB()
        {
          
            return lstk.Count(); ;
        }

        //affichage de la console à partir d'un nom
        public Konsole GetkonsoleNom(string n)
        {
            
                Konsole h = new Konsole();
                for (int i = 0; i < lstk.Count(); i++) //on parcour la liste de jeu   
                {
                    if (n.Equals(lstk[i].Nom) == true)//si le nom d'un jeu de la liste correspond au nom mis en parametre

                        h = lstk[i];
                }
                //on affiche le jeu correspond
                return h;

            
        }
        public Konsole Getindice(int j)
        {
            Konsole p = new Konsole();

            if (j < lstk.Count)
            {
                p = lstk[j];
            }
            return p;


        }

        //reherche d'une konsole et affichage à partir de son entreprise
      

      
  
        public string Retro()
        {
            string d = "";
            for (int i = 0; i < lstk.Count(); i++)// on parcourt tout les éléments de la liste
            {
                if (lstk[i] is KonsoleRetro)//si il existe un jeu reto dans la liste

                    d += this.lstk[i] + "\n";
            }
            return d;
        }

      
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < lstk.Count(); i++)
            {
                s += "indice" + i + "\n Konsole\n" + lstk[i] + "\n \n";
            }

            return s;

        }
        public virtual void Affiche()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
