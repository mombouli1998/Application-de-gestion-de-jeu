namespace Projet
{
    partial class MajKonsoleDlj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Maj = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Maj)).BeginInit();
            this.SuspendLayout();
            // 
            // Maj
            // 
            this.Maj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Maj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maj.Location = new System.Drawing.Point(0, 0);
            this.Maj.Name = "Maj";
            this.Maj.Size = new System.Drawing.Size(800, 450);
            this.Maj.TabIndex = 0;
            this.Maj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Maj_CellContentClick);
            // 
            // MajKonsoleDlj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Maj);
            this.Name = "MajKonsoleDlj";
            this.Text = "MajKonsoleDlj";
            ((System.ComponentModel.ISupportInitialize)(this.Maj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Maj;
    }
}