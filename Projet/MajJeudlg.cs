using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class MajJeudlg : Form
    {
        private Lesjeux lj;
        private Image lp;
        public MajJeudlg(Lesjeux Lj)
        {
            InitializeComponent();
            this.lj = Lj;
            initGrille();
        }
        private void initGrille()
        {
            DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Plateforme = new DataGridViewTextBoxColumn();
            DataGridViewImageColumn Image = new DataGridViewImageColumn();
            DataGridViewComboBoxColumn Genre = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn Editeur = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DatS = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn Reconditionne = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn jRetro = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn Etat = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn Notice = new DataGridViewCheckBoxColumn();
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
           // Maj.Columns.Add(Nom);


            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
          //  Maj.Columns.Add(Description);


            Plateforme.HeaderText = "Plateforme";
            Plateforme.Name = "Plateforme";
            Plateforme.ReadOnly = true;
          //  Maj.Columns.Add(Plateforme);

            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            Genre.DataSource = Enum.GetNames(typeof(Categenre));
           // Maj.Columns.Add(Genre);


            Editeur.HeaderText = "Editeur";
            Editeur.Name = "Editeur";
            Editeur.ReadOnly = true;
          //  Maj.Columns.Add(Editeur);

            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            Prix.ReadOnly = false;
          //  Maj.Columns.Add(Prix);


            DatS.HeaderText = "Date de Sortie";
            DatS.Name = "DatS";
            DatS.ReadOnly = true;
          //  Maj.Columns.Add(Date);


            Reconditionne.HeaderText = "Reconditionné";
            Reconditionne.Name = "Reconditionne";
            Reconditionne.ReadOnly = true;
           // Maj.Columns.Add(Reconditionne);


            Image.HeaderText = "Image";
            Image.Name = "Image";
            Image.ReadOnly = true;
           // Maj.Columns.Add(Image);

            jRetro.HeaderText = "Jeu Retro";
            jRetro.Name ="jRetro";
            jRetro.ReadOnly = false;
           // Maj.Columns.Add(jRetro);


            Etat.HeaderText = "Etat";
            Etat.Name = "Etat";
            Etat.ReadOnly = true;
           // Maj.Columns.Add(Etat);

            Notice.HeaderText = "Notice";
            Notice.Name = "Notice";
            Notice.ReadOnly = false;
            //Maj.Columns.Add(Notice);
            Maj.Columns.AddRange(new DataGridViewColumn[] { Nom, Description, Plateforme, Genre, Editeur, Prix, DatS, Reconditionne, Image, jRetro, Etat, Notice });

            Maj.AllowUserToAddRows = false;
            Maj.AllowUserToOrderColumns = false;
            Maj.Rows.Add(lj.GetNB());

            for (int i = 0; i < lj.GetNB(); i++)
            {

                Maj.Rows[i].Cells["Nom"].Value = lj.Getindice(i).Nom;
                Maj.Rows[i].Cells["Description"].Value = lj.Getindice(i).Description;
                Maj.Rows[i].Cells["Plateforme"].Value = lj.Getindice(i).Plateforme;
                Maj.Rows[i].Cells["Genre"].Value = lj.Getindice(i).Genres;
                Maj.Rows[i].Cells["Editeur"].Value = lj.Getindice(i).Edition;
                Maj.Rows[i].Cells["Prix"].Value = lj.Getindice(i).Prix;
                Maj.Rows[i].Cells["DatS"].Value = lj.Getindice(i).Date;
                Maj.Rows[i].Cells["Reconditionne"].Value = lj.Getindice(i).Reconditionnee;
                Maj.Rows[i].Cells["Image"].Value = lj.Getindice(i).Photo;

                if (lj.Getindice(i) is JeuRetro)
                {


                    Maj.Rows[i].Cells["jRetro"].Value = true;
                    Maj.Rows[i].Cells["Etat"].Value = lj.GetJeuR(i).Etat;
                    Maj.Rows[i].Cells["Notice"].Value = lj.GetJeuR(i).Notice;
                }


            }

        }


        private void Grille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Maj_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int lig = e.RowIndex;
            int col = e.ColumnIndex;
            DataGridViewCell cell = Maj.Rows[lig].Cells[col];
            Jeu j = this.lj.Getindice(lig);
            switch (col)
            {

                case 3: j.Genres = cell.Value.ToString(); break;
                case 5: j.Prix = Single.Parse(cell.Value.ToString()); break;
                case 11:
                    if (j is JeuRetro)
                        ((JeuRetro)j).Notice = (bool)cell.Value;
                    else
                        cell.Value = false;
                    break;
            }
        }
    }
}
