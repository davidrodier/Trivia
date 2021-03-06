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
using System.IO;

namespace TP2_jeuQuiz
{
    public partial class Form1 : Form
    {
        public OracleConnection OraConn = new OracleConnection();
        public DataSet MonDataSet = new DataSet();

        public int NombreJoueurs = 0; // Quand c'est 0, y'a pas de partie en ce moment.
        public int JoueurQuiJoue = 1;
        public int NumeroBonneReponse = 0;
        public String NomJoueur1 = "";
        public String NomJoueur2 = "";
        public String NomJoueur3 = "";
        public String NomJoueur4 = "";
        public String Category;
        public int[] ScoreJoueur1 = { 0, 0, 0, 0 };
        public int[] ScoreJoueur2 = { 0, 0, 0, 0 };
        public int[] ScoreJoueur3 = { 0, 0, 0, 0 };
        public int[] ScoreJoueur4 = { 0, 0, 0, 0 };
        public const int SCOREPARCATPOURFINIR = 3;

        public Form1()
        {
            InitializeComponent();
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
         "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string ChaineConnexion = "Data Source = " + Dsource + ";User Id =" + "Rodierda" + "; Password =" + "ORACLE1";

            try
            {
                OraConn.ConnectionString = ChaineConnexion;

                if (OraConn.State.ToString() == "Open")
                {
                    OraConn.Close();
                }
                else
                {
                    OraConn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            OracleCommand oraReset = new OracleCommand("GESTIONJEU", OraConn);
            oraReset.CommandText = "GESTIONJEU.RESETGAME";
            oraReset.CommandType = CommandType.StoredProcedure;

            oraReset.ExecuteNonQuery();
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
            NouvellePartie FenetreNouvellePartie = new NouvellePartie(OraConn, MonDataSet);

            if (FenetreNouvellePartie.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
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

                NomJoueur1 = FenetreNouvellePartie.NomJoueur1.ToString();
                NomJoueur2 = FenetreNouvellePartie.NomJoueur2.ToString();
                NomJoueur3 = FenetreNouvellePartie.NomJoueur3.ToString();
                NomJoueur4 = FenetreNouvellePartie.NomJoueur4.ToString();

                // Faut pas pouvoir stater une nouvelle partie quand y'en a déjà une de partie
                nouvellePartieToolStripMenuItem.Enabled = false;

                // C'est tout le temps le joueur 1 qui commence à jouer
                LBL_NomJoueurQuiJoue.Text = FenetreNouvellePartie.NomJoueur1.ToString();
            }


        }

        private void panneauDadministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OracleCommand oraSelect = new OracleCommand("GESTIONJEU", OraConn);
            oraSelect.CommandText = "GESTIONJEU.SELECTLASTCODE";
            oraSelect.CommandType = CommandType.StoredProcedure;

            OracleParameter oraCursor = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
            oraCursor.Direction = ParameterDirection.ReturnValue;
            oraSelect.Parameters.Add(oraCursor);

            OracleDataAdapter orAdater = new OracleDataAdapter(oraSelect);
            if (MonDataSet.Tables.Contains("NumPlusGrand"))
            {
                MonDataSet.Tables["NumPlusGrand"].Clear();
            }
            orAdater.Fill(MonDataSet, "NumPlusGrand");
            oraSelect.Dispose();

            Administration FenetreAdmin = new Administration(OraConn, MonDataSet, Convert.ToInt32(MonDataSet.Tables["NumPlusGrand"].Rows[0].ItemArray.GetValue(0)));
            FenetreAdmin.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void effacerUnJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EffacerJoueur FenetreEffacerJoueur = new EffacerJoueur(OraConn, MonDataSet);
            FenetreEffacerJoueur.ShowDialog();
        }

        private void GetQuestionCategory(String Categorie)
        {
            OracleCommand oraSelect = new OracleCommand("GESTIONJEU", OraConn);
            oraSelect.CommandText = "GESTIONJEU.SELECTQUESTIONSCATEGORY";
            oraSelect.CommandType = CommandType.StoredProcedure;

            OracleParameter oraCursor = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
            oraCursor.Direction = ParameterDirection.ReturnValue;
            oraSelect.Parameters.Add(oraCursor);

            OracleParameter oraCat = new OracleParameter("CATEGORIE", OracleDbType.Char, 3);
            oraCat.Direction = ParameterDirection.Input;
            oraCat.Value = Categorie;
            oraSelect.Parameters.Add(oraCat);

            OracleDataAdapter orAdater = new OracleDataAdapter(oraSelect);
            if (MonDataSet.Tables.Contains("Question"))
            {
                MonDataSet.Tables["Question"].Clear();
            }
            orAdater.Fill(MonDataSet, "Question");
            oraSelect.Dispose();
        }

        private void GetQuestionNumero(int Numero)
        {
            OracleCommand oraSelect = new OracleCommand("GESTIONJEU", OraConn);
            oraSelect.CommandText = "GESTIONJEU.SELECTQUESTIONNUMERO";
            oraSelect.CommandType = CommandType.StoredProcedure;

            OracleParameter oraCursor = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
            oraCursor.Direction = ParameterDirection.ReturnValue;
            oraSelect.Parameters.Add(oraCursor);

            OracleParameter oraCat = new OracleParameter("NUMERO", OracleDbType.Int32);
            oraCat.Direction = ParameterDirection.Input;
            oraCat.Value = Numero;
            oraSelect.Parameters.Add(oraCat);

            OracleDataAdapter orAdater = new OracleDataAdapter(oraSelect);
            if (MonDataSet.Tables.Contains("QuestionSelectionne"))
            {
                MonDataSet.Tables["QuestionSelectionne"].Clear();
            }
            orAdater.Fill(MonDataSet, "QuestionSelectionne");
            oraSelect.Dispose();
        }

        private void BTN_PigerUneCouleur_Click(object sender, EventArgs e)
        {
            // Faire plein d'affaire random pour la couleur.... 

            Random Randomizateur = new Random();

            // Jouer le son du spin
            System.Media.SoundPlayer playerRoule = new System.Media.SoundPlayer(Properties.Resources.roule);
            playerRoule.PlayLooping();

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

                SpinTime -= Randomizateur.Next(3, 12);
                PNL_CouleurCategorie.Update();
                Thread.Sleep(100);
            }

            playerRoule.Stop();
            BTN_PigerUneCouleur.Enabled = false;

            // Jouer le son de la selection terminée
            System.Media.SoundPlayer playerSelect = new System.Media.SoundPlayer(Properties.Resources.select);
            playerSelect.Play();

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

                GetQuestionCategory("SPR");
                Category = "SPR";

                GB_ChoixDeReponses.Enabled = true;
                GB_Question.Enabled = true;

            }
            else if (PNL_CouleurCategorie.BackColor == Color.Yellow)
            {
                // Couleur Jaune, catég de l'histoire

                GetQuestionCategory("HIS");
                Category = "HIS";

                GB_ChoixDeReponses.Enabled = true;
                GB_Question.Enabled = true;
            }
            else if (PNL_CouleurCategorie.BackColor == Color.Lime)
            {
                // Vert, couleur de la géographie

                GetQuestionCategory("GEO");
                Category = "GEO";

                GB_ChoixDeReponses.Enabled = true;
                GB_Question.Enabled = true;
            }
            else if (PNL_CouleurCategorie.BackColor == Color.Red)
            {
                // Rouge, la couleur de l'art & de la culture

                GetQuestionCategory("ART");
                Category = "ART";

                GB_ChoixDeReponses.Enabled = true;
                GB_Question.Enabled = true;

            }

