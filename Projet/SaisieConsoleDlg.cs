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
    public partial class SaisieConsoleDlg : Form
    {   private Konsole lk;
        private Image pho;
        public SaisieConsoleDlg()
        {
            InitializeComponent();
            lk = new Konsole();
            initEntreprise();
        }
        public Konsole Lk()
        {
            return lk;
        }
        private void initEntreprise()
        {
            string[] val = Enum.GetNames(typeof(Entreprise));
            foreach (string st in val)
            {
                ListeEntreprise.Items.Add(st);
                LEntreprise.Items.Add(st);

            }
        }

       
        private void Parcourir_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string n = Nom.Text;
          
            string U = ListeEntreprise.SelectedItem.ToString();
            Entreprise f = (Entreprise)Enum.Parse(typeof(Entreprise), U, false);

            float p = Single.Parse(Prix.Text);
            DateTime da = date.Value;
          
            lk = new Konsole(n,p,da,f,pho);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Parcour_Click(object sender, EventArgs e)
        {

            OpenFileDialog diag = new OpenFileDialog();
            DialogResult res = diag.ShowDialog();
            if (res == DialogResult.OK)
            {
                string s = diag.FileName;
                Edition.Text = s;
                pho = Image.FromFile(s);
                Pimg.Image = pho.GetThumbnailImage(Pimg.Width, Pimg.Height, null, IntPtr.Zero);
            }
            diag.Dispose();
        }

        private void Bvalider_Click(object sender, EventArgs e)
        {
            bool t;
            string n = Nm.Text;
            string et = LEtat.Text;
            string U = LEntreprise.SelectedItem.ToString();
            Entreprise f = (Entreprise)Enum.Parse(typeof(Entreprise), U, false);

            float p = Single.Parse(LPrix.Text);
            DateTime da = LDate.Value;
           
            if (Avec.Checked)
                t = true;
            else
                t = false;
            lk = new KonsoleRetro(et,t,n, p, da, f, pho);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
