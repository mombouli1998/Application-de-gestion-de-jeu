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
    public partial class SaisieJeuDlg : Form
    {
        private Jeu lj;
        private Image photo;
        private Image pho;
      
        public SaisieJeuDlg()
        {
            InitializeComponent();
            lj = new Jeu();
            initListeGenre();
        }
        public Jeu Lj()
        { return lj; }
      
        private void initListeGenre()
        {
            string[] val = Enum.GetNames(typeof(Categenre));
            foreach (string st in val)
            {
                ListeGenre.Items.Add(st);
                Lgenre.Items.Add(st);
            }
                
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool t;
            string n = Nom.Text;
            string d = Description.Text;
            string pl = Plateforme.Text;
            string ed = Editeur.Text;
            string U = ListeGenre.SelectedItem.ToString();
            Categenre f = (Categenre)Enum.Parse(typeof(Categenre), U, false);
            float p = Single.Parse(Prix.Text);
            DateTime da = date.Value;
            if (Recon.Checked)
                t = true;
            else
                t = false;
            lj = new Jeu(n, d, pl, ed, f,p, da, t,photo);
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            DialogResult res = diag.ShowDialog();
            if(res==DialogResult.OK)
            {
                string s = diag.FileName;
                NomFich.Text = s;
                photo = Image.FromFile(s);
                PBPhoto.Image = photo.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero);
            }
            diag.Dispose();
        }

        private void BAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {

            bool t,y;
            string n = Nm.Text;
            string d = Des.Text;
            string pl = Pl.Text;
            string ed = Ed.Text;

            string et = Et.Text;
            string U = Lgenre.SelectedItem.ToString();
            Categenre f = (Categenre)Enum.Parse(typeof(Categenre), U, false);

            float p = Single.Parse(Pr.Text);
            DateTime da = dateT.Value;
            if (Reconditionne.Checked)
                t = true;
            else
                t = false;
            if (oui.Checked)
                y = true;
            else
                y = false;
            lj = new JeuRetro(et,y,n, d, pl, f,ed, p, t, da, pho);
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void par_Click(object sender, EventArgs e)
        {

            OpenFileDialog diag = new OpenFileDialog();
            DialogResult res = diag.ShowDialog();
            if (res == DialogResult.OK)
            {
                string s = diag.FileName;
                Nfich.Text = s;
                pho = Image.FromFile(s);
                Img.Image = pho.GetThumbnailImage(Img.Width, Img.Height, null, IntPtr.Zero);
            }
            diag.Dispose();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
