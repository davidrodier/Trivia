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
   public partial class Form1 : Form
   {
      private OracleConnection OraConn = new OracleConnection();
      private DataSet MonDataSet = new DataSet();
      private OracleParameter Param = new OracleParameter();
      private OracleDataAdapter Adapter = new OracleDataAdapter();

      public int NombreJoueurs = 0; // Quand c'est 0, y'a pas de partie en ce moment. 

      public Form1()
      {
         InitializeComponent();
      }

      private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Demander si on veut quitter
         DialogResult Resultat = MessageBox.Show("Êtes-vous sûr de vouloir quitter?",
               "Voulez-vous quitter?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

         if (Resultat == DialogResult.Yes)
         {
            // Quitter le jeu
            this.Close();
         }

      }

      private void LBL_NumeroJoueurQuiJoue_Click(object sender, EventArgs e)
      {

      }

      private void infoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // fenêtre "à propos"
         aPropos FenetrePropos = new aPropos();

         // Montrer la fenêtre
         FenetrePropos.ShowDialog();

      }

      private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
      {
         NouvellePartie FenetreNouvellePartie = new NouvellePartie();

         if (FenetreNouvellePartie.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                     "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string ChaineConnexion = "Data Source = " + Dsource + ";User Id =" + "Rodierda" + "; Password =" + "ORACLE1";

            try
            {
               OraConn.ConnectionString = ChaineConnexion;
               OraConn.Open();

               if (OraConn.State.ToString() == "Open")
               {
                  MessageBox.Show("Connecté");
               }
               else
               {
                  MessageBox.Show(OraConn.State.ToString());
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message.ToString());
            }

            groupBox1.Enabled = true;
            GB_ChoixCat.Enabled = true;
            GB_ChoixDeReponses.Enabled = true;
            GB_Question.Enabled = true;
            BTN_ProchainTour.Enabled = true;

           // On a deux choix, remettre à noeuf la table d'un joueur pour commencer une partie à zéro
            if (FenetreNouvellePartie.Reprise == false)
            { 
            
            }

             // Ou on reprend avec ses anciens scores
            if (FenetreNouvellePartie.Reprise == true)
            {

            }


             // Aller chercher le nombre de joeurs qu'il y a dans l'autre Form
            NombreJoueurs = FenetreNouvellePartie.NombreJoueurs;

            GetQuestion();
         }
      }

      private void panneauDadministrationToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Administration FenetreAdmin = new Administration();
         FenetreAdmin.ShowDialog();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void effacerUnJoueurToolStripMenuItem_Click(object sender, EventArgs e)
      {
         EffacerJoueur FenetreEffacerJoueur = new EffacerJoueur();
         FenetreEffacerJoueur.ShowDialog();
      }

      private void GetQuestion()
      {
         Random rdm = new Random();

         OracleCommand oraSelect = new OracleCommand("GESTIONJEU", OraConn);
         oraSelect.CommandText = "GESTIONJEU.SELECTQUESTION";
         oraSelect.CommandType = CommandType.StoredProcedure;

         OracleParameter oraCursor = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
         oraCursor.Direction = ParameterDirection.ReturnValue;
         oraSelect.Parameters.Add(oraCursor);

         OracleParameter oraNum = new OracleParameter("NUMERODEQUESTION", OracleDbType.Int32);
         oraNum.Direction = ParameterDirection.Input;
         oraNum.Value = rdm.Next(1, 30);
         oraSelect.Parameters.Add(oraNum);

         OracleDataAdapter orAdater = new OracleDataAdapter(oraSelect);
         if (MonDataSet.Tables.Contains("Question"))
         {
            MonDataSet.Tables["Question"].Clear();
         }
         orAdater.Fill(MonDataSet, "Question");
         oraSelect.Dispose();         
      }
   }
}
