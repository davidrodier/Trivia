﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
      public String NomJoueur1 = "";
      public String NomJoueur2 = "";
      public String NomJoueur3 = "";
      public String NomJoueur4 = "";
      public int ScoreJoueur1 = 0;
      public int ScoreJoueur2 = 0;
      public int ScoreJoueur3 = 0;
      public int ScoreJoueur4 = 0; 

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

            GB_SelectionPige.Enabled = true;
            //

            //BTN_ProchainTour.Enabled = true;

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

         }

          // C'est tout le temps le joueur 1 qui commence à jouer
         LBL_NomJoueurQuiJoue.Text = FenetreNouvellePartie.NomJoueur1.ToString();
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

      private void BTN_PigerUneCouleur_Click(object sender, EventArgs e)
      {
          // Faire plein d'affaire random pour la couleur.... 

          Random Randomizateur = new Random();

          int SpinTime = 200;
          int SpinValeur = 0;
          while (SpinTime > 0)
          {
              SpinValeur += Randomizateur.Next(1, 5);

              // Si la valeur est trop haute, on la baisse
              if (SpinValeur >= 5)
                  SpinValeur -= 5;

              if (SpinValeur == 0)
              {
                  PNL_CouleurCategorie.BackColor = Color.White;
              }
              else if (SpinValeur == 1)
              {
                  PNL_CouleurCategorie.BackColor = Color.Blue;
              }
              else if (SpinValeur == 2)
              {
                  PNL_CouleurCategorie.BackColor = Color.Yellow;
              }
              else if (SpinValeur == 3)
              {
                  PNL_CouleurCategorie.BackColor = Color.Lime;
              }
              else if (SpinValeur == 4)
              {
                  PNL_CouleurCategorie.BackColor = Color.Red;
              }

              SpinTime -= Randomizateur.Next(2, 9);
              PNL_CouleurCategorie.Update();
              Thread.Sleep(100);
          }

          BTN_PigerUneCouleur.Enabled = false;

          // Check si la couleur obtenue est le blanc
          if (PNL_CouleurCategorie.BackColor == Color.White)
          {
              GB_ChoixCat.Enabled = true;
              GB_ChoixCat.Show();

              // Faut attendre que la catégorie soit choisie

          }
          else if (PNL_CouleurCategorie.BackColor == Color.Blue)
          { 
               // Couleur bleue, catégorie des sports 

              GB_ChoixDeReponses.Enabled = true;
              GB_Question.Enabled = true;

          }
          else if (PNL_CouleurCategorie.BackColor == Color.Yellow)
          { 
                // Couleur Jaune, catég de l'histoire

              GB_ChoixDeReponses.Enabled = true;
              GB_Question.Enabled = true;
          }
          else if (PNL_CouleurCategorie.BackColor == Color.Lime)
          { 
                // Vert, couleur de la géographie

              GB_ChoixDeReponses.Enabled = true;
              GB_Question.Enabled = true;
          }
          else if (PNL_CouleurCategorie.BackColor == Color.Red)
          { 
            // Rouge, la couleur de l'art & de la culture

              GB_ChoixDeReponses.Enabled = true;
              GB_Question.Enabled = true;

          }
          GetQuestion();
      }

      private void RB_Sport_CheckedChanged(object sender, EventArgs e)
      {
          GB_ChoixCat.Enabled = false;
          Thread.Sleep(250);
          GB_ChoixCat.Hide();
      }

      private void RB_Histoire_CheckedChanged(object sender, EventArgs e)
      {
          GB_ChoixCat.Enabled = false;
          Thread.Sleep(250);
          GB_ChoixCat.Hide();
      }

      private void RB_Geographie_CheckedChanged(object sender, EventArgs e)
      {
          GB_ChoixCat.Enabled = false;
          Thread.Sleep(250);
          GB_ChoixCat.Hide();
      }

      private void RB_ArtCulture_CheckedChanged(object sender, EventArgs e)
      {
          GB_ChoixCat.Enabled = false;
          Thread.Sleep(250);
          GB_ChoixCat.Hide();
      }
   }
}
