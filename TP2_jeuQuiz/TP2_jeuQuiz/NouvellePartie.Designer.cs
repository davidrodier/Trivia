namespace TP2_jeuQuiz
{
    partial class NouvellePartie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_Reprise = new System.Windows.Forms.CheckBox();
            this.GB_NombreDeJoueurs = new System.Windows.Forms.GroupBox();
            this.RB_NJ4 = new System.Windows.Forms.RadioButton();
            this.RB_NJ3 = new System.Windows.Forms.RadioButton();
            this.RB_NJ2 = new System.Windows.Forms.RadioButton();
            this.RB_NJ1 = new System.Windows.Forms.RadioButton();
            this.GB_Pseudo = new System.Windows.Forms.GroupBox();
            this.TB_AliasJ4 = new System.Windows.Forms.TextBox();
            this.TB_AliasJ3 = new System.Windows.Forms.TextBox();
            this.TB_AliasJ2 = new System.Windows.Forms.TextBox();
            this.TB_AliasJ1 = new System.Windows.Forms.TextBox();
            this.LBL_Pseudo4 = new System.Windows.Forms.Label();
            this.LBL_Pseudo3 = new System.Windows.Forms.Label();
            this.LBL_Pseudo2 = new System.Windows.Forms.Label();
            this.LBL_Pseudo1 = new System.Windows.Forms.Label();
            this.BTN_CommencerPartie = new System.Windows.Forms.Button();
            this.GB_NombreDeJoueurs.SuspendLayout();
            this.GB_Pseudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Reprise
            // 
            this.CB_Reprise.AutoSize = true;
            this.CB_Reprise.Location = new System.Drawing.Point(13, 13);
            this.CB_Reprise.Name = "CB_Reprise";
            this.CB_Reprise.Size = new System.Drawing.Size(356, 17);
            this.CB_Reprise.TabIndex = 0;
            this.CB_Reprise.Text = "Reprendre la partie d\'après les scores laissés dans le profil des joueurs";
            this.CB_Reprise.UseVisualStyleBackColor = true;
            this.CB_Reprise.CheckedChanged += new System.EventHandler(this.CB_Reprise_CheckedChanged);
            // 
            // GB_NombreDeJoueurs
            // 
            this.GB_NombreDeJoueurs.Controls.Add(this.RB_NJ4);
            this.GB_NombreDeJoueurs.Controls.Add(this.RB_NJ3);
            this.GB_NombreDeJoueurs.Controls.Add(this.RB_NJ2);
            this.GB_NombreDeJoueurs.Controls.Add(this.RB_NJ1);
            this.GB_NombreDeJoueurs.Location = new System.Drawing.Point(13, 37);
            this.GB_NombreDeJoueurs.Name = "GB_NombreDeJoueurs";
            this.GB_NombreDeJoueurs.Size = new System.Drawing.Size(120, 129);
            this.GB_NombreDeJoueurs.TabIndex = 1;
            this.GB_NombreDeJoueurs.TabStop = false;
            this.GB_NombreDeJoueurs.Text = "Nombre de joueurs";
            // 
            // RB_NJ4
            // 
            this.RB_NJ4.AutoSize = true;
            this.RB_NJ4.Location = new System.Drawing.Point(7, 92);
            this.RB_NJ4.Name = "RB_NJ4";
            this.RB_NJ4.Size = new System.Drawing.Size(94, 17);
            this.RB_NJ4.TabIndex = 3;
            this.RB_NJ4.Text = "Quatre joueurs";
            this.RB_NJ4.UseVisualStyleBackColor = true;
            this.RB_NJ4.CheckedChanged += new System.EventHandler(this.RB_NJ4_CheckedChanged);
            // 
            // RB_NJ3
            // 
            this.RB_NJ3.AutoSize = true;
            this.RB_NJ3.Location = new System.Drawing.Point(7, 68);
            this.RB_NJ3.Name = "RB_NJ3";
            this.RB_NJ3.Size = new System.Drawing.Size(85, 17);
            this.RB_NJ3.TabIndex = 2;
            this.RB_NJ3.Text = "Trois joueurs";
            this.RB_NJ3.UseVisualStyleBackColor = true;
            this.RB_NJ3.CheckedChanged += new System.EventHandler(this.RB_NJ3_CheckedChanged);
            // 
            // RB_NJ2
            // 
            this.RB_NJ2.AutoSize = true;
            this.RB_NJ2.Location = new System.Drawing.Point(7, 44);
            this.RB_NJ2.Name = "RB_NJ2";
            this.RB_NJ2.Size = new System.Drawing.Size(87, 17);
            this.RB_NJ2.TabIndex = 1;
            this.RB_NJ2.Text = "Deux joueurs";
            this.RB_NJ2.UseVisualStyleBackColor = true;
            this.RB_NJ2.CheckedChanged += new System.EventHandler(this.RB_NJ2_CheckedChanged);
            // 
            // RB_NJ1
            // 
            this.RB_NJ1.AutoSize = true;
            this.RB_NJ1.Location = new System.Drawing.Point(7, 20);
            this.RB_NJ1.Name = "RB_NJ1";
            this.RB_NJ1.Size = new System.Drawing.Size(71, 17);
            this.RB_NJ1.TabIndex = 0;
            this.RB_NJ1.Text = "Un joueur";
            this.RB_NJ1.UseVisualStyleBackColor = true;
            this.RB_NJ1.CheckedChanged += new System.EventHandler(this.RB_NJ1_CheckedChanged);
            // 
            // GB_Pseudo
            // 
            this.GB_Pseudo.Controls.Add(this.TB_AliasJ4);
            this.GB_Pseudo.Controls.Add(this.TB_AliasJ3);
            this.GB_Pseudo.Controls.Add(this.TB_AliasJ2);
            this.GB_Pseudo.Controls.Add(this.TB_AliasJ1);
            this.GB_Pseudo.Controls.Add(this.LBL_Pseudo4);
            this.GB_Pseudo.Controls.Add(this.LBL_Pseudo3);
            this.GB_Pseudo.Controls.Add(this.LBL_Pseudo2);
            this.GB_Pseudo.Controls.Add(this.LBL_Pseudo1);
            this.GB_Pseudo.Location = new System.Drawing.Point(140, 37);
            this.GB_Pseudo.Name = "GB_Pseudo";
            this.GB_Pseudo.Size = new System.Drawing.Size(229, 129);
            this.GB_Pseudo.TabIndex = 2;
            this.GB_Pseudo.TabStop = false;
            this.GB_Pseudo.Text = "Pseudonymes";
            // 
            // TB_AliasJ4
            // 
            this.TB_AliasJ4.Enabled = false;
            this.TB_AliasJ4.Location = new System.Drawing.Point(89, 89);
            this.TB_AliasJ4.MaxLength = 20;
            this.TB_AliasJ4.Name = "TB_AliasJ4";
            this.TB_AliasJ4.Size = new System.Drawing.Size(100, 20);
            this.TB_AliasJ4.TabIndex = 7;
            this.TB_AliasJ4.TextChanged += new System.EventHandler(this.TB_AliasJ4_TextChanged);
            // 
            // TB_AliasJ3
            // 
            this.TB_AliasJ3.Enabled = false;
            this.TB_AliasJ3.Location = new System.Drawing.Point(89, 65);
            this.TB_AliasJ3.MaxLength = 20;
            this.TB_AliasJ3.Name = "TB_AliasJ3";
            this.TB_AliasJ3.Size = new System.Drawing.Size(100, 20);
            this.TB_AliasJ3.TabIndex = 6;
            this.TB_AliasJ3.TextChanged += new System.EventHandler(this.TB_AliasJ3_TextChanged);
            // 
            // TB_AliasJ2
            // 
            this.TB_AliasJ2.Enabled = false;
            this.TB_AliasJ2.Location = new System.Drawing.Point(89, 41);
            this.TB_AliasJ2.MaxLength = 20;
            this.TB_AliasJ2.Name = "TB_AliasJ2";
            this.TB_AliasJ2.Size = new System.Drawing.Size(100, 20);
            this.TB_AliasJ2.TabIndex = 5;
            this.TB_AliasJ2.TextChanged += new System.EventHandler(this.TB_AliasJ2_TextChanged);
            // 
            // TB_AliasJ1
            // 
            this.TB_AliasJ1.Enabled = false;
            this.TB_AliasJ1.Location = new System.Drawing.Point(90, 17);
            this.TB_AliasJ1.MaxLength = 20;
            this.TB_AliasJ1.Name = "TB_AliasJ1";
            this.TB_AliasJ1.Size = new System.Drawing.Size(100, 20);
            this.TB_AliasJ1.TabIndex = 4;
            this.TB_AliasJ1.TextChanged += new System.EventHandler(this.TB_AliasJ1_TextChanged);
            // 
            // LBL_Pseudo4
            // 
            this.LBL_Pseudo4.AutoSize = true;
            this.LBL_Pseudo4.Location = new System.Drawing.Point(7, 92);
            this.LBL_Pseudo4.Name = "LBL_Pseudo4";
            this.LBL_Pseudo4.Size = new System.Drawing.Size(76, 13);
            this.LBL_Pseudo4.TabIndex = 3;
            this.LBL_Pseudo4.Text = "Alias Joueur 4:";
            // 
            // LBL_Pseudo3
            // 
            this.LBL_Pseudo3.AutoSize = true;
            this.LBL_Pseudo3.Location = new System.Drawing.Point(7, 68);
            this.LBL_Pseudo3.Name = "LBL_Pseudo3";
            this.LBL_Pseudo3.Size = new System.Drawing.Size(76, 13);
            this.LBL_Pseudo3.TabIndex = 2;
            this.LBL_Pseudo3.Text = "Alias Joueur 3:";
            // 
            // LBL_Pseudo2
            // 
            this.LBL_Pseudo2.AutoSize = true;
            this.LBL_Pseudo2.Location = new System.Drawing.Point(7, 44);
            this.LBL_Pseudo2.Name = "LBL_Pseudo2";
            this.LBL_Pseudo2.Size = new System.Drawing.Size(76, 13);
            this.LBL_Pseudo2.TabIndex = 1;
            this.LBL_Pseudo2.Text = "Alias Joueur 2:";
            // 
            // LBL_Pseudo1
            // 
            this.LBL_Pseudo1.AutoSize = true;
            this.LBL_Pseudo1.Location = new System.Drawing.Point(7, 20);
            this.LBL_Pseudo1.Name = "LBL_Pseudo1";
            this.LBL_Pseudo1.Size = new System.Drawing.Size(76, 13);
            this.LBL_Pseudo1.TabIndex = 0;
            this.LBL_Pseudo1.Text = "Alias Joueur 1:";
            // 
            // BTN_CommencerPartie
            // 
            this.BTN_CommencerPartie.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_CommencerPartie.Enabled = false;
            this.BTN_CommencerPartie.Location = new System.Drawing.Point(101, 172);
            this.BTN_CommencerPartie.Name = "BTN_CommencerPartie";
            this.BTN_CommencerPartie.Size = new System.Drawing.Size(182, 29);
            this.BTN_CommencerPartie.TabIndex = 3;
            this.BTN_CommencerPartie.Text = "Commencer la partie!!!";
            this.BTN_CommencerPartie.UseVisualStyleBackColor = true;
            this.BTN_CommencerPartie.Click += new System.EventHandler(this.BTN_CommencerPartie_Click);
            // 
            // NouvellePartie
            // 
            this.AcceptButton = this.BTN_CommencerPartie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 216);
            this.Controls.Add(this.BTN_CommencerPartie);
            this.Controls.Add(this.GB_Pseudo);
            this.Controls.Add(this.GB_NombreDeJoueurs);
            this.Controls.Add(this.CB_Reprise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NouvellePartie";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle partie";
            this.Load += new System.EventHandler(this.NouvellePartie_Load);
            this.GB_NombreDeJoueurs.ResumeLayout(false);
            this.GB_NombreDeJoueurs.PerformLayout();
            this.GB_Pseudo.ResumeLayout(false);
            this.GB_Pseudo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Reprise;
        private System.Windows.Forms.GroupBox GB_NombreDeJoueurs;
        private System.Windows.Forms.RadioButton RB_NJ4;
        private System.Windows.Forms.RadioButton RB_NJ3;
        private System.Windows.Forms.RadioButton RB_NJ2;
        private System.Windows.Forms.RadioButton RB_NJ1;
        private System.Windows.Forms.GroupBox GB_Pseudo;
        private System.Windows.Forms.TextBox TB_AliasJ4;
        private System.Windows.Forms.TextBox TB_AliasJ3;
        private System.Windows.Forms.TextBox TB_AliasJ2;
        private System.Windows.Forms.TextBox TB_AliasJ1;
        private System.Windows.Forms.Label LBL_Pseudo4;
        private System.Windows.Forms.Label LBL_Pseudo3;
        private System.Windows.Forms.Label LBL_Pseudo2;
        private System.Windows.Forms.Label LBL_Pseudo1;
        private System.Windows.Forms.Button BTN_CommencerPartie;
    }
}