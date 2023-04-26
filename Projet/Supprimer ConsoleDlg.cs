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
    public partial class Supprimer_ConsoleDlg : Form
    { private Leskonsoles lk;
        private List<string> nom;
        public Supprimer_ConsoleDlg(Leskonsoles l)
        {
            InitializeComponent();
            this.lk = l;
            lk.Trie();
            nom = new List<string>();
            initGrille();
        }
        public List<string> Nom
        {
            get
            {
                return this.nom;
            }
        }
        private void initGrille()
        {
            DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();

            DataGridViewImageColumn Image = new DataGridViewImageColumn();
            DataGridViewComboBoxColumn Entreprise = new DataGridViewComboBoxColumn();

            DataGridViewTextBoxColumn Date = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();

            DataGridViewCheckBoxColumn jRetro = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn Etat = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn Notice = new DataGridViewCheckBoxColumn();
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Maj.Columns.Add(Nom);







            Entreprise.HeaderText = "Entreprise";
            Entreprise.Name = "Entreprise";
            Entreprise.DataSource = Enum.GetNames(typeof(Entreprise));
            Maj.Columns.Add(Entreprise);

            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            Prix.ReadOnly = true;
            Maj.Columns.Add(Prix);


            Date.HeaderText = "Date de Sortie";
            Date.Name = "Date de Sortie";
            Date.ReadOnly = true;
            Maj.Columns.Add(Date);





            Image.HeaderText = "Image";
            Image.Name = "Image";
            Image.ReadOnly = true;
            Maj.Columns.Add(Image);

            jRetro.HeaderText = "Console  Retro";
            jRetro.Name = "Console Retro";
            jRetro.ReadOnly = true;
            Maj.Columns.Add(jRetro);


            Etat.HeaderText = "Etat";
            Etat.Name = "Etat";
            Etat.ReadOnly = true;
            Maj.Columns.Add(Etat);

            Notice.HeaderText = "Notice";
            Notice.Name = "Notice";
            Notice.ReadOnly = true;
            Maj.Columns.Add(Notice);


            Maj.Rows.Add(lk.GetNB() - 1);

            for (int i = 0; i < lk.GetNB(); i++)
            {

                Maj.Rows[i].Cells["Nom"].Value = lk.Getindice(i).Nom;

                Maj.Rows[i].Cells["Entreprise"].Value = lk.Getindice(i).EntrepriseS;

                Maj.Rows[i].Cells["Prix"].Value = lk.Getindice(i).Prix;
                Maj.Rows[i].Cells["Date de Sortie"].Value = lk.Getindice(i).Creation;

                Maj.Rows[i].Cells["Image"].Value = lk.Getindice(i).Logo;

                if (lk.Getindice(i) is KonsoleRetro)
                {


                    Maj.Rows[i].Cells["Console Retro"].Value = true;
                    Maj.Rows[i].Cells["Etat"].Value = ((KonsoleRetro)lk.Getindice(i)).Etat;
                    Maj.Rows[i].Cells["Notice"].Value = ((KonsoleRetro)lk.Getindice(i)).Notice;
                }


            }
        }
      

        private void Maj_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = Maj.CurrentCell.RowIndex;
            if (row >= 0)
            {
                Konsole k = lk.Getindice(row);
                nom.Add(k.Nom);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