            if (PNL_CouleurCategorie.BackColor != Color.White)
            {
                ShowQuestion();
            }
        }

        private void ShowQuestion()
        {
            Random QuestionRdm = new Random();

            int CodeQuestion = 0;

            do
            {
                CodeQuestion = QuestionRdm.Next(1, MonDataSet.Tables["Question"].Rows.Count);

                GetQuestionNumero(Convert.ToInt32(MonDataSet.Tables["Question"].Rows[CodeQuestion].ItemArray.GetValue(0)));

                int tmp = QuestionRdm.Next(1, 4);

                LBL_EnonceDeLaQuestion.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(0).ToString();

                // C'est du décalage
                if (tmp == 1)
                {
                    RB_Choix1.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(1).ToString();
                    RB_Choix2.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(3).ToString();
                    RB_Choix3.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(4).ToString();
                    RB_Choix4.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(2).ToString();
                    NumeroBonneReponse = 3;
                }
                else if (tmp == 2)
                {
                    RB_Choix1.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(3).ToString();
                    RB_Choix2.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(1).ToString();
                    RB_Choix3.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(2).ToString();
                    RB_Choix4.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(4).ToString();
                    NumeroBonneReponse = 4;
                }
                else if (tmp == 3)
                {
                    RB_Choix1.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(4).ToString();
                    RB_Choix2.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(3).ToString();
                    RB_Choix3.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(1).ToString();
                    RB_Choix4.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(2).ToString();
                    NumeroBonneReponse = 1;
                }
                else if (tmp == 4)
                {
                    RB_Choix1.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(3).ToString();
                    RB_Choix2.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(4).ToString();
                    RB_Choix3.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(2).ToString();
                    RB_Choix4.Text = MonDataSet.Tables["QuestionSelectionne"].Rows[0].ItemArray.GetValue(1).ToString();
                    NumeroBonneReponse = 2;
                }
            } while (MonDataSet.Tables["Question"].Rows[CodeQuestion].ItemArray.GetValue(2).ToString() != "Y  ");
        }

