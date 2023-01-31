using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetIMCavecMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextName.Text = TextName.Text.ToUpper();
            TextName.ForeColor = Color.Red;
        }

        private void ButtonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
            }

        }

        private void ButtonCalculer_Click(object sender, EventArgs e)
        {

            double poids;
            double taille;
            try
            {
                poids = Convert.ToDouble(TextPoids.Text);
                taille = Convert.ToDouble(TextTaille.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("S'il vous plaît entrez une valeur numérique valide pour le poids et la taille.");
                return;
            }

            double resultat = Util.AfficherResultatIMC(poids, taille);
            TextResultat.Text = String.Format("{0:0.00}", resultat);

            switch (resultat)
            {
                case double n when n < 18.5:
                    MessageBox.Show("Votre IMC est inférieur à 18,5. Vous êtes en sous-poids.");
                    break;
                case double n when n >= 18.5 && n < 25:
                    MessageBox.Show("Votre IMC est compris entre 18,5 et 25. Vous avez un poids normal.");
                    break;
                case double n when n >= 25 && n < 30:
                    MessageBox.Show("Votre IMC est compris entre 25 et 30. Vous avez un surpoids.");
                    break;
                case double n when n >= 30:
                    MessageBox.Show("Votre IMC est supérieur à 30. Vous êtes en obésité.");
                    break;
                default:
                    MessageBox.Show("Une erreur s'est produite lors du calcul de votre IMC.");
                    break;
            }
        }
    }
}
