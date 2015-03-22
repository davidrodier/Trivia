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
   public partial class NouvellePartie : Form
   {
       public int NombreJoueurs = 0;
       public bool Reprise = false;
       public String NomJoueur1 = "";
       public String NomJoueur2 = "";
       public String NomJoueur3 = "";
       public String NomJoueur4 = "";

       private OracleConnection OraConn = new OracleConnection();
       private DataSet MonDataSet = new DataSet();

       public NouvellePartie(OracleConnection conn, DataSet dataset)
      {
          OraConn = conn;
          MonDataSet = dataset;

         InitializeComponent();

         RB_NJ1.Checked = true;
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void NouvellePartie_Load(object sender, EventArgs e)
      {

      }

      private void CheckToEnableCommencer()
      {
          BTN_CommencerPartie.Enabled = false;

          // Check si les conditions sont là pour pouvoir commencer la partie correctement
          if (RB_NJ4.Checked && TB_AliasJ4.Text.ToString().Length > 0
              && TB_AliasJ3.Text.ToString().Length > 0
              && TB_AliasJ2.Text.ToString().Length > 0
              && TB_AliasJ1.Text.ToString().Length > 0)
          {
              BTN_CommencerPartie.Enabled = true;
          }
          else if (RB_NJ3.Checked && TB_AliasJ3.Text.ToString().Length > 0
              && TB_AliasJ2.Text.ToString().Length > 0
              && TB_AliasJ1.Text.ToString().Length > 0)
          {
              BTN_CommencerPartie.Enabled = true;
          }
          else if (RB_NJ2.Checked && TB_AliasJ2.Text.ToString().Length > 0
              && TB_AliasJ1.Text.ToString().Length > 0)
          {
              BTN_CommencerPartie.Enabled = true;
          }
          else if (RB_NJ1.Checked && TB_AliasJ1.Text.ToString().Length > 0)
          {
              BTN_CommencerPartie.Enabled = true;
          }
      }

      private void RB_NJ1_CheckedChanged(object sender, EventArgs e)
      {
         TB_AliasJ1.Enabled = RB_NJ1.Checked;
         TB_AliasJ2.Enabled = !RB_NJ1.Checked;
         TB_AliasJ3.Enabled = !RB_NJ1.Checked;
         TB_AliasJ4.Enabled = !RB_NJ1.Checked;
         
         TB_AliasJ2.Text = "";
         TB_AliasJ3.Text = "";
         TB_AliasJ4.Text = "";

         CheckToEnableCommencer();
      }

      private void RB_NJ2_CheckedChanged(object sender, EventArgs e)
      {
         TB_AliasJ1.Enabled = RB_NJ2.Checked;
         TB_AliasJ2.Enabled = RB_NJ2.Checked;
         TB_AliasJ3.Enabled = !RB_NJ2.Checked;
         TB_AliasJ4.Enabled = !RB_NJ2.Checked;

         TB_AliasJ3.Text = "";
         TB_AliasJ4.Text = "";

         CheckToEnableCommencer();
      }

      private void RB_NJ3_CheckedChanged(object sender, EventArgs e)
      {
         TB_AliasJ1.Enabled = RB_NJ3.Checked;
         TB_AliasJ2.Enabled = RB_NJ3.Checked;
         TB_AliasJ3.Enabled = RB_NJ3.Checked;
         TB_AliasJ4.Enabled = !RB_NJ3.Checked;

         TB_AliasJ4.Text = "";

         CheckToEnableCommencer();
      }

      private void RB_NJ4_CheckedChanged(object sender, EventArgs e)
      {
         TB_AliasJ1.Enabled = RB_NJ4.Checked;
         TB_AliasJ2.Enabled = RB_NJ4.Checked;
         TB_AliasJ3.Enabled = RB_NJ4.Checked;
         TB_AliasJ4.Enabled = RB_NJ4.Checked;

         CheckToEnableCommencer();
      }

      private void BTN_CommencerPartie_Click(object sender, EventArgs e)
      {
          // On check combien de joueurs il y a
          if (RB_NJ4.Checked)
          {
              NombreJoueurs = 4;
          }
          else if (RB_NJ3.Checked)
          {
              NombreJoueurs = 3;
          }
          else if (RB_NJ2.Checked)
          {
              NombreJoueurs = 2;
          }
          else if (RB_NJ1.Checked)
          {
              NombreJoueurs = 1;
          }

          // Faut faire les insertion des joueurs dans chaques catégories
          int i = 1;
          if (CB_Reprise.Checked == false)
          {
              // On efface les joueurs et leur scores

              if (RB_NJ2.Checked == true)
              {
                  i++;
              }
              if (RB_NJ3.Checked == true)
              {
                  i++;
              }
              if (RB_NJ4.Checked == true)
              {
                  i++;
              }

              try
              {
                  if (i >= 1)
                  {
                      OracleCommand oraDelete = new OracleCommand("GESTIONJEU", OraConn);
                      oraDelete.CommandText = "GESTIONJEU.DELETEJOUEUR";
                      oraDelete.CommandType = CommandType.StoredProcedure;

                      OracleParameter oraCode = new OracleParameter("IN_PSEUDO", OracleDbType.Varchar2);
                      oraCode.Direction = ParameterDirection.Input;
                      oraCode.Value = TB_AliasJ1.Text;
                      oraDelete.Parameters.Add(oraCode);

                      oraDelete.ExecuteNonQuery();
                  }
                  if (i >= 2)
                  {
                      OracleCommand oraDelete = new OracleCommand("GESTIONJEU", OraConn);
                      oraDelete.CommandText = "GESTIONJEU.DELETEJOUEUR";
                      oraDelete.CommandType = CommandType.StoredProcedure;

                      OracleParameter oraCode = new OracleParameter("IN_PSEUDO", OracleDbType.Varchar2);
                      oraCode.Direction = ParameterDirection.Input;
                      oraCode.Value = TB_AliasJ2.Text;
                      oraDelete.Parameters.Add(oraCode);

                      oraDelete.ExecuteNonQuery();
                  }
                  if (i >= 3)
                  {
                      OracleCommand oraDelete = new OracleCommand("GESTIONJEU", OraConn);
                      oraDelete.CommandText = "GESTIONJEU.DELETEJOUEUR";
                      oraDelete.CommandType = CommandType.StoredProcedure;

                      OracleParameter oraCode = new OracleParameter("IN_PSEUDO", OracleDbType.Varchar2);
                      oraCode.Direction = ParameterDirection.Input;
                      oraCode.Value = TB_AliasJ3.Text;
                      oraDelete.Parameters.Add(oraCode);

                      oraDelete.ExecuteNonQuery();
                  }
                  if (i >= 4)
                  {
                      OracleCommand oraDelete = new OracleCommand("GESTIONJEU", OraConn);
                      oraDelete.CommandText = "GESTIONJEU.DELETEJOUEUR";
                      oraDelete.CommandType = CommandType.StoredProcedure;

                      OracleParameter oraCode = new OracleParameter("IN_PSEUDO", OracleDbType.Varchar2);
                      oraCode.Direction = ParameterDirection.Input;
                      oraCode.Value = TB_AliasJ4.Text;
                      oraDelete.Parameters.Add(oraCode);

                      oraDelete.ExecuteNonQuery();
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }

              // C'est clean!
          }
          else
          {
              // On fait les insertions...
              // Ça va se faire si les joueurs sont pas déjà là.

              String[] Categories = { "SPR", "HIS", "GEO", "ART" };

              try
              {
                  if (i >= 1)
                  {
                      //for (int j = 0; j < 4; j++)
                      //{

                      //    // Le sélect
                      //    OracleCommand oraSelect = new OracleCommand("GESTIONJEU", OraConn);
                      //    oraSelect.CommandText = "GESTIONJEU.SELECTSCOREFROMJOUEUR";
                      //    oraSelect.CommandType = CommandType.StoredProcedure;

                      //    // Le curseur
                      //    OracleParameter oraCursor = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
                      //    oraCursor.Direction = ParameterDirection.ReturnValue;
                      //    oraSelect.Parameters.Add(oraCursor);

                      //    // Catégorie
                      //    OracleParameter oraCat = new OracleParameter("CATEGORIE", OracleDbType.Char, 3);
                      //    oraCat.Direction = ParameterDirection.Input;
                      //    oraCat.Value = Categories[j]; // On incrémente la catégorie à chaques fois
                      //    oraSelect.Parameters.Add(oraCat);

                      //    OracleDataAdapter orAdater = new OracleDataAdapter(oraSelect);
                      //    if (MonDataSet.Tables.Contains("Score"))
                      //    {
                      //        MonDataSet.Tables["Score"].Clear();
                      //    }
                      //    orAdater.Fill(MonDataSet, "Score");
                      //    oraSelect.Dispose();
                      //}
                  }
                  if (i >= 2)
                  {

                  }
                  if (i >= 3)
                  {

                  }
                  if (i >= 4)
                  {

                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }
          }


      }

      private void TB_AliasJ1_TextChanged(object sender, EventArgs e)
      {
          CheckToEnableCommencer();
          NomJoueur1 = TB_AliasJ1.Text.ToString();
      }

      private void TB_AliasJ2_TextChanged(object sender, EventArgs e)
      {
          CheckToEnableCommencer();
          NomJoueur2 = TB_AliasJ2.Text.ToString();
      }

      private void TB_AliasJ3_TextChanged(object sender, EventArgs e)
      {
          CheckToEnableCommencer();
          NomJoueur3 = TB_AliasJ3.Text.ToString();
      }

      private void TB_AliasJ4_TextChanged(object sender, EventArgs e)
      {
          CheckToEnableCommencer();
          NomJoueur4 = TB_AliasJ4.Text.ToString();
      }

      private void CB_Reprise_CheckedChanged(object sender, EventArgs e)
      {
          Reprise = CB_Reprise.Checked;

         //MessageBox.Show("Fonctionnalité de reprise non implémentée.");

      }
   }
}