        private void RB_Sport_CheckedChanged(object sender, EventArgs e)
        {
            PNL_CouleurCategorie.BackColor = Color.Blue;

            RB_Sport.Checked = false;
            GB_ChoixCat.Enabled = false;
            Thread.Sleep(250);
            GB_ChoixCat.Hide();
            Category = "SPR";
            GetQuestionCategory("SPR");

            GB_ChoixDeReponses.Enabled = true;
            GB_Question.Enabled = true;

            ShowQuestion();
        }

        private void RB_Histoire_CheckedChanged(object sender, EventArgs e)
        {
            PNL_CouleurCategorie.BackColor = Color.Yellow;

            RB_Histoire.Checked = false;
            GB_ChoixCat.Enabled = false;
            Thread.Sleep(250);
            GB_ChoixCat.Hide();
            Category = "HIS";
            GetQuestionCategory("HIS");

            GB_ChoixDeReponses.Enabled = true;
            GB_Question.Enabled = true;

            ShowQuestion();
        }

        private void RB_Geographie_CheckedChanged(object sender, EventArgs e)
        {
            PNL_CouleurCategorie.BackColor = Color.Lime;

            RB_Geographie.Checked = false;
            GB_ChoixCat.Enabled = false;
            Thread.Sleep(250);
            GB_ChoixCat.Hide();
            Category = "GEO";
            GetQuestionCategory("GEO");

            GB_ChoixDeReponses.Enabled = true;
            GB_Question.Enabled = true;

            ShowQuestion();
        }

        private void RB_ArtCulture_CheckedChanged(object sender, EventArgs e)
        {
            PNL_CouleurCategorie.BackColor = Color.Red;

            RB_ArtCulture.Checked = false;
            GB_ChoixCat.Enabled = false;
            Thread.Sleep(250);
            GB_ChoixCat.Hide();
            Category = "ART";
            GetQuestionCategory("ART");

            GB_ChoixDeReponses.Enabled = true;
            GB_Question.Enabled = true;

            ShowQuestion();
        }

