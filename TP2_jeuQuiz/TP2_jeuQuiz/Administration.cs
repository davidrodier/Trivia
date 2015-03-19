using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP2_jeuQuiz
{
    public partial class Administration : Form
    {
        public int CodeCourrent = 0;
        /* Faut pas que ce soit trop facile pour
         que quelqu'un de random le devine */
        public String MotDePasse = "Administrator";
        private OracleConnection OraConn = new OracleConnection();
        public Administration(OracleConnection conn, int Nb)
        {
            InitializeComponent();
            CodeCourrent = Nb-1;
            SetNumbers();
            OraConn = conn;
        }

        public void SetNumbers()
        {
            CodeCourrent++;
            TB_CodeQuestion.Text = CodeCourrent.ToString();
            TB_CodeReponse.Text = CodeCourrent.ToString();
        }

        public void ResetBoxes()
        {
            TB_EnoncerQuestion.Text = "";
            TB_MauvaiseReponse1.Text = "";
            TB_MauvaiseReponse2.Text = "";
            TB_MauvaiseReponse3.Text = "";
            TB_BonneReponse.Text = "";
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
            String codeCat;

            switch (CB_CodeCatégorie.Text)
            {
                case "Sport":
                    codeCat = "SPR";
                    break;
                case "Art et Culture":
                    codeCat = "ART";
                    break;
                case "Histoire":
                    codeCat = "HIS";
                    break;
                case "Géographie":
                    codeCat = "GEO";
                    break;
                default:
                    codeCat = "SPR";
                    break;
            }
            // Insérer une réponse
            OracleCommand oraInsert = new OracleCommand("GESTIONJEU", OraConn);
            oraInsert.CommandText = "GESTIONJEU.INSERTQUESTION";
            oraInsert.CommandType = CommandType.StoredProcedure;

            OracleParameter oraCode = new OracleParameter("IN_CODE", OracleDbType.Int32);
            oraCode.Direction = ParameterDirection.Input;
            oraCode.Value = TB_CodeQuestion.Text;
            oraInsert.Parameters.Add(oraCode);

            OracleParameter oraCategory = new OracleParameter("IN_CATEGORY", OracleDbType.Varchar2, 150);
            oraCategory.Direction = ParameterDirection.Input;
            oraCategory.Value = codeCat;
            oraInsert.Parameters.Add(oraCategory);

            OracleParameter oraQuestion = new OracleParameter("IN_QUESTION", OracleDbType.Varchar2, 150);
            oraQuestion.Direction = ParameterDirection.Input;
            oraQuestion.Value = TB_EnoncerQuestion.Text;
            oraInsert.Parameters.Add(oraQuestion);

            OracleParameter oraReponse1 = new OracleParameter("IN_REPONSE1", OracleDbType.Varchar2, 150);
            oraReponse1.Direction = ParameterDirection.Input;
            oraReponse1.Value = TB_MauvaiseReponse1.Text;
            oraInsert.Parameters.Add(oraReponse1);

            OracleParameter oraReponse2 = new OracleParameter("IN_REPONSE2", OracleDbType.Varchar2, 150);
            oraReponse2.Direction = ParameterDirection.Input;
            oraReponse2.Value = TB_MauvaiseReponse2.Text;
            oraInsert.Parameters.Add(oraReponse2);

            OracleParameter oraReponse3 = new OracleParameter("IN_REPONSE3", OracleDbType.Varchar2, 150);
            oraReponse3.Direction = ParameterDirection.Input;
            oraReponse3.Value = TB_MauvaiseReponse3.Text;
            oraInsert.Parameters.Add(oraReponse3);

            OracleParameter oraReponse4 = new OracleParameter("IN_REPONSE4", OracleDbType.Varchar2, 150);
            oraReponse4.Direction = ParameterDirection.Input;
            oraReponse4.Value = TB_BonneReponse.Text;
            oraInsert.Parameters.Add(oraReponse4);

            oraInsert.ExecuteNonQuery();

            SetNumbers();
            ResetBoxes();
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
