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
    public partial class Form1 : Form
    {
        private Catalogue leCate;
        private ImageList lph;
        private ImageList lp;
        private Lesjeux g;
        public Form1()
        {
            InitializeComponent();
            leCate = new Catalogue();
            g = leCate.Ljeux;
            Leskonsoles k = leCate.Lstk;

            k.InitLstK();
            g.InitLstjeux();
           g.Trie();
            k.Trie();
            lph = new ImageList();

            initListePhotos();
            initListeJeux();
            initListeGenre();

            initlistEntreprise();
            initListekonsole();
            initListePhotoc();
        }
        private void initListePhotos()
        {
           leCate.Ljeux.Trie();
            listPhoto.DrawMode = DrawMode.OwnerDrawFixed;
            lph = new ImageList();
            lph.ImageSize = new Size(100, 100);
            for (int i = 0; i < g.GetNB(); i++)
            {
                lph.Images.Add(g.Getindice(i).Photo);
                listPhoto.Items.Add(g.Getindice(i).Nom);

                listPhoto.ItemHeight = 101;
            }

        }
        private void initListePhotoc()
        {
            ListePhotoC.DrawMode = DrawMode.OwnerDrawFixed;
            lp = new ImageList();
            lp.ImageSize = new Size(95, 100);
            for (int i = 0; i < leCate.Lstk.GetNB(); i++)
            {
                lp.Images.Add(leCate.Lstk.Getindice(i).Logo);
                ListePhotoC.Items.Add(leCate.Lstk.Getindice(i).Nom);

                ListePhotoC.ItemHeight = 101;
            }

        }
        public void initListeJeux()
        {

            listJeux.Items.Clear();
            for (int i = 0; i < g.GetNB(); i++)

            {
                listJeux.Items.Add(g.Getindice(i).Nom);

            }
        }

        private void initListeGenre()
        {
            string[] val = Enum.GetNames(typeof(Categenre));
            foreach (string st in val)
                ListeGenre.Items.Add(st);
        }
        public void initlistEntreprise()
        {
            string[] val = Enum.GetNames(typeof(Entreprise));
            foreach (string st in val)
                listeEntreprise.Items.Add(st);
        }
        private void initListekonsole()
        {
            for (int i = 0; i < leCate.Lstk.GetNB(); i++)

            {
                listConsole.Items.Add(leCate.Lstk.Getindice(i).Nom);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            initListePhotos();
            Edition.Text = g.ToString();
        }

        private void listPhoto_DrawItem(object sender, DrawItemEventArgs e)
        {
            Point p = e.Bounds.Location;
            lph.Draw(e.Graphics, p, e.Index);
        }

        private void listJeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = listJeux.SelectedItem.ToString();
            Jeu j = g.GetJeuNom(n);
            Edition.Text = j.ToString();

            Photo.Image = j.Photo.GetThumbnailImage(Photo.Width, Photo.Height, null, IntPtr.Zero);

        }

        private void listConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = listConsole.SelectedItem.ToString();
            Konsole j = leCate.Lstk.GetkonsoleNom(n);
            Edition.Text = j.ToString();

            PhotoC.Image = j.Logo.GetThumbnailImage(PhotoC.Width, PhotoC.Height, null, IntPtr.Zero);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ListeGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = ListeGenre.SelectedItem.ToString();
            Categenre c = (Categenre)Enum.Parse(typeof(Categenre), n, false);


            Lesjeux f = new Lesjeux();
            for (int i = 0; i < g.GetNB(); i++)
            {
                Jeu j = g.Getindice(i);
                if (j.Genres.Equals(n) == true)
                {
                    f.Ajoutjeu(j);
                }
                Edition.Text = f.ToString();
            }
        }

        private void listeEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = listeEntreprise.SelectedItem.ToString();
            Entreprise c = (Entreprise)Enum.Parse(typeof(Entreprise), n, false);


            Leskonsoles f = new Leskonsoles();
            for (int i = 0; i < leCate.Lstk.GetNB(); i++)
            {
                Konsole j = leCate.Lstk.Getindice(i);
                if (j.EntrepriseS.Equals(n) == true)
                {
                    f.AjoutKonsole(j);
                }
                Edition.Text = f.ToString();
            }
        }

        private void ListePhotoC_DrawItem(object sender, DrawItemEventArgs e)
        {

            Point p = e.Bounds.Location;
            lp.Draw(e.Graphics, p, e.Index);
        }

        private void listPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = listPhoto.SelectedItem.ToString();
            Jeu j = g.GetJeuNom(n);
            Edition.Text = j.ToString();

            Photo.Image = j.Photo.GetThumbnailImage(Photo.Width, Photo.Height, null, IntPtr.Zero);
        }

        private void ListePhotoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = ListePhotoC.SelectedItem.ToString();
            Konsole j = leCate.Lstk.GetkonsoleNom(n);
            Edition.Text = j.ToString();

            PhotoC.Image = j.Logo.GetThumbnailImage(PhotoC.Width, PhotoC.Height, null, IntPtr.Zero);
        }

        private void JRetro_Click(object sender, EventArgs e)
        {
            Edition.Text = g.Retro();
        }

        private void ToutConsole_Click(object sender, EventArgs e)
        {
            Edition.Text = leCate.Lstk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edition.Text = leCate.Lstk.Retro();
        }

        private void jeuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaisieJeuDlg diag = new SaisieJeuDlg();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                g.Ajoutjeu(diag.Lj());
                initListeJeux();


            }
        }

        private void consoleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaisieConsoleDlg diag = new SaisieConsoleDlg();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Konsole g = diag.Lk();

                leCate.Lstk.AjoutKonsole(g);
                listConsole.Items.Add(g.Nom);

                lp.Images.Add(g.Logo);
                ListePhotoC.Items.Add(g.Nom);


            }
        }

        private void jeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisuJeuDlg diag = new VisuJeuDlg(g);
            diag.ShowDialog();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisuConsoleDld diag = new VisuConsoleDld(leCate.Lstk);
            diag.ShowDialog();
        }

        private void jeuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MajJeudlg diag = new MajJeudlg(g);
            diag.ShowDialog();
        }

        private void consoleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MajKonsoleDlj diag = new MajKonsoleDlj(leCate.Lstk);
            diag.ShowDialog();
        }

        private void jeuToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            SupprimerJeuDlg diag = new SupprimerJeuDlg(g);
           
           

             if (diag.ShowDialog() == DialogResult.OK)
              {
                  List<string> h = diag.Nom;
                 
                      foreach ( string j in h)
                      {
                            for (int i = 0; i < g.GetNB(); i++)

                             {
                                         if(j.Equals(g.Getindice(i).Nom) == true)
                                          {
                                            // MessageBox.Show(leCate.Ljeux.Getindice(i).Nom);

                                             g.Supprimejeu(g.Getindice(i));
                                               listJeux.Items.RemoveAt(i);
                            // 
                                             lph.Images.RemoveAt(i);
                                              listPhoto.Items.RemoveAt(i);
                           
                                          }

                             }
                      }
              
             


            }
            




        }

        private void consoleToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Supprimer_ConsoleDlg diag = new Supprimer_ConsoleDlg(leCate.Lstk );
            if (diag.ShowDialog() == DialogResult.OK)
            {
                List<string> g = diag.Nom;

                foreach (string j in g)
                {
                    for (int i = 0; i < leCate.Ljeux.GetNB(); i++)

                    {
                        if (j.Equals(leCate.Lstk.Getindice(i).Nom) == true)
                        {
                            MessageBox.Show(leCate.Lstk.Getindice(i).Nom);

                            leCate.Lstk.SupprimeKonsole(leCate.Lstk.Getindice(i));
                            listConsole.Items.RemoveAt(i);
                            // 
                            lp.Images.RemoveAt(i);
                           // lis.Items.RemoveAt(i);

                        }

                    }
                }


            }


        }
    }
}
           
              
                

            

        
    

