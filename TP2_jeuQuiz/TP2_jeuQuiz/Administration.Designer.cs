namespace TP2_jeuQuiz
{
    partial class Administration
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
         this.GB_MotDePasse = new System.Windows.Forms.GroupBox();
         this.LBL_MotDePasse = new System.Windows.Forms.Label();
         this.TB_MotDePasse = new System.Windows.Forms.TextBox();
         this.GB_Reponses = new System.Windows.Forms.GroupBox();
         this.BTN_InsererReponse = new System.Windows.Forms.Button();
         this.TB_BonneReponse = new System.Windows.Forms.TextBox();
         this.TB_MauvaiseReponse3 = new System.Windows.Forms.TextBox();
         this.TB_MauvaiseReponse2 = new System.Windows.Forms.TextBox();
         this.TB_MauvaiseReponse1 = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.TB_CodeReponse = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.GB_Question = new System.Windows.Forms.GroupBox();
         this.BTN_EffacerReponses = new System.Windows.Forms.Button();
         this.BTN_RemplacerReponses = new System.Windows.Forms.Button();
         this.CB_CodeCatégorie = new System.Windows.Forms.ComboBox();
         this.TB_EnoncerQuestion = new System.Windows.Forms.TextBox();
         this.TB_CodeQuestion = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.BTN_Load = new System.Windows.Forms.Button();
         this.GB_MotDePasse.SuspendLayout();
         this.GB_Reponses.SuspendLayout();
         this.GB_Question.SuspendLayout();
         this.SuspendLayout();
         // 
         // GB_MotDePasse
         // 
         this.GB_MotDePasse.Controls.Add(this.LBL_MotDePasse);
         this.GB_MotDePasse.Controls.Add(this.TB_MotDePasse);
         this.GB_MotDePasse.Location = new System.Drawing.Point(13, 13);
         this.GB_MotDePasse.Name = "GB_MotDePasse";
         this.GB_MotDePasse.Size = new System.Drawing.Size(568, 46);
         this.GB_MotDePasse.TabIndex = 0;
         this.GB_MotDePasse.TabStop = false;
         this.GB_MotDePasse.Text = "Mot de passe";
         // 
         // LBL_MotDePasse
         // 
         this.LBL_MotDePasse.AutoSize = true;
         this.LBL_MotDePasse.Location = new System.Drawing.Point(7, 20);
         this.LBL_MotDePasse.Name = "LBL_MotDePasse";
         this.LBL_MotDePasse.Size = new System.Drawing.Size(349, 13);
         this.LBL_MotDePasse.TabIndex = 1;
         this.LBL_MotDePasse.Text = "Entrez votre mot de passe pour avoir accès aux éléments de cette page:";
         // 
         // TB_MotDePasse
         // 
         this.TB_MotDePasse.Location = new System.Drawing.Point(362, 17);
         this.TB_MotDePasse.Name = "TB_MotDePasse";
         this.TB_MotDePasse.PasswordChar = '*';
         this.TB_MotDePasse.Size = new System.Drawing.Size(100, 20);
         this.TB_MotDePasse.TabIndex = 0;
         this.TB_MotDePasse.TextChanged += new System.EventHandler(this.TB_MotDePasse_TextChanged);
         // 
         // GB_Reponses
         // 
         this.GB_Reponses.Controls.Add(this.BTN_Load);
         this.GB_Reponses.Controls.Add(this.BTN_InsererReponse);
         this.GB_Reponses.Controls.Add(this.TB_BonneReponse);
         this.GB_Reponses.Controls.Add(this.TB_MauvaiseReponse3);
         this.GB_Reponses.Controls.Add(this.TB_MauvaiseReponse2);
         this.GB_Reponses.Controls.Add(this.TB_MauvaiseReponse1);
         this.GB_Reponses.Controls.Add(this.label5);
         this.GB_Reponses.Controls.Add(this.label4);
         this.GB_Reponses.Controls.Add(this.label3);
         this.GB_Reponses.Controls.Add(this.label2);
         this.GB_Reponses.Controls.Add(this.TB_CodeReponse);
         this.GB_Reponses.Controls.Add(this.label1);
         this.GB_Reponses.Location = new System.Drawing.Point(13, 66);
         this.GB_Reponses.Name = "GB_Reponses";
         this.GB_Reponses.Size = new System.Drawing.Size(568, 100);
         this.GB_Reponses.TabIndex = 1;
         this.GB_Reponses.TabStop = false;
         this.GB_Reponses.Text = "Réponses";
         // 
         // BTN_InsererReponse
         // 
         this.BTN_InsererReponse.Enabled = false;
         this.BTN_InsererReponse.Location = new System.Drawing.Point(243, 71);
         this.BTN_InsererReponse.Name = "BTN_InsererReponse";
         this.BTN_InsererReponse.Size = new System.Drawing.Size(75, 23);
         this.BTN_InsererReponse.TabIndex = 10;
         this.BTN_InsererReponse.Text = "Insérer";
         this.BTN_InsererReponse.UseVisualStyleBackColor = true;
         this.BTN_InsererReponse.Click += new System.EventHandler(this.BTN_InsererReponse_Click);
         // 
         // TB_BonneReponse
         // 
         this.TB_BonneReponse.Enabled = false;
         this.TB_BonneReponse.Location = new System.Drawing.Point(450, 40);
         this.TB_BonneReponse.MaxLength = 50;
         this.TB_BonneReponse.Name = "TB_BonneReponse";
         this.TB_BonneReponse.Size = new System.Drawing.Size(112, 20);
         this.TB_BonneReponse.TabIndex = 9;
         this.TB_BonneReponse.TextChanged += new System.EventHandler(this.TB_BonneReponse_TextChanged);
         // 
         // TB_MauvaiseReponse3
         // 
         this.TB_MauvaiseReponse3.Enabled = false;
         this.TB_MauvaiseReponse3.Location = new System.Drawing.Point(224, 40);
         this.TB_MauvaiseReponse3.MaxLength = 50;
         this.TB_MauvaiseReponse3.Name = "TB_MauvaiseReponse3";
         this.TB_MauvaiseReponse3.Size = new System.Drawing.Size(131, 20);
         this.TB_MauvaiseReponse3.TabIndex = 8;
         this.TB_MauvaiseReponse3.TextChanged += new System.EventHandler(this.TB_MauvaiseReponse3_TextChanged);
         // 
         // TB_MauvaiseReponse2
         // 
         this.TB_MauvaiseReponse2.Enabled = false;
         this.TB_MauvaiseReponse2.Location = new System.Drawing.Point(432, 13);
         this.TB_MauvaiseReponse2.MaxLength = 50;
         this.TB_MauvaiseReponse2.Name = "TB_MauvaiseReponse2";
         this.TB_MauvaiseReponse2.Size = new System.Drawing.Size(130, 20);
         this.TB_MauvaiseReponse2.TabIndex = 7;
         this.TB_MauvaiseReponse2.TextChanged += new System.EventHandler(this.TB_MauvaiseReponse2_TextChanged);
         // 
         // TB_MauvaiseReponse1
         // 
         this.TB_MauvaiseReponse1.Enabled = false;
         this.TB_MauvaiseReponse1.Location = new System.Drawing.Point(243, 13);
         this.TB_MauvaiseReponse1.MaxLength = 50;
         this.TB_MauvaiseReponse1.Name = "TB_MauvaiseReponse1";
         this.TB_MauvaiseReponse1.Size = new System.Drawing.Size(112, 20);
         this.TB_MauvaiseReponse1.TabIndex = 6;
         this.TB_MauvaiseReponse1.TextChanged += new System.EventHandler(this.TB_MauvaiseReponse1_TextChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(362, 43);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(82, 13);
         this.label5.TabIndex = 5;
         this.label5.Text = "Bonne réponse:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(154, 43);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(64, 13);
         this.label4.TabIndex = 4;
         this.label4.Text = "Mauv rép 3:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(362, 16);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 13);
         this.label3.TabIndex = 3;
         this.label3.Text = "Mauv rép 2:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(154, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(83, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Mauvaise rép 1:";
         // 
         // TB_CodeReponse
         // 
         this.TB_CodeReponse.Enabled = false;
         this.TB_CodeReponse.Location = new System.Drawing.Point(47, 13);
         this.TB_CodeReponse.MaxLength = 10;
         this.TB_CodeReponse.Name = "TB_CodeReponse";
         this.TB_CodeReponse.Size = new System.Drawing.Size(100, 20);
         this.TB_CodeReponse.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Code:";
         // 
         // GB_Question
         // 
         this.GB_Question.Controls.Add(this.BTN_EffacerReponses);
         this.GB_Question.Controls.Add(this.BTN_RemplacerReponses);
         this.GB_Question.Controls.Add(this.CB_CodeCatégorie);
         this.GB_Question.Controls.Add(this.TB_EnoncerQuestion);
         this.GB_Question.Controls.Add(this.TB_CodeQuestion);
         this.GB_Question.Controls.Add(this.label9);
         this.GB_Question.Controls.Add(this.label8);
         this.GB_Question.Controls.Add(this.label7);
         this.GB_Question.Enabled = false;
         this.GB_Question.Location = new System.Drawing.Point(13, 172);
         this.GB_Question.Name = "GB_Question";
         this.GB_Question.Size = new System.Drawing.Size(568, 102);
         this.GB_Question.TabIndex = 2;
         this.GB_Question.TabStop = false;
         this.GB_Question.Text = "Questions";
         // 
         // BTN_EffacerReponses
         // 
         this.BTN_EffacerReponses.Location = new System.Drawing.Point(284, 68);
         this.BTN_EffacerReponses.Name = "BTN_EffacerReponses";
         this.BTN_EffacerReponses.Size = new System.Drawing.Size(75, 23);
         this.BTN_EffacerReponses.TabIndex = 14;
         this.BTN_EffacerReponses.Text = "Effacer...";
         this.BTN_EffacerReponses.UseVisualStyleBackColor = true;
         this.BTN_EffacerReponses.Click += new System.EventHandler(this.BTN_EffacerReponses_Click_1);
         // 
         // BTN_RemplacerReponses
         // 
         this.BTN_RemplacerReponses.Location = new System.Drawing.Point(192, 68);
         this.BTN_RemplacerReponses.Name = "BTN_RemplacerReponses";
         this.BTN_RemplacerReponses.Size = new System.Drawing.Size(75, 23);
         this.BTN_RemplacerReponses.TabIndex = 13;
         this.BTN_RemplacerReponses.Text = "Remplacer...";
         this.BTN_RemplacerReponses.UseVisualStyleBackColor = true;
         this.BTN_RemplacerReponses.Click += new System.EventHandler(this.BTN_RemplacerReponses_Click_1);
         // 
         // CB_CodeCatégorie
         // 
         this.CB_CodeCatégorie.FormattingEnabled = true;
         this.CB_CodeCatégorie.Items.AddRange(new object[] {
            "Histoire",
            "Sport",
            "Géographie",
            "Art et Culture"});
         this.CB_CodeCatégorie.Location = new System.Drawing.Point(365, 15);
         this.CB_CodeCatégorie.Name = "CB_CodeCatégorie";
         this.CB_CodeCatégorie.Size = new System.Drawing.Size(112, 21);
         this.CB_CodeCatégorie.TabIndex = 11;
         this.CB_CodeCatégorie.Text = "Sport";
         // 
         // TB_EnoncerQuestion
         // 
         this.TB_EnoncerQuestion.Location = new System.Drawing.Point(68, 42);
         this.TB_EnoncerQuestion.MaxLength = 100;
         this.TB_EnoncerQuestion.Name = "TB_EnoncerQuestion";
         this.TB_EnoncerQuestion.Size = new System.Drawing.Size(483, 20);
         this.TB_EnoncerQuestion.TabIndex = 7;
         this.TB_EnoncerQuestion.TextChanged += new System.EventHandler(this.TB_EnoncerQuestion_TextChanged);
         // 
         // TB_CodeQuestion
         // 
         this.TB_CodeQuestion.Enabled = false;
         this.TB_CodeQuestion.Location = new System.Drawing.Point(120, 15);
         this.TB_CodeQuestion.MaxLength = 10;
         this.TB_CodeQuestion.Name = "TB_CodeQuestion";
         this.TB_CodeQuestion.Size = new System.Drawing.Size(112, 20);
         this.TB_CodeQuestion.TabIndex = 5;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(10, 45);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(52, 13);
         this.label9.TabIndex = 3;
         this.label9.Text = "Question:";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(36, 18);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(78, 13);
         this.label8.TabIndex = 2;
         this.label8.Text = "Code question:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(277, 18);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(82, 13);
         this.label7.TabIndex = 1;
         this.label7.Text = "Code catégorie:";
         // 
         // BTN_Load
         // 
         this.BTN_Load.Location = new System.Drawing.Point(47, 43);
         this.BTN_Load.Name = "BTN_Load";
         this.BTN_Load.Size = new System.Drawing.Size(100, 23);
         this.BTN_Load.TabIndex = 11;
         this.BTN_Load.Text = "Load";
         this.BTN_Load.UseVisualStyleBackColor = true;
         this.BTN_Load.Visible = false;
         this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
         // 
         // Administration
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(593, 282);
         this.Controls.Add(this.GB_Question);
         this.Controls.Add(this.GB_Reponses);
         this.Controls.Add(this.GB_MotDePasse);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Administration";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Administration";
         this.GB_MotDePasse.ResumeLayout(false);
         this.GB_MotDePasse.PerformLayout();
         this.GB_Reponses.ResumeLayout(false);
         this.GB_Reponses.PerformLayout();
         this.GB_Question.ResumeLayout(false);
         this.GB_Question.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_MotDePasse;
        private System.Windows.Forms.Label LBL_MotDePasse;
        private System.Windows.Forms.TextBox TB_MotDePasse;
        private System.Windows.Forms.GroupBox GB_Reponses;
        private System.Windows.Forms.GroupBox GB_Question;
        private System.Windows.Forms.TextBox TB_BonneReponse;
        private System.Windows.Forms.TextBox TB_MauvaiseReponse3;
        private System.Windows.Forms.TextBox TB_MauvaiseReponse2;
        private System.Windows.Forms.TextBox TB_MauvaiseReponse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_CodeReponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_EnoncerQuestion;
        private System.Windows.Forms.TextBox TB_CodeQuestion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_InsererReponse;
        private System.Windows.Forms.ComboBox CB_CodeCatégorie;
        private System.Windows.Forms.Button BTN_EffacerReponses;
        private System.Windows.Forms.Button BTN_RemplacerReponses;
        private System.Windows.Forms.Button BTN_Load;
    }
}