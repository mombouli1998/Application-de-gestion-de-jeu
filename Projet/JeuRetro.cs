using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
   public class JeuRetro:Jeu
    {
        private bool notice;
        private string etat;
        private ImageList lstphotos;

        //constructeur
        public JeuRetro(string etat, bool notice, string n, string d, string p, Categenre g, string e, float px, bool r, DateTime dt, Image photo) : base(n, d, p, e, g, px, dt, r, photo)
        {
            this.etat = etat;
            this.notice = notice;
            this.lstphotos =new ImageList();
            lstphotos.Images.Add(photo);
        }
        public JeuRetro()
        {
            etat = "";
            notice = false;
            this.lstphotos = new ImageList();

        }
        //etat
        public  ImageList Lstphotos
        {
            get { return lstphotos; }
            set { this.lstphotos = value; }
        }
        private void ajoutPhoto(Image photo)
        {
            lstphotos.Images.Add(photo);
        }
        public string Etat
        {
            get
            {
                return etat;
            }
            set
            {
                this.etat = value;
            }
        }

        //notice
        public bool Notice
        {
            get
            {
                return this.notice;
            }
            set
            {
                if (value == true)
                    this.notice = true;
                else
                    this.notice = false;
            }
        }
        //ajout d'une photo
        public void AjoutPhot(Image I)
        {
            lstphotos.Images.Add(I);
        }

        public override string ToString()
        {
            string s = "jeuRetro:\n";
            s += base.ToString();
            s += "\n etat:" + this.etat;
            if (notice==true)
                s += "\n notice existante";
            else
                s += "\n pas de notice";
            return s;
        }

        //méthode de saisie
        public override void Saisie()
        {
            string r;
            Console.WriteLine("etat?");
            this.etat = Console.ReadLine();
            Console.WriteLine("se jeux à t'il une notice?");
            r = Console.ReadLine();
            if (r.Equals("oui") == true)
                this.notice = true;
            else
                this.notice = false;
            base.Saisie();
        }
        public virtual void Affiche()
        {
            Console.WriteLine(ToString());

        }
    }
}
