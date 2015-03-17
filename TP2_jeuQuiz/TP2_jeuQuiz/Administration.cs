using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_jeuQuiz
{
    public partial class Administration : Form
    {
        public String MotDePasse = "BlancCommeNeige";

        public Administration()
        {
            InitializeComponent();
        }

        private void TB_MotDePasse_TextChanged(object sender, EventArgs e)
        {
            if (TB_MotDePasse.Text.ToString() == MotDePasse)
            {
                // On donne accès à la page


            }
            else
            { 
                // On ferme complètement l'accès à la page


            }
        }

        private void BTN_InsererReponse_Click(object sender, EventArgs e)
        {
            // Insérer une réponse


        }

        private void BTN_RemplacerReponses_Click(object sender, EventArgs e)
        {
            // Remplacer une réponse


        }

        private void BTN_EffacerReponses_Click(object sender, EventArgs e)
        {
            // Effacer une réponse


        }

        private void BTN_InsererQuestions_Click(object sender, EventArgs e)
        {
            // Insérer une question


        }

        private void BTN_RemplacerQuestion_Click(object sender, EventArgs e)
        {
            // Remplacer une question


        }

        private void BTN_EffacerQuestion_Click(object sender, EventArgs e)
        {
            // Effacer une question


        }
    }
}
