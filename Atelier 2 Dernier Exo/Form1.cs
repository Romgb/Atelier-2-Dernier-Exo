using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_2_Dernier_Exo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            //Donne accès aux Radio Buttons
            if (text == string.Empty) { groupBox1.Enabled = false; }
            else { groupBox1.Enabled = true; }
        }
        #endregion

        #region Bouton Jouer

        #region Demande d'écrire une chaine de caractères
        private void btnJouer_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            //Message d'erreur si aucune chaîne de caractères n'est saisie
            if (text == string.Empty)
            {
                MessageBox.Show("Acccés refusé. Veuillez saisir une chaîne de caractères", "Erreur!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            #endregion

            if (rdBouton1.Checked)
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty )
                {
                    MessageBox.Show("Veuillez entrer un caractère", "Erreur!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    //int longueur = textBox1.TextLength;
                    //string text = textBox1.Text;
                    //int posIndex = 0;

                    //text.IndexOf(text, posIndex);
                }
            }
          

        }
        #endregion


    }
}
