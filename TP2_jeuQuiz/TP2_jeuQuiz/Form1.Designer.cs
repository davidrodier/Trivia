namespace TP2_jeuQuiz
{
   partial class Form1
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panneauDadministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerUnJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_SelectionPige = new System.Windows.Forms.GroupBox();
            this.LBL_Points = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_PigerUneCouleur = new System.Windows.Forms.Button();
            this.PNL_CouleurCategorie = new System.Windows.Forms.Panel();
            this.LBL_NomJoueurQuiJoue = new System.Windows.Forms.Label();
            this.LBL_Joueur = new System.Windows.Forms.Label();
            this.GB_ChoixCat = new System.Windows.Forms.GroupBox();
            this.LBL_PouvezChoisirVotreCateg = new System.Windows.Forms.Label();
            this.RB_ArtCulture = new System.Windows.Forms.RadioButton();
            this.RB_Geographie = new System.Windows.Forms.RadioButton();
            this.RB_Histoire = new System.Windows.Forms.RadioButton();
            this.RB_Sport = new System.Windows.Forms.RadioButton();
            this.GB_Question = new System.Windows.Forms.GroupBox();
            this.LBL_EnonceDeLaQuestion = new System.Windows.Forms.Label();
            this.GB_ChoixDeReponses = new System.Windows.Forms.GroupBox();
            this.RB_Choix4 = new System.Windows.Forms.RadioButton();
            this.RB_Choix3 = new System.Windows.Forms.RadioButton();
            this.RB_Choix2 = new System.Windows.Forms.RadioButton();
            this.RB_Choix1 = new System.Windows.Forms.RadioButton();
            this.BTN_ProchainTour = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.GB_SelectionPige.SuspendLayout();
            this.GB_ChoixCat.SuspendLayout();
            this.GB_Question.SuspendLayout();
            this.GB_ChoixDeReponses.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouvellePartieToolStripMenuItem.Image")));
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panneauDadministrationToolStripMenuItem,
            this.effacerUnJoueurToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // panneauDadministrationToolStripMenuItem
            // 
            this.panneauDadministrationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("panneauDadministrationToolStripMenuItem.Image")));
            this.panneauDadministrationToolStripMenuItem.Name = "panneauDadministrationToolStripMenuItem";
            this.panneauDadministrationToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.panneauDadministrationToolStripMenuItem.Text = "Panneau d\'administration";
            this.panneauDadministrationToolStripMenuItem.Click += new System.EventHandler(this.panneauDadministrationToolStripMenuItem_Click);
            // 
            // effacerUnJoueurToolStripMenuItem
            // 
            this.effacerUnJoueurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("effacerUnJoueurToolStripMenuItem.Image")));
            this.effacerUnJoueurToolStripMenuItem.Name = "effacerUnJoueurToolStripMenuItem";
            this.effacerUnJoueurToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.effacerUnJoueurToolStripMenuItem.Text = "Effacer un joueur";
            this.effacerUnJoueurToolStripMenuItem.Click += new System.EventHandler(this.effacerUnJoueurToolStripMenuItem_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.àProposToolStripMenuItem.Text = "Info";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.infoToolStripMenuItem.Text = "À propos";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // GB_SelectionPige
            // 
            this.GB_SelectionPige.Controls.Add(this.LBL_Points);
            this.GB_SelectionPige.Controls.Add(this.label1);
            this.GB_SelectionPige.Controls.Add(this.BTN_PigerUneCouleur);
            this.GB_SelectionPige.Controls.Add(this.PNL_CouleurCategorie);
            this.GB_SelectionPige.Controls.Add(this.LBL_NomJoueurQuiJoue);
            this.GB_SelectionPige.Controls.Add(this.LBL_Joueur);
            this.GB_SelectionPige.Enabled = false;
            this.GB_SelectionPige.Location = new System.Drawing.Point(13, 28);
            this.GB_SelectionPige.Name = "GB_SelectionPige";
            this.GB_SelectionPige.Size = new System.Drawing.Size(191, 188);
            this.GB_SelectionPige.TabIndex = 1;
            this.GB_SelectionPige.TabStop = false;
            this.GB_SelectionPige.Text = "Sélectionneur";
            // 
            // LBL_Points
            // 
            this.LBL_Points.AutoSize = true;
            this.LBL_Points.Location = new System.Drawing.Point(49, 38);
            this.LBL_Points.Name = "LBL_Points";
            this.LBL_Points.Size = new System.Drawing.Size(36, 13);
            this.LBL_Points.TabIndex = 5;
            this.LBL_Points.Text = "Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            // 
            // BTN_PigerUneCouleur
            // 
            this.BTN_PigerUneCouleur.Location = new System.Drawing.Point(34, 146);
            this.BTN_PigerUneCouleur.Name = "BTN_PigerUneCouleur";
            this.BTN_PigerUneCouleur.Size = new System.Drawing.Size(123, 23);
            this.BTN_PigerUneCouleur.TabIndex = 3;
            this.BTN_PigerUneCouleur.Text = "Piger une couleur";
            this.BTN_PigerUneCouleur.UseVisualStyleBackColor = true;
            this.BTN_PigerUneCouleur.Click += new System.EventHandler(this.BTN_PigerUneCouleur_Click);
            // 
            // PNL_CouleurCategorie
            // 
            this.PNL_CouleurCategorie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PNL_CouleurCategorie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PNL_CouleurCategorie.Location = new System.Drawing.Point(34, 54);
            this.PNL_CouleurCategorie.Name = "PNL_CouleurCategorie";
            this.PNL_CouleurCategorie.Size = new System.Drawing.Size(123, 86);
            this.PNL_CouleurCategorie.TabIndex = 2;
            // 
            // LBL_NomJoueurQuiJoue
            // 
            this.LBL_NomJoueurQuiJoue.AutoSize = true;
            this.LBL_NomJoueurQuiJoue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NomJoueurQuiJoue.Location = new System.Drawing.Point(105, 22);
            this.LBL_NomJoueurQuiJoue.Name = "LBL_NomJoueurQuiJoue";
            this.LBL_NomJoueurQuiJoue.Size = new System.Drawing.Size(43, 13);
            this.LBL_NomJoueurQuiJoue.TabIndex = 1;
            this.LBL_NomJoueurQuiJoue.Text = "Pseudo";
            this.LBL_NomJoueurQuiJoue.Click += new System.EventHandler(this.LBL_NumeroJoueurQuiJoue_Click);
            // 
            // LBL_Joueur
            // 
            this.LBL_Joueur.AutoSize = true;
            this.LBL_Joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Joueur.Location = new System.Drawing.Point(7, 20);
            this.LBL_Joueur.Name = "LBL_Joueur";
            this.LBL_Joueur.Size = new System.Drawing.Size(102, 16);
            this.LBL_Joueur.TabIndex = 0;
            this.LBL_Joueur.Text = "Joueur qui joue:";
            // 
            // GB_ChoixCat
            // 
            this.GB_ChoixCat.Controls.Add(this.LBL_PouvezChoisirVotreCateg);
            this.GB_ChoixCat.Controls.Add(this.RB_ArtCulture);
            this.GB_ChoixCat.Controls.Add(this.RB_Geographie);
            this.GB_ChoixCat.Controls.Add(this.RB_Histoire);
            this.GB_ChoixCat.Controls.Add(this.RB_Sport);
            this.GB_ChoixCat.Enabled = false;
            this.GB_ChoixCat.Location = new System.Drawing.Point(211, 28);
            this.GB_ChoixCat.Name = "GB_ChoixCat";
            this.GB_ChoixCat.Size = new System.Drawing.Size(220, 188);
            this.GB_ChoixCat.TabIndex = 2;
            this.GB_ChoixCat.TabStop = false;
            this.GB_ChoixCat.Text = "Choix catégorie";
            this.GB_ChoixCat.Visible = false;
            // 
            // LBL_PouvezChoisirVotreCateg
            // 
            this.LBL_PouvezChoisirVotreCateg.AutoSize = true;
            this.LBL_PouvezChoisirVotreCateg.Location = new System.Drawing.Point(19, 146);
            this.LBL_PouvezChoisirVotreCateg.Name = "LBL_PouvezChoisirVotreCateg";
            this.LBL_PouvezChoisirVotreCateg.Size = new System.Drawing.Size(185, 13);
            this.LBL_PouvezChoisirVotreCateg.TabIndex = 4;
            this.LBL_PouvezChoisirVotreCateg.Text = "Vous pouvez choisir votre catégorie...";
            // 
            // RB_ArtCulture
            // 
            this.RB_ArtCulture.AutoSize = true;
            this.RB_ArtCulture.Location = new System.Drawing.Point(19, 100);
            this.RB_ArtCulture.Name = "RB_ArtCulture";
            this.RB_ArtCulture.Size = new System.Drawing.Size(85, 17);
            this.RB_ArtCulture.TabIndex = 3;
            this.RB_ArtCulture.TabStop = true;
            this.RB_ArtCulture.Text = "Art et culture";
            this.RB_ArtCulture.UseVisualStyleBackColor = true;
            this.RB_ArtCulture.CheckedChanged += new System.EventHandler(this.RB_ArtCulture_CheckedChanged);
            // 
            // RB_Geographie
            // 
            this.RB_Geographie.AutoSize = true;
            this.RB_Geographie.Location = new System.Drawing.Point(19, 77);
            this.RB_Geographie.Name = "RB_Geographie";
            this.RB_Geographie.Size = new System.Drawing.Size(80, 17);
            this.RB_Geographie.TabIndex = 2;
            this.RB_Geographie.TabStop = true;
            this.RB_Geographie.Text = "Géographie";
            this.RB_Geographie.UseVisualStyleBackColor = true;
            this.RB_Geographie.CheckedChanged += new System.EventHandler(this.RB_Geographie_CheckedChanged);
            // 
            // RB_Histoire
            // 
            this.RB_Histoire.AutoSize = true;
            this.RB_Histoire.Location = new System.Drawing.Point(19, 54);
            this.RB_Histoire.Name = "RB_Histoire";
            this.RB_Histoire.Size = new System.Drawing.Size(60, 17);
            this.RB_Histoire.TabIndex = 1;
            this.RB_Histoire.TabStop = true;
            this.RB_Histoire.Text = "Histoire";
            this.RB_Histoire.UseVisualStyleBackColor = true;
            this.RB_Histoire.CheckedChanged += new System.EventHandler(this.RB_Histoire_CheckedChanged);
            // 
            // RB_Sport
            // 
            this.RB_Sport.AutoSize = true;
            this.RB_Sport.Location = new System.Drawing.Point(19, 31);
            this.RB_Sport.Name = "RB_Sport";
            this.RB_Sport.Size = new System.Drawing.Size(50, 17);
            this.RB_Sport.TabIndex = 0;
            this.RB_Sport.TabStop = true;
            this.RB_Sport.Text = "Sport";
            this.RB_Sport.UseVisualStyleBackColor = true;
            this.RB_Sport.CheckedChanged += new System.EventHandler(this.RB_Sport_CheckedChanged);
            // 
            // GB_Question
            // 
            this.GB_Question.Controls.Add(this.LBL_EnonceDeLaQuestion);
            this.GB_Question.Enabled = false;
            this.GB_Question.Location = new System.Drawing.Point(13, 223);
            this.GB_Question.Name = "GB_Question";
            this.GB_Question.Size = new System.Drawing.Size(419, 43);
            this.GB_Question.TabIndex = 3;
            this.GB_Question.TabStop = false;
            this.GB_Question.Text = "Question";
            // 
            // LBL_EnonceDeLaQuestion
            // 
            this.LBL_EnonceDeLaQuestion.AutoSize = true;
            this.LBL_EnonceDeLaQuestion.Location = new System.Drawing.Point(10, 19);
            this.LBL_EnonceDeLaQuestion.Name = "LBL_EnonceDeLaQuestion";
            this.LBL_EnonceDeLaQuestion.Size = new System.Drawing.Size(118, 13);
            this.LBL_EnonceDeLaQuestion.TabIndex = 0;
            this.LBL_EnonceDeLaQuestion.Text = "Insérez une question ici";
            // 
            // GB_ChoixDeReponses
            // 
            this.GB_ChoixDeReponses.Controls.Add(this.RB_Choix4);
            this.GB_ChoixDeReponses.Controls.Add(this.RB_Choix3);
            this.GB_ChoixDeReponses.Controls.Add(this.RB_Choix2);
            this.GB_ChoixDeReponses.Controls.Add(this.RB_Choix1);
            this.GB_ChoixDeReponses.Enabled = false;
            this.GB_ChoixDeReponses.Location = new System.Drawing.Point(13, 273);
            this.GB_ChoixDeReponses.Name = "GB_ChoixDeReponses";
            this.GB_ChoixDeReponses.Size = new System.Drawing.Size(418, 118);
            this.GB_ChoixDeReponses.TabIndex = 4;
            this.GB_ChoixDeReponses.TabStop = false;
            this.GB_ChoixDeReponses.Text = "Choix de réponses";
            // 
            // RB_Choix4
            // 
            this.RB_Choix4.AutoSize = true;
            this.RB_Choix4.Location = new System.Drawing.Point(13, 89);
            this.RB_Choix4.Name = "RB_Choix4";
            this.RB_Choix4.Size = new System.Drawing.Size(67, 17);
            this.RB_Choix4.TabIndex = 3;
            this.RB_Choix4.TabStop = true;
            this.RB_Choix4.Text = "Choix #4";
            this.RB_Choix4.UseVisualStyleBackColor = true;
            // 
            // RB_Choix3
            // 
            this.RB_Choix3.AutoSize = true;
            this.RB_Choix3.Location = new System.Drawing.Point(13, 66);
            this.RB_Choix3.Name = "RB_Choix3";
            this.RB_Choix3.Size = new System.Drawing.Size(67, 17);
            this.RB_Choix3.TabIndex = 2;
            this.RB_Choix3.TabStop = true;
            this.RB_Choix3.Text = "Choix #3";
            this.RB_Choix3.UseVisualStyleBackColor = true;
            // 
            // RB_Choix2
            // 
            this.RB_Choix2.AutoSize = true;
            this.RB_Choix2.Location = new System.Drawing.Point(13, 43);
            this.RB_Choix2.Name = "RB_Choix2";
            this.RB_Choix2.Size = new System.Drawing.Size(67, 17);
            this.RB_Choix2.TabIndex = 1;
            this.RB_Choix2.TabStop = true;
            this.RB_Choix2.Text = "Choix #2";
            this.RB_Choix2.UseVisualStyleBackColor = true;
            // 
            // RB_Choix1
            // 
            this.RB_Choix1.AutoSize = true;
            this.RB_Choix1.Location = new System.Drawing.Point(13, 20);
            this.RB_Choix1.Name = "RB_Choix1";
            this.RB_Choix1.Size = new System.Drawing.Size(67, 17);
            this.RB_Choix1.TabIndex = 0;
            this.RB_Choix1.TabStop = true;
            this.RB_Choix1.Text = "Choix #1";
            this.RB_Choix1.UseVisualStyleBackColor = true;
            // 
            // BTN_ProchainTour
            // 
            this.BTN_ProchainTour.Enabled = false;
            this.BTN_ProchainTour.Location = new System.Drawing.Point(315, 380);
            this.BTN_ProchainTour.Name = "BTN_ProchainTour";
            this.BTN_ProchainTour.Size = new System.Drawing.Size(128, 23);
            this.BTN_ProchainTour.TabIndex = 4;
            this.BTN_ProchainTour.Text = "Passer au prochain tour";
            this.BTN_ProchainTour.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 403);
            this.Controls.Add(this.BTN_ProchainTour);
            this.Controls.Add(this.GB_ChoixDeReponses);
            this.Controls.Add(this.GB_Question);
            this.Controls.Add(this.GB_ChoixCat);
            this.Controls.Add(this.GB_SelectionPige);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jeu Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GB_SelectionPige.ResumeLayout(false);
            this.GB_SelectionPige.PerformLayout();
            this.GB_ChoixCat.ResumeLayout(false);
            this.GB_ChoixCat.PerformLayout();
            this.GB_Question.ResumeLayout(false);
            this.GB_Question.PerformLayout();
            this.GB_ChoixDeReponses.ResumeLayout(false);
            this.GB_ChoixDeReponses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
      private System.Windows.Forms.GroupBox GB_SelectionPige;
      private System.Windows.Forms.Label LBL_NomJoueurQuiJoue;
      private System.Windows.Forms.Label LBL_Joueur;
      private System.Windows.Forms.Button BTN_PigerUneCouleur;
      private System.Windows.Forms.Panel PNL_CouleurCategorie;
      private System.Windows.Forms.GroupBox GB_ChoixCat;
      private System.Windows.Forms.RadioButton RB_ArtCulture;
      private System.Windows.Forms.RadioButton RB_Geographie;
      private System.Windows.Forms.RadioButton RB_Histoire;
      private System.Windows.Forms.RadioButton RB_Sport;
      private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
      private System.Windows.Forms.Label LBL_PouvezChoisirVotreCateg;
      private System.Windows.Forms.GroupBox GB_Question;
      private System.Windows.Forms.Label LBL_EnonceDeLaQuestion;
      private System.Windows.Forms.GroupBox GB_ChoixDeReponses;
      private System.Windows.Forms.RadioButton RB_Choix4;
      private System.Windows.Forms.RadioButton RB_Choix3;
      private System.Windows.Forms.RadioButton RB_Choix2;
      private System.Windows.Forms.RadioButton RB_Choix1;
      private System.Windows.Forms.Button BTN_ProchainTour;
      private System.Windows.Forms.ToolStripMenuItem panneauDadministrationToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem effacerUnJoueurToolStripMenuItem;
      private System.Windows.Forms.Label LBL_Points;
      private System.Windows.Forms.Label label1;
   }
}

