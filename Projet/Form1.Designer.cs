namespace Projet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listPhoto = new System.Windows.Forms.ListBox();
            this.ListePhotoC = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Tjeux = new System.Windows.Forms.Button();
            this.JRetro = new System.Windows.Forms.Button();
            this.listJeux = new System.Windows.Forms.ListBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListeGenre = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.listeEntreprise = new System.Windows.Forms.ComboBox();
            this.ToutConsole = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listConsole = new System.Windows.Forms.ListBox();
            this.PhotoC = new System.Windows.Forms.PictureBox();
            this.Edition = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoC)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.visualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem1,
            this.consoleToolStripMenuItem1});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // jeuToolStripMenuItem1
            // 
            this.jeuToolStripMenuItem1.Name = "jeuToolStripMenuItem1";
            this.jeuToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.jeuToolStripMenuItem1.Text = "Jeu";
            this.jeuToolStripMenuItem1.Click += new System.EventHandler(this.jeuToolStripMenuItem1_Click);
            // 
            // consoleToolStripMenuItem1
            // 
            this.consoleToolStripMenuItem1.Name = "consoleToolStripMenuItem1";
            this.consoleToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.consoleToolStripMenuItem1.Text = "Console";
            this.consoleToolStripMenuItem1.Click += new System.EventHandler(this.consoleToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem2,
            this.consoleToolStripMenuItem2});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // jeuToolStripMenuItem2
            // 
            this.jeuToolStripMenuItem2.Name = "jeuToolStripMenuItem2";
            this.jeuToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.jeuToolStripMenuItem2.Text = "Jeu";
            this.jeuToolStripMenuItem2.Click += new System.EventHandler(this.jeuToolStripMenuItem2_Click);
            // 
            // consoleToolStripMenuItem2
            // 
            this.consoleToolStripMenuItem2.Name = "consoleToolStripMenuItem2";
            this.consoleToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.consoleToolStripMenuItem2.Text = "Console";
            this.consoleToolStripMenuItem2.Click += new System.EventHandler(this.consoleToolStripMenuItem2_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem3,
            this.consoleToolStripMenuItem3});
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // jeuToolStripMenuItem3
            // 
            this.jeuToolStripMenuItem3.Name = "jeuToolStripMenuItem3";
            this.jeuToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.jeuToolStripMenuItem3.Text = "Jeu";
            this.jeuToolStripMenuItem3.Click += new System.EventHandler(this.jeuToolStripMenuItem3_Click);
            // 
            // consoleToolStripMenuItem3
            // 
            this.consoleToolStripMenuItem3.Name = "consoleToolStripMenuItem3";
            this.consoleToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.consoleToolStripMenuItem3.Text = "Console";
            this.consoleToolStripMenuItem3.Click += new System.EventHandler(this.consoleToolStripMenuItem3_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem,
            this.jeuToolStripMenuItem});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jeuToolStripMenuItem.Text = "Jeu";
            this.jeuToolStripMenuItem.Click += new System.EventHandler(this.jeuToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.listPhoto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListePhotoC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Edition, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listPhoto
            // 
            this.listPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPhoto.FormattingEnabled = true;
            this.listPhoto.Location = new System.Drawing.Point(3, 3);
            this.listPhoto.Name = "listPhoto";
            this.listPhoto.Size = new System.Drawing.Size(114, 420);
            this.listPhoto.TabIndex = 0;
            this.listPhoto.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listPhoto_DrawItem);
            this.listPhoto.SelectedIndexChanged += new System.EventHandler(this.listPhoto_SelectedIndexChanged);
            // 
            // ListePhotoC
            // 
            this.ListePhotoC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListePhotoC.FormattingEnabled = true;
            this.ListePhotoC.Location = new System.Drawing.Point(123, 3);
            this.ListePhotoC.Name = "ListePhotoC";
            this.ListePhotoC.Size = new System.Drawing.Size(114, 420);
            this.ListePhotoC.TabIndex = 1;
            this.ListePhotoC.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListePhotoC_DrawItem);
            this.ListePhotoC.SelectedIndexChanged += new System.EventHandler(this.ListePhotoC_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Tjeux, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.JRetro, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.listJeux, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Photo, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(563, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 420);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Tjeux
            // 
            this.Tjeux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tjeux.Location = new System.Drawing.Point(3, 3);
            this.Tjeux.Name = "Tjeux";
            this.Tjeux.Size = new System.Drawing.Size(108, 78);
            this.Tjeux.TabIndex = 0;
            this.Tjeux.Text = "Tout les jeux";
            this.Tjeux.UseVisualStyleBackColor = true;
            this.Tjeux.Click += new System.EventHandler(this.button1_Click);
            // 
            // JRetro
            // 
            this.JRetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JRetro.Location = new System.Drawing.Point(3, 87);
            this.JRetro.Name = "JRetro";
            this.JRetro.Size = new System.Drawing.Size(108, 78);
            this.JRetro.TabIndex = 1;
            this.JRetro.Text = "Jeu Retro";
            this.JRetro.UseVisualStyleBackColor = true;
            this.JRetro.Click += new System.EventHandler(this.JRetro_Click);
            // 
            // listJeux
            // 
            this.listJeux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJeux.FormattingEnabled = true;
            this.listJeux.Location = new System.Drawing.Point(3, 255);
            this.listJeux.Name = "listJeux";
            this.listJeux.Size = new System.Drawing.Size(108, 78);
            this.listJeux.TabIndex = 2;
            this.listJeux.SelectedIndexChanged += new System.EventHandler(this.listJeux_SelectedIndexChanged);
            // 
            // Photo
            // 
            this.Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo.Location = new System.Drawing.Point(3, 339);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(108, 78);
            this.Photo.TabIndex = 3;
            this.Photo.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ListeGenre, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 171);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(108, 78);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListeGenre
            // 
            this.ListeGenre.FormattingEnabled = true;
            this.ListeGenre.Location = new System.Drawing.Point(3, 42);
            this.ListeGenre.Name = "ListeGenre";
            this.ListeGenre.Size = new System.Drawing.Size(102, 21);
            this.ListeGenre.TabIndex = 1;
            this.ListeGenre.SelectedIndexChanged += new System.EventHandler(this.ListeGenre_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ToutConsole, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.listConsole, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.PhotoC, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(683, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(114, 420);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.listeEntreprise, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 171);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(108, 78);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listeEntreprise
            // 
            this.listeEntreprise.FormattingEnabled = true;
            this.listeEntreprise.Location = new System.Drawing.Point(3, 42);
            this.listeEntreprise.Name = "listeEntreprise";
            this.listeEntreprise.Size = new System.Drawing.Size(102, 21);
            this.listeEntreprise.TabIndex = 1;
            this.listeEntreprise.SelectedIndexChanged += new System.EventHandler(this.listeEntreprise_SelectedIndexChanged);
            // 
            // ToutConsole
            // 
            this.ToutConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToutConsole.Location = new System.Drawing.Point(3, 3);
            this.ToutConsole.Name = "ToutConsole";
            this.ToutConsole.Size = new System.Drawing.Size(108, 78);
            this.ToutConsole.TabIndex = 0;
            this.ToutConsole.Text = "Tout les consoles";
            this.ToutConsole.UseVisualStyleBackColor = true;
            this.ToutConsole.Click += new System.EventHandler(this.ToutConsole_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 78);
            this.button4.TabIndex = 1;
            this.button4.Text = "Console Retro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listConsole
            // 
            this.listConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConsole.FormattingEnabled = true;
            this.listConsole.Location = new System.Drawing.Point(3, 255);
            this.listConsole.Name = "listConsole";
            this.listConsole.Size = new System.Drawing.Size(108, 78);
            this.listConsole.TabIndex = 2;
            this.listConsole.SelectedIndexChanged += new System.EventHandler(this.listConsole_SelectedIndexChanged);
            // 
            // PhotoC
            // 
            this.PhotoC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoC.Location = new System.Drawing.Point(3, 339);
            this.PhotoC.Name = "PhotoC";
            this.PhotoC.Size = new System.Drawing.Size(108, 78);
            this.PhotoC.TabIndex = 3;
            this.PhotoC.TabStop = false;
            this.PhotoC.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Edition
            // 
            this.Edition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edition.Location = new System.Drawing.Point(243, 3);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(314, 420);
            this.Edition.TabIndex = 5;
            this.Edition.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listPhoto;
        private System.Windows.Forms.ListBox ListePhotoC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Tjeux;
        private System.Windows.Forms.Button JRetro;
        private System.Windows.Forms.ListBox listJeux;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListeGenre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listeEntreprise;
        private System.Windows.Forms.Button ToutConsole;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listConsole;
        private System.Windows.Forms.PictureBox PhotoC;
        private System.Windows.Forms.RichTextBox Edition;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem3;
    }
}

