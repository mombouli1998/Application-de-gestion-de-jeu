using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public class KonsoleRetro:Konsole
    {
        bool notice;
        string etat;
        List<Image> lstphotos;

        public KonsoleRetro(string etat, bool notice, string n, float p,DateTime d,Entreprise e, Image photo) : base (n, p,  d,  e,photo)
        {
            this.etat = etat;
            this.notice = notice;
            this.lstphotos = new List<Image>();
        }

        public KonsoleRetro()
        {
        }
        public List<Image> Lstphotos
        {
            get { return lstphotos; }
            set { this.lstphotos = value; }
        }
        private void ajoutPhoto(Image photo)
        {
            lstphotos.Add(photo);
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
                    this.Notice = true;
                else
                    this.Notice = false;
            }
        }

        public void AjoutPhot(Image I)
        {
            lstphotos.Add(I);
        }
        //tostring()
        public override string ToString()
        {
            string s = "\nKonsole Retro:\n";
            s += base.ToString();
            s += "\n etat:" + this.etat;
            if (notice)
                s += "\n notice existante";
            else
                s += "\n pas de notice";
            return s;
        }
        public override void Saisie()
        {
            base.Saisie();
        }
    }
}
