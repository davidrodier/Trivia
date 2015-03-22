using Oracle.DataAccess.Client;
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
    public partial class EffacerJoueur : Form
    {
        private OracleConnection OraConn = new OracleConnection();
        private DataSet MonDataSet = new DataSet();

        public EffacerJoueur(OracleConnection conn, DataSet dataset)
        {
            OraConn = conn;
            MonDataSet = dataset;

            InitializeComponent();
        }

        private void BTN_Suprimer_Click(object sender, EventArgs e)
        {
            // Commande qui efface le joueur et ses données à partir de son alias (TB_AliasSupprimer)
            // La procedure devrait faire un message d'erreur si le joueur n'existe pas

           

           try
           {
               OracleCommand oraDelete = new OracleCommand("GESTIONJEU", OraConn);
               oraDelete.CommandText = "GESTIONJEU.DELETEJOUEUR";
               oraDelete.CommandType = CommandType.StoredProcedure;

               OracleParameter oraCode = new OracleParameter("IN_PSEUDO", OracleDbType.Varchar2);
               oraCode.Direction = ParameterDirection.Input;
               oraCode.Value = TB_AliasSupprimer.Text;
               oraDelete.Parameters.Add(oraCode);

               oraDelete.ExecuteNonQuery();

               MessageBox.Show("Un joueur portant le nom '" + TB_AliasSupprimer.Text.ToString() + "' a du être effacé."); 
           }
           catch (Exception ex)
           {
               MessageBox.Show( ex.ToString() ); 
           }
        }

        private void TB_AliasSupprimer_TextChanged(object sender, EventArgs e)
        {
            // Si la boîte est vide, on peut pas supprimer...
            if (TB_AliasSupprimer.Text.ToString().Length > 0)
            {
                BTN_Suprimer.Enabled = true;
            }
            else
            {
                BTN_Suprimer.Enabled = false;
            }
        }
    }
}
