namespace TP2_jeuQuiz
{
    partial class EffacerJoueur
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
            this.LBL_Effaceur = new System.Windows.Forms.Label();
            this.LBL_EntrezSonNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_AliasSupprimer = new System.Windows.Forms.TextBox();
            this.BTN_Suprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Effaceur
            // 
            this.LBL_Effaceur.Location = new System.Drawing.Point(13, 13);
            this.LBL_Effaceur.Name = "LBL_Effaceur";
            this.LBL_Effaceur.Size = new System.Drawing.Size(259, 62);
            this.LBL_Effaceur.TabIndex = 0;
            this.LBL_Effaceur.Text = "Attention! Si vous supprimez un joueur, son alias sera complètement supprimé. Il " +
    "ne pourra plus reprendre une partie. Ses données personnelles comme son nom et s" +
    "on prénom seront aussi supprimés. ";
            // 
            // LBL_EntrezSonNom
            // 
            this.LBL_EntrezSonNom.Location = new System.Drawing.Point(16, 79);
            this.LBL_EntrezSonNom.Name = "LBL_EntrezSonNom";
            this.LBL_EntrezSonNom.Size = new System.Drawing.Size(256, 46);
            this.LBL_EntrezSonNom.TabIndex = 1;
            this.LBL_EntrezSonNom.Text = "Pour confirmer l\'effacement d\'un joueur, veuillez entrer son nom. Après, apuyez s" +
    "ur \'Suprimer\'. Un joueur effacé est à tout jamais perdu. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alias:";
            // 
            // TB_AliasSupprimer
            // 
            this.TB_AliasSupprimer.Location = new System.Drawing.Point(86, 126);
            this.TB_AliasSupprimer.MaxLength = 20;
            this.TB_AliasSupprimer.Name = "TB_AliasSupprimer";
            this.TB_AliasSupprimer.Size = new System.Drawing.Size(100, 20);
            this.TB_AliasSupprimer.TabIndex = 3;
            // 
            // BTN_Suprimer
            // 
            this.BTN_Suprimer.Location = new System.Drawing.Point(86, 164);
            this.BTN_Suprimer.Name = "BTN_Suprimer";
            this.BTN_Suprimer.Size = new System.Drawing.Size(100, 39);
            this.BTN_Suprimer.TabIndex = 4;
            this.BTN_Suprimer.Text = "SUPRIMER";
            this.BTN_Suprimer.UseVisualStyleBackColor = true;
            this.BTN_Suprimer.Click += new System.EventHandler(this.BTN_Suprimer_Click);
            // 
            // EffacerJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.BTN_Suprimer);
            this.Controls.Add(this.TB_AliasSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_EntrezSonNom);
            this.Controls.Add(this.LBL_Effaceur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EffacerJoueur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Effaceur de joueur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Effaceur;
        private System.Windows.Forms.Label LBL_EntrezSonNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_AliasSupprimer;
        private System.Windows.Forms.Button BTN_Suprimer;
    }
}