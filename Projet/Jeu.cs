using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public enum Categenre
    {
        Plateforme,
        Action_RPG,
        Action_Aventure,
        Football,
        Course_Auto,
        Compilation
    }
    public class Jeu :IEquatable<Jeu>,IComparable<Jeu>
    {
        private string nom;
        private string description;
        private string plateforme;
        private string edition;
        private Categenre genre;
        private float prix;
        private DateTime date;
        private bool reconditionnee;
        private Image photo;
        // Constructeur
        public Jeu(string n, string d, string p, string e, Categenre g, float px, DateTime dt, bool r, Image photo)
        {
            //initialisation des attributs
            this.nom = n;
            this.description = d;
            this.plateforme = p;
            this.edition = e;
            this.genre = g;
            this.prix = px;
            this.date = dt;
            this.reconditionnee = r;
            this.photo = photo;

        }
        //constructeur par defaut
        public Jeu()
        {
            this.nom = "";
            this.description = "";
            this.plateforme = "";
            this.edition = "";
            this.genre = new Categenre();
            this.prix = 0;
            this.date = new DateTime();
            this.reconditionnee = false;
            this.photo = null;

        }

        //Nom
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

        //description
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                this.description = value;
            }
        }
        //plateforme
        public string Plateforme
        {
            get
            {
                return plateforme;
            }
            set
            {
                this.plateforme = value;
            }
        }

        //edition

        public string Edition
        {
            get
            {
                return edition;
            }
            set
            {
                this.edition = value;
            }
        }

        //prix
        public float Prix
        {
            get
            {
                return prix;
            }
            set
            {
                if (value < 0)//si la valeur est inférieur à zero
                    this.prix = 0;//prix vaux 0
                else //sinon
                    this.prix = value;//prix vaut value
            }

        }

        //genre
        public Categenre Genre
        {
            get
            {
                return genre;
            }
            set
            {
                this.genre = value;

            }
        }
        public string Genres
        {
            get
            {
                return Enum.Format(typeof(Categenre), genre,"g");
            }
            set
            {
                genre = (Categenre)Enum.Parse(typeof(Categenre), value, false);
            }

        }
        //Reconditionnée
        public bool Reconditionnee
        {
            get
            {
                return reconditionnee;
            }
            set
            {
                if (value.Equals("oui") == true)//si la value vaut oui
                    this.reconditionnee = true;//le jeu est reconditionnée
                else //sinon
                    this.reconditionnee = false;// il n'est pas
            }
        }

        // photo
        public Image Photo
        {
            get
            {
                return photo;
            }
            set
            {
                this.photo = value;
            }
        }

        public DateTime Date
        {
            get { return date; }
            set { this.date = value; }
        }
        //saisie
        public virtual void Saisie()
        {
            int an, jour, mois;
            string d;
            string g;
            string p, r;
            Console.WriteLine("nom?");
            this.nom = Console.ReadLine();

            Console.WriteLine("description?");
            this.description = Console.ReadLine();

            Console.WriteLine("edition?");
            this.edition = Console.ReadLine();

            Console.WriteLine("plateforme?");
            this.plateforme = Console.ReadLine();

            Console.WriteLine("genre?");
            g = Console.ReadLine();
            this.genre = (Categenre)Enum.Parse(typeof(Categenre), g, false);

            Console.WriteLine("prix?");
            p = Console.ReadLine();
            this.prix = Single.Parse(p);

            Console.WriteLine("date (an,mois,jour)?");
            d = Console.ReadLine(); an = Int32.Parse(d);
            d = Console.ReadLine(); mois = Int32.Parse(d);
            d = Console.ReadLine(); jour = Int32.Parse(d);
            date = new DateTime(an, mois, jour);

            Console.WriteLine("se jeux est il reconditionnée oui ou non?");
            r = Console.ReadLine();
            if (r.Equals("oui") == true)
                this.reconditionnee = true;
            else
                this.reconditionnee = false;



        }

        //tostring()
        public override string ToString()
        {
            string s;
            s = "nom:" + nom + "\n description:" + description + "\n edition:" + edition + "\n plateforme:" + plateforme + "\n Prix:" + prix + "\n genre:" + genre + "\n Date:" + this.date + "\n reconditionnee:" + reconditionnee;
            return s;
        }
        public virtual void Affiche()
        {
            Console.WriteLine(ToString());

        }
        //IEquatable
        public bool Equals(Jeu o)
        {
            if (o == null)//si le jeu est null
                return false;//en retourne false
            return this.nom.Equals(o);//on compare le nom des jeux
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)//si le jeu est null
                return false; // on retourne null
            Jeu j = obj as Jeu;
            if (j == null)
                return false;
            else
                return this.Equals(j);
        }
        // comparer si deux jeux sont égaux
        public static bool operator ==(Jeu j1, Jeu j2)
        {
            if ((object)j1 == null)
                return ((object)j1 == null);
            return j1.Equals(j2);
        }
        //comparer si deux jeux son différent
        public static bool operator !=(Jeu j1, Jeu j2)
        {
            return !(j1 == j2);
        }
        //ICamprable
        //compare le nom de deux jeu
        public int CompareTo(Jeu o)
        {
            if (o == null)
                return 1;
            return this.nom.CompareTo(o.nom);
        }
        //compare deux jeux;
        //
        public static bool operator >(Jeu operand1, Jeu operand2)
        {

            if (operand1.CompareTo(operand2) == 1)//si le jeu1 est supperieur au jeu en retourne vrai
                return true;
            else return false;
        }

        public static bool operator <(Jeu operand1, Jeu operand2)
        {
            if (operand1.CompareTo(operand2) == -1)//si le jeu1 est inferieur au jeu en retourne vrai
                return true;

            else return false;
        }


    }

}
