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
    public partial class VisuJeuDlg : Form
    {
        private Lesjeux lj;
        private Image pl;
        public VisuJeuDlg(Lesjeux lj)
        {
            InitializeComponent();
            this.lj = lj;
            initArbre();
        }
        public void initArbre()
        {

            foreach (Categenre c in Enum.GetValues(typeof(Categenre)))
            {
                TreeNode n1 = new TreeNode(c.ToString());
                Lesjeux g = new Lesjeux();
                for (int i = 0; i < lj.GetNB(); i++)
                {
                    Jeu j = lj.Getindice(i);
                    if (j.Genre.Equals(c))
                    {
                        g.Ajoutjeu(j);
                    }
                }

                for (int i = 0; i < g.GetNB(); i++)
                {


                    TreeNode n1child = new TreeNode(g.Getindice(i).Nom);
                    n1.Nodes.Add(n1child);

                }


                Arbre.Nodes.Add(n1);
            }


        }
        private void Arbre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tv = (TreeView)sender;
            TreeNode nd = tv.SelectedNode;

            if (nd.Level > 0)
            {
                Jeu j = this.lj.GetJeuNom(nd.Text);
                if (j != null)
                {

                    Edition.Text = j.ToString();
                    photo.Image = j.Photo.GetThumbnailImage(photo.Width, photo.Height,
                    null, IntPtr.Zero);


                }

            }
        }

        private void Edition_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
