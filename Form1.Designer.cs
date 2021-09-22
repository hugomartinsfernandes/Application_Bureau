
namespace Application_Bureau
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_test = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChoixFichier = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez selectionner votre imprimante :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "HP_Jet_1234",
            "EPSON1234 ( ET-Series)",
            "HP DeskJet 3630 series"});
            this.listBox1.Location = new System.Drawing.Point(4, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 276);
            this.listBox1.TabIndex = 1;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(408, 56);
            this.picBox1.MinimumSize = new System.Drawing.Size(600, 500);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(600, 600);
            this.picBox1.TabIndex = 2;
            this.picBox1.TabStop = false;
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_test.Location = new System.Drawing.Point(230, 74);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(172, 17);
            this.lbl_test.TabIndex = 3;
            this.lbl_test.Text = "Aperçu avant impression :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Veuillez choisir le fichier à imprimer :";
            // 
            // btnChoixFichier
            // 
            this.btnChoixFichier.Location = new System.Drawing.Point(473, 24);
            this.btnChoixFichier.Name = "btnChoixFichier";
            this.btnChoixFichier.Size = new System.Drawing.Size(38, 26);
            this.btnChoixFichier.TabIndex = 5;
            this.btnChoixFichier.Text = "...";
            this.btnChoixFichier.UseVisualStyleBackColor = true;
            this.btnChoixFichier.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(4, 309);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(75, 26);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitter.Location = new System.Drawing.Point(134, 309);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 26);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 747);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnChoixFichier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impression";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChoixFichier;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

