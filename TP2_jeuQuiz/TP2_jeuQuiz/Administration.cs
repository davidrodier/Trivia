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
        /* Faut pas que ce soit trop facile pour
         que quelqu'un de random le devine */
        public String MotDePasse = "Administrator";

        public Administration(int Nb)
        {
            InitializeComponent();
            TB_CodeQuestion.Text = Nb.ToString();
            TB_CodeReponse.Text = Nb.ToString();
        }

        public Administration()
        {
            InitializeComponent();
            TB_CodeQuestion.Text = "NAN";
            TB_CodeReponse.Text = "NAN";
        }

        private void TB_MotDePasse_TextChanged(object sender, EventArgs e)
        {
            GB_Question.Enabled = (TB_MotDePasse.Text.ToString() == MotDePasse);
            if (!GB_Question.Enabled)
                GB_Reponses.Enabled = GB_Question.Enabled;
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

        private void TB_EnoncerQuestion_TextChanged(object sender, EventArgs e)
        {
            GB_Reponses.Enabled = (TB_EnoncerQuestion.Text != "");
        }

        private void TB_MauvaiseReponse1_TextChanged(object sender, EventArgs e)
        {
            CheckForEmptyBoxes();
        }

        private void TB_MauvaiseReponse2_TextChanged(object sender, EventArgs e)
        {
            CheckForEmptyBoxes();
        }

        private void TB_MauvaiseReponse3_TextChanged(object sender, EventArgs e)
        {
            CheckForEmptyBoxes();
        }

        private void TB_BonneReponse_TextChanged(object sender, EventArgs e)
        {
            CheckForEmptyBoxes();
        }

        private void CheckForEmptyBoxes()
        {
            BTN_InsererReponse.Enabled = (TB_BonneReponse.Text != "" &&
                                            TB_MauvaiseReponse1.Text != "" &&
                                            TB_MauvaiseReponse2.Text != "" &&
                                            TB_MauvaiseReponse3.Text != "");
        }
    }
}
