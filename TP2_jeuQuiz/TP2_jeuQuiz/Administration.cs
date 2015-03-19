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
        private DataSet MonDataSet = new DataSet();
        public Administration(OracleConnection conn, DataSet dataset, int Nb)
        {
            InitializeComponent();
            CodeCourrent = Nb;
            SetNumbers();
            OraConn = conn;
            MonDataSet = dataset;
        }

        public void SetNumbers()
        {
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
            {
               TB_MauvaiseReponse1.Enabled = GB_Question.Enabled;
               TB_MauvaiseReponse2.Enabled = GB_Question.Enabled;
               TB_MauvaiseReponse3.Enabled = GB_Question.Enabled;
               TB_BonneReponse.Enabled = GB_Question.Enabled;
               label1.Enabled = GB_Question.Enabled;
               label2.Enabled = GB_Question.Enabled;
               label3.Enabled = GB_Question.Enabled;
               label4.Enabled = GB_Question.Enabled;
               label5.Enabled = GB_Question.Enabled;
            }
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

            CodeCourrent++;

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
            TB_MauvaiseReponse1.Enabled = (TB_EnoncerQuestion.Text != "");
            TB_MauvaiseReponse2.Enabled = (TB_EnoncerQuestion.Text != "");
            TB_MauvaiseReponse3.Enabled = (TB_EnoncerQuestion.Text != "");
            TB_BonneReponse.Enabled = (TB_EnoncerQuestion.Text != "");

            label1.Enabled = (TB_EnoncerQuestion.Text != "");
            label2.Enabled = (TB_EnoncerQuestion.Text != "");
            label3.Enabled = (TB_EnoncerQuestion.Text != "");
            label4.Enabled = (TB_EnoncerQuestion.Text != "");
            label5.Enabled = (TB_EnoncerQuestion.Text != "");
        }

        private void TB_MauvaiseReponse1_TextChanged(object sender, EventArgs e)
        {
           if(!TB_CodeReponse.Enabled)
               CheckForEmptyBoxes();
        }

        private void TB_MauvaiseReponse2_TextChanged(object sender, EventArgs e)
        {
           if (!TB_CodeReponse.Enabled)
              CheckForEmptyBoxes();
        }

        private void TB_MauvaiseReponse3_TextChanged(object sender, EventArgs e)
        {
           if (!TB_CodeReponse.Enabled)
              CheckForEmptyBoxes();
        }

        private void TB_BonneReponse_TextChanged(object sender, EventArgs e)
        {
           if (!TB_CodeReponse.Enabled)
              CheckForEmptyBoxes();
        }

        private void CheckForEmptyBoxes()
        {
            BTN_InsererReponse.Enabled = (TB_BonneReponse.Text != "" &&
                                            TB_MauvaiseReponse1.Text != "" &&
                                            TB_MauvaiseReponse2.Text != "" &&
                                            TB_MauvaiseReponse3.Text != "");
        }

        private void BTN_RemplacerReponses_Click_1(object sender, EventArgs e)
        {
           if (!TB_CodeReponse.Enabled)
           {
              TB_CodeReponse.Enabled = true;
              BTN_InsererReponse.Enabled = false;
              BTN_EffacerReponses.Enabled = false;
              BTN_Load.Visible = true;
              CB_CodeCatégorie.Enabled = false;
           }
           else
           {
              OracleCommand oraUpdate = new OracleCommand("GESTIONJEU", OraConn);
              oraUpdate.CommandText = "GESTIONJEU.UPDATEQUESTION";
              oraUpdate.CommandType = CommandType.StoredProcedure;

              OracleParameter oraCode = new OracleParameter("IN_CODE", OracleDbType.Int32);
              oraCode.Direction = ParameterDirection.Input;
              oraCode.Value = TB_CodeReponse.Text;
              oraUpdate.Parameters.Add(oraCode);

              OracleParameter oraQuestion = new OracleParameter("IN_QUESTION", OracleDbType.Varchar2, 150);
              oraQuestion.Direction = ParameterDirection.Input;
              oraQuestion.Value = TB_EnoncerQuestion.Text;
              oraUpdate.Parameters.Add(oraQuestion);

              OracleParameter oraReponse1 = new OracleParameter("IN_REPONSE1", OracleDbType.Varchar2, 150);
              oraReponse1.Direction = ParameterDirection.Input;
              oraReponse1.Value = TB_MauvaiseReponse1.Text;
              oraUpdate.Parameters.Add(oraReponse1);

              OracleParameter oraReponse2 = new OracleParameter("IN_REPONSE2", OracleDbType.Varchar2, 150);
              oraReponse2.Direction = ParameterDirection.Input;
              oraReponse2.Value = TB_MauvaiseReponse2.Text;
              oraUpdate.Parameters.Add(oraReponse2);

              OracleParameter oraReponse3 = new OracleParameter("IN_REPONSE3", OracleDbType.Varchar2, 150);
              oraReponse3.Direction = ParameterDirection.Input;
              oraReponse3.Value = TB_MauvaiseReponse3.Text;
              oraUpdate.Parameters.Add(oraReponse3);

              OracleParameter oraReponse4 = new OracleParameter("IN_REPONSE4", OracleDbType.Varchar2, 150);
              oraReponse4.Direction = ParameterDirection.Input;
              oraReponse4.Value = TB_BonneReponse.Text;
              oraUpdate.Parameters.Add(oraReponse4);

              oraUpdate.ExecuteNonQuery();

              TB_CodeReponse.Enabled = false;
              BTN_InsererReponse.Enabled = true;
              BTN_EffacerReponses.Enabled = true;
              BTN_Load.Visible = false;
              CB_CodeCatégorie.Enabled = true;

              TB_EnoncerQuestion.Text = "";
              TB_MauvaiseReponse1.Text = "";
              TB_MauvaiseReponse2.Text = "";
              TB_MauvaiseReponse3.Text = "";
              TB_BonneReponse.Text = "";

              SetNumbers();
           }
        }

        private void BTN_EffacerReponses_Click_1(object sender, EventArgs e)
        {
           if (!TB_CodeReponse.Enabled)
           {
              TB_CodeReponse.Enabled = true;
              BTN_InsererReponse.Enabled = false;
              BTN_RemplacerReponses.Enabled = false;
              CB_CodeCatégorie.Enabled = false;
           }
           else
           {
              OracleCommand oraDelete = new OracleCommand("GESTIONJEU", OraConn);
              oraDelete.CommandText = "GESTIONJEU.DELETEQUESTION";
              oraDelete.CommandType = CommandType.StoredProcedure;

              OracleParameter oraCode = new OracleParameter("IN_CODE", OracleDbType.Int32);
              oraCode.Direction = ParameterDirection.Input;
              oraCode.Value = TB_CodeReponse.Text;
              oraDelete.Parameters.Add(oraCode);

              oraDelete.ExecuteNonQuery();

              TB_CodeReponse.Enabled = false;
              BTN_InsererReponse.Enabled = true;
              BTN_RemplacerReponses.Enabled = true;
              CB_CodeCatégorie.Enabled = true;

              TB_EnoncerQuestion.Text = "";
              TB_MauvaiseReponse1.Text = "";
              TB_MauvaiseReponse2.Text = "";
              TB_MauvaiseReponse3.Text = "";

              SetNumbers();
           }
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
           if(TB_CodeQuestion.Text != "")
           {
              OracleCommand oraSelect = new OracleCommand("GESTIONJEU", OraConn);
              oraSelect.CommandText = "GESTIONJEU.SELECTQUESTIONNUMERO";
              oraSelect.CommandType = CommandType.StoredProcedure;

              OracleParameter oraResultat = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
              oraResultat.Direction = ParameterDirection.ReturnValue;
              oraSelect.Parameters.Add(oraResultat);

              OracleParameter oraCode = new OracleParameter("NUMERO", OracleDbType.Int32);
              oraCode.Direction = ParameterDirection.Input;
              oraCode.Value = TB_CodeReponse.Text;
              oraSelect.Parameters.Add(oraCode);

              OracleDataAdapter orAdater = new OracleDataAdapter(oraSelect);
              if (MonDataSet.Tables.Contains("SelectQuestion"))
              {
                 MonDataSet.Tables["SelectQuestion"].Clear();
              }
              orAdater.Fill(MonDataSet, "SelectQuestion");
              oraSelect.Dispose();

              TB_EnoncerQuestion.Text = MonDataSet.Tables["SelectQuestion"].Rows[0].ItemArray.GetValue(0).ToString();
              TB_MauvaiseReponse1.Text = MonDataSet.Tables["SelectQuestion"].Rows[0].ItemArray.GetValue(1).ToString();
              TB_MauvaiseReponse2.Text = MonDataSet.Tables["SelectQuestion"].Rows[0].ItemArray.GetValue(2).ToString();
              TB_MauvaiseReponse3.Text = MonDataSet.Tables["SelectQuestion"].Rows[0].ItemArray.GetValue(3).ToString();
              TB_BonneReponse.Text = MonDataSet.Tables["SelectQuestion"].Rows[0].ItemArray.GetValue(4).ToString();

              BTN_InsererReponse.Enabled = false;
           }
        }
    }
}