        private void RB_Choix1_CheckedChanged(object sender, EventArgs e)
        {
            // Choix de réponse 1
            if (NumeroBonneReponse == 1)
            {
                AddPoint();
            }


            GB_ChoixDeReponses.Enabled = false;
            BTN_ProchainTour.Enabled = true;

            SetBackground(1);
        }

        private void RB_Choix2_CheckedChanged(object sender, EventArgs e)
        {
            // Choix de réponse 2
            if (NumeroBonneReponse == 2)
            {
                AddPoint();
            }
            GB_ChoixDeReponses.Enabled = false;
            BTN_ProchainTour.Enabled = true;

            SetBackground(2);
        }

        private void RB_Choix3_CheckedChanged(object sender, EventArgs e)
        {
            // Choix de réponse 3
            if (NumeroBonneReponse == 3)
            {
                AddPoint();
            }
            GB_ChoixDeReponses.Enabled = false;
            BTN_ProchainTour.Enabled = true;

            SetBackground(3);
        }

        private void RB_Choix4_CheckedChanged(object sender, EventArgs e)
        {
            // Choix de réponse 4
            if (NumeroBonneReponse == 4)
            {
                AddPoint();
            }
            GB_ChoixDeReponses.Enabled = false;
            BTN_ProchainTour.Enabled = true;

            SetBackground(4);
        }

        private void SetBackground(int Nb)
        {
            switch (Nb)
            {
                case 1:
                    RB_Choix1.BackColor = Color.LightCoral;
                    break;
                case 2:
                    RB_Choix2.BackColor = Color.LightCoral;
                    break;
                case 3:
                    RB_Choix3.BackColor = Color.LightCoral;
                    break;
                case 4:
                    RB_Choix4.BackColor = Color.LightCoral;
                    break;
            }
            switch (NumeroBonneReponse)
            {
                case 1:
                    RB_Choix1.BackColor = Color.LightGreen;
                    break;
                case 2:
                    RB_Choix2.BackColor = Color.LightGreen;
                    break;
                case 3:
                    RB_Choix3.BackColor = Color.LightGreen;
                    break;
                case 4:
                    RB_Choix4.BackColor = Color.LightGreen;
                    break;
            }
        }

        private void AddPoint()
        {
            if (RB_Choix1.Enabled)
            {
                switch (JoueurQuiJoue)
                {
                    case 1:
                        if (Category == "SPR")
                        {
                            ScoreJoueur1[0]++;
                        }
                        else if (Category == "HIS")
                        {
                            ScoreJoueur1[1]++;
                        }
                        else if (Category == "GEO")
                        {
                            ScoreJoueur1[2]++;
                        }
                        else if (Category == "ART")
                        {
                            ScoreJoueur1[3]++;
                        }

                        LBL_NomJoueurQuiJoue.Text = NomJoueur2;
                        LBL_NomJoueurQuiJoue.Text = NomJoueur1;
                        break;
                    case 2:
                        if (Category == "SPR")
                        {
                            ScoreJoueur2[0]++;
                        }
                        else if (Category == "HIS")
                        {
                            ScoreJoueur2[1]++;
                        }
                        else if (Category == "GEO")
                        {
                            ScoreJoueur2[2]++;
                        }
                        else if (Category == "ART")
                        {
                            ScoreJoueur2[3]++;
                        }

                        LBL_NomJoueurQuiJoue.Text = NomJoueur1;
                        LBL_NomJoueurQuiJoue.Text = NomJoueur2;
                        break;
                    case 3:
                        if (Category == "SPR")
                        {
                            ScoreJoueur3[0]++;
                        }
                        else if (Category == "HIS")
                        {
                            ScoreJoueur3[1]++;
                        }
                        else if (Category == "GEO")
                        {
                            ScoreJoueur3[2]++;
                        }
                        else if (Category == "ART")
                        {
                            ScoreJoueur3[3]++;
                        }

                        LBL_NomJoueurQuiJoue.Text = NomJoueur1;
                        LBL_NomJoueurQuiJoue.Text = NomJoueur3;
                        break;
                    case 4:
                        if (Category == "SPR")
                        {
                            ScoreJoueur4[0]++;
                        }
                        else if (Category == "HIS")
                        {
                            ScoreJoueur4[1]++;
                        }
                        else if (Category == "GEO")
                        {
                            ScoreJoueur4[2]++;
                        }
                        else if (Category == "ART")
                        {
                            ScoreJoueur4[3]++;
                        }

                        LBL_NomJoueurQuiJoue.Text = NomJoueur1;
                        LBL_NomJoueurQuiJoue.Text = NomJoueur4;
                        break;
                }
            }
        }

