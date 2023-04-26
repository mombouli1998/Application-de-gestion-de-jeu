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
    public partial class VisuConsoleDld : Form
    {
        Leskonsoles g;
        public VisuConsoleDld(Leskonsoles g)
        {
            InitializeComponent();
            this.g = g;
            initArbre();
        }
        public void initArbre()
        {
            //Lesjeux g = new Lesjeux();
            foreach (Entreprise c in Enum.GetValues(typeof(Entreprise)))
            {
                TreeNode n1 = new TreeNode(c.ToString());
                Leskonsoles e = new Leskonsoles();
                for (int i = 0; i < g.GetNB(); i++)
                {
                    Konsole j = g.Getindice(i);

                    if (j.Nom!=null && j.Entreprise.Equals(c))
                    {
                        e.AjoutKonsole(j);
                    }
                }

                for (int i = 0; i < e.GetNB(); i++)
                {

                    //TreeNode n1 = new TreeNode(g.Getindice(i).Genres.ToString());
                    TreeNode n1child = new TreeNode(e.Getindice(i).Nom);
                    n1.Nodes.Add(n1child);

                }


                Arbre.Nodes.Add(n1);
            }

        }
            private void Arbre_AfterSelect(object sender, TreeViewEventArgs e)
            {

                     TreeView tv = (TreeView)sender;
                      TreeNode nd = tv.SelectedNode;
                      nd = e.Node;
                     
                      if (nd.Level > 0)
                      {
                          Konsole j = g.GetkonsoleNom(nd.Text);
                              if (j != null)
                              {

                                 Edition.Text = j.ToString();
                                 photo.Image = j.Logo.GetThumbnailImage(photo.Width, photo.Height,
                                  null, IntPtr.Zero);


                              }

                      }

             }

        private void photo_Click(object sender, EventArgs e)
        {

        }
    }
}
