using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
      public enum Entreprise
    {
        Atari,
        Bandai,
        Coleco,
        Commodore,
        Magnavox,
        Microsoft,
        Nec,
        Nintendo,
        Sony,
        Sega
        
    }
      public class Konsole : IEquatable<Konsole>, IComparable<Konsole>
    {
        //initialisation des attributs
        private string nom;
        private float prix;
        private DateTime creation;
        private Entreprise entreprise;
        Image logo;

        //constructeur par defaut
        public Konsole()
        {
            this.nom = "";
            this.prix = 0;
            this.creation = new DateTime();
	 this.entreprise = new Entreprise();
           
        }
        public Konsole(string n,float p, DateTime d, Entreprise e,Image photo)
        {
            this.entreprise = e;
            this.prix = p;
            this.nom = n;
            this.creation = d;
            this.logo=photo;
        }
        //NOM
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                this.nom = value;

            }

        }

        public DateTime Creation
        {
            get
            {
                return creation;
            }
            set
            {
                this.creation = value;

            }

        }
        //PRIX
        public float Prix
        {
            get
            {
                return prix;
            }
            set
            {
                if (value < 0)
                    this.prix = 0;
                else
                    this.prix = value;
            }
        }
        public Image Logo
        {
            get
            {
                return logo;
            }
            set
            {
                this.logo = value;
            }
        }
        //Nom de l'entreprise de création
        public Entreprise Entreprise
        {
            get
            {
                return this.entreprise;
            }
            set
            {
                this.entreprise= value;

            }

        }
	
	  public string EntrepriseS
        {
            get
            {
                return Enum.Format(typeof(Entreprise), entreprise,"g");
            }
            set
            {
                entreprise = (Entreprise)Enum.Parse(typeof(Entreprise), value, false);
            }

        }
        //saisie
        public virtual void Saisie()
        {
            int an, jour, mois;
            string d;
            string g;
            string p;
            Console.WriteLine("nom?");
            this.nom = Console.ReadLine();

           
           

            Console.WriteLine("Entreprise?");
            g = Console.ReadLine();
            this.entreprise = (Entreprise)Enum.Parse(typeof(Entreprise), g, false);


            Console.WriteLine("prix?");
            p = Console.ReadLine();
            this.prix = Single.Parse(p);

            Console.WriteLine("date (an,mois,jour)?");
            d = Console.ReadLine(); an = Int32.Parse(d);
            d = Console.ReadLine(); mois = Int32.Parse(d);
            d = Console.ReadLine(); jour = Int32.Parse(d);
            creation = new DateTime(an, mois, jour);

        }

        //To Strinf
        public override string ToString()
        {
            string s;
            s = "nom:" + nom + "\n Entreprise:" + entreprise + "\n prix:" + prix + "\n Date de création" + creation;
            return s;
        }
        public virtual void Affiche()
        {
            Console.WriteLine(ToString());

        }
        //Iequatable
        public bool Equals(Konsole o)
        {
            if (o == null)
                return false;
            return this.nom.Equals(o);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Konsole j = obj as Konsole;
            if (j == null)
                return false;
            else
                return this.Equals(j);
        }
        public static bool operator ==(Konsole j1, Konsole j2)
        {
            if ((object)j1 == null)
                return ((object)j1 == null);
            return j1.Equals(j2);
        }
        public static bool operator !=(Konsole j1, Konsole j2)
        {
            return !(j1 == j2);
        }
       
        //IComparable
        public int CompareTo(Konsole o)
        {
            if (o == null)
                return 1;
            return this.nom.CompareTo(o);
        }
        public static bool operator >(Konsole operand1, Konsole operand2)
        {
            if (operand1.CompareTo(operand2) == 1)
                return true;
            else return false;
        }

        public static bool operator <(Konsole operand1, Konsole operand2)
        {
            if (operand1.CompareTo(operand2) == -1)
                return true;
            else return false;
        }






    }
}