        private void BTN_ProchainTour_Click(object sender, EventArgs e)
        {
            // On fait ça ici pour faire sûr que le bug est réparé
            if (Convert.ToInt32(LBL_ScoreSport.Text) >= SCOREPARCATPOURFINIR
                && Convert.ToInt32(LBL_ScoreHistoire.Text) >= SCOREPARCATPOURFINIR
                && Convert.ToInt32(LBL_ScoreGeographie.Text) >= SCOREPARCATPOURFINIR
                && Convert.ToInt32(LBL_ScoreArtCulture.Text) >= SCOREPARCATPOURFINIR)
            {
                MessageBox.Show(LBL_NomJoueurQuiJoue.Text.ToString() + " a gagné.");
                Application.Exit();
            }




            NextTurn();
        }

        public void NextTurn()
        {
            if (!(RB_Choix1.Checked && RB_Choix1.BackColor == Color.LightGreen
               || RB_Choix2.Checked && RB_Choix2.BackColor == Color.LightGreen
               || RB_Choix3.Checked && RB_Choix3.BackColor == Color.LightGreen
               || RB_Choix4.Checked && RB_Choix4.BackColor == Color.LightGreen))
            {
                JoueurQuiJoue++;

                if (JoueurQuiJoue > NombreJoueurs)
                    JoueurQuiJoue = 1;

                switch (JoueurQuiJoue)
                {
                    case 1:
                        LBL_NomJoueurQuiJoue.Text = NomJoueur1;
                        break;
                    case 2:
                        LBL_NomJoueurQuiJoue.Text = NomJoueur2;
                        break;
                    case 3:
                        LBL_NomJoueurQuiJoue.Text = NomJoueur3;
                        break;
                    case 4:
                        LBL_NomJoueurQuiJoue.Text = NomJoueur4;
                        break;
                }
            }



            PNL_CouleurCategorie.BackColor = Color.LightBlue;
            LBL_EnonceDeLaQuestion.Text = "Insérez une question ici";
            RB_Choix1.Text = "Choix #1";
            RB_Choix2.Text = "Choix #2";
            RB_Choix3.Text = "Choix #3";
            RB_Choix4.Text = "Choix #4";

            BTN_PigerUneCouleur.Enabled = true;

            RB_Choix1.Checked = false;
            RB_Choix2.Checked = false;
            RB_Choix3.Checked = false;
            RB_Choix4.Checked = false;

            RB_Choix1.BackColor = Color.White;
            RB_Choix2.BackColor = Color.White;
            RB_Choix3.BackColor = Color.White;
            RB_Choix4.BackColor = Color.White;

            BTN_ProchainTour.Enabled = false;

        }

