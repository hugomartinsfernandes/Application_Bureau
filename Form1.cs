using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Bureau
{
    public partial class Form1 : Form
    {
        private string fileContent;
        private string filePath;

        private Bitmap Myimage;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // récupération d'un fichier et affichage en pré-impression
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // permet de récupérer l'emplacement du fichier à afficher et imprimer
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    string filePath = openFileDialog.FileName;
                    filePath= filePath.Replace("\\", "\\\\");

                    //lbl_test.Text = filePath; // test débug

                    Myimage = new Bitmap(filePath);
                    picBox1.Image= Myimage;
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // bouton imprimer
        {
            if ((listBox1.SelectedIndex != -1) && ( picBox1.Image != null)) // vérifie si une imprimante à été sélectionné et si un document à été chargé
            {
                MessageBox.Show("Votre document à bien été imprimé, vous pouvez le récupérer avec le code 12345");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un périphérique d'impression ainsi qu'un fichier à imprimer");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