        private void LBL_NomJoueurQuiJoue_TextChanged(object sender, EventArgs e)
        {
            switch (JoueurQuiJoue)
            {
                case 1:
                    LBL_Points.Text = (ScoreJoueur1[0] + ScoreJoueur1[1] + ScoreJoueur1[2] + ScoreJoueur1[3]).ToString();
                    LBL_ScoreSport.Text = ScoreJoueur1[0].ToString();
                    LBL_ScoreHistoire.Text = ScoreJoueur1[1].ToString();
                    LBL_ScoreGeographie.Text = ScoreJoueur1[2].ToString();
                    LBL_ScoreArtCulture.Text = ScoreJoueur1[3].ToString();
                    break;
                case 2:
                    LBL_Points.Text = (ScoreJoueur2[0] + ScoreJoueur2[1] + ScoreJoueur2[2] + ScoreJoueur2[3]).ToString();
                    LBL_ScoreSport.Text = ScoreJoueur2[0].ToString();
                    LBL_ScoreHistoire.Text = ScoreJoueur2[1].ToString();
                    LBL_ScoreGeographie.Text = ScoreJoueur2[2].ToString();
                    LBL_ScoreArtCulture.Text = ScoreJoueur2[3].ToString();
                    break;
                case 3:
                    LBL_Points.Text = (ScoreJoueur3[0] + ScoreJoueur3[1] + ScoreJoueur3[2] + ScoreJoueur3[3]).ToString();
                    LBL_ScoreSport.Text = ScoreJoueur3[0].ToString();
                    LBL_ScoreHistoire.Text = ScoreJoueur3[1].ToString();
                    LBL_ScoreGeographie.Text = ScoreJoueur3[2].ToString();
                    LBL_ScoreArtCulture.Text = ScoreJoueur3[3].ToString();
                    break;
                case 4:
                    LBL_Points.Text = (ScoreJoueur4[0] + ScoreJoueur4[1] + ScoreJoueur4[2] + ScoreJoueur4[3]).ToString();
                    LBL_ScoreSport.Text = ScoreJoueur4[0].ToString();
                    LBL_ScoreHistoire.Text = ScoreJoueur4[1].ToString();
                    LBL_ScoreGeographie.Text = ScoreJoueur4[2].ToString();
                    LBL_ScoreArtCulture.Text = ScoreJoueur4[3].ToString();
                    break;
            }
        }

        private void LBL_Points_TextChanged(object sender, EventArgs e)
        {

        }

        private void PNL_CouleurCategorie_BackColorChanged(object sender, EventArgs e)
        {


            if (PNL_CouleurCategorie.BackColor == Color.White)
            {
                // Faut attendre que la catégorie soit choisie
                LBL_NomCategorie.ForeColor = Color.Black;
                LBL_NomCategorie.Text = "Au choix";

            }
            else if (PNL_CouleurCategorie.BackColor == Color.Blue)
            {
                // Couleur bleue, catégorie des sports 
                LBL_NomCategorie.ForeColor = Color.White;
                LBL_NomCategorie.Text = "Sports";

            }
            else if (PNL_CouleurCategorie.BackColor == Color.Yellow)
            {
                LBL_NomCategorie.ForeColor = Color.Black;
                // Couleur Jaune, catég de l'histoire
                LBL_NomCategorie.Text = "Histoire";
            }
            else if (PNL_CouleurCategorie.BackColor == Color.Lime)
            {
                // Vert, couleur de la géographie
                LBL_NomCategorie.ForeColor = Color.Black;
                LBL_NomCategorie.Text = "Géographie";
            }
            else if (PNL_CouleurCategorie.BackColor == Color.Red)
            {
                LBL_NomCategorie.ForeColor = Color.White;
                // Rouge, la couleur de l'art & de la culture
                LBL_NomCategorie.Text = "Art & Culture";
            }
            else
            {
                LBL_NomCategorie.ForeColor = Color.Black;
                LBL_NomCategorie.Text = "";
            }
        }

        private void LBL_ScoreArtCulture_Click(object sender, EventArgs e)
        {

        }

        private void LBL_Points_Click(object sender, EventArgs e)
        {

        }

        private void LBL_ScoreSport_Click(object sender, EventArgs e)
        {

        }
    }
}
