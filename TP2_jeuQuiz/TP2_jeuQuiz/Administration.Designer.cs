﻿namespace TP2_jeuQuiz
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
            this.TB_MotDePasse = new System.Windows.Forms.TextBox();
            this.LBL_MotDePasse = new System.Windows.Forms.Label();
            this.GB_Reponses = new System.Windows.Forms.GroupBox();
            this.GB_Question = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_CodeReponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_MauvaiseReponse1 = new System.Windows.Forms.TextBox();
            this.TB_MauvaiseReponse2 = new System.Windows.Forms.TextBox();
            this.TB_MauvaiseReponse3 = new System.Windows.Forms.TextBox();
            this.TB_BonneReponse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_CodeReponsePourQuestion = new System.Windows.Forms.TextBox();
            this.TB_CodeQuestion = new System.Windows.Forms.TextBox();
            this.TB_CodeCategorie = new System.Windows.Forms.TextBox();
            this.TB_EnoncerQuestion = new System.Windows.Forms.TextBox();
            this.BTN_InsererReponse = new System.Windows.Forms.Button();
            this.BTN_RemplacerReponses = new System.Windows.Forms.Button();
            this.BTN_EffacerReponses = new System.Windows.Forms.Button();
            this.BTN_InsererQuestions = new System.Windows.Forms.Button();
            this.BTN_RemplacerQuestion = new System.Windows.Forms.Button();
            this.BTN_EffacerQuestion = new System.Windows.Forms.Button();
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
            // TB_MotDePasse
            // 
            this.TB_MotDePasse.Location = new System.Drawing.Point(362, 17);
            this.TB_MotDePasse.Name = "TB_MotDePasse";
            this.TB_MotDePasse.Size = new System.Drawing.Size(100, 20);
            this.TB_MotDePasse.TabIndex = 0;
            this.TB_MotDePasse.TextChanged += new System.EventHandler(this.TB_MotDePasse_TextChanged);
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
            // GB_Reponses
            // 
            this.GB_Reponses.Controls.Add(this.BTN_EffacerReponses);
            this.GB_Reponses.Controls.Add(this.BTN_RemplacerReponses);
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
            // GB_Question
            // 
            this.GB_Question.Controls.Add(this.BTN_EffacerQuestion);
            this.GB_Question.Controls.Add(this.BTN_RemplacerQuestion);
            this.GB_Question.Controls.Add(this.BTN_InsererQuestions);
            this.GB_Question.Controls.Add(this.TB_EnoncerQuestion);
            this.GB_Question.Controls.Add(this.TB_CodeCategorie);
            this.GB_Question.Controls.Add(this.TB_CodeQuestion);
            this.GB_Question.Controls.Add(this.TB_CodeReponsePourQuestion);
            this.GB_Question.Controls.Add(this.label9);
            this.GB_Question.Controls.Add(this.label8);
            this.GB_Question.Controls.Add(this.label7);
            this.GB_Question.Controls.Add(this.label6);
            this.GB_Question.Location = new System.Drawing.Point(13, 172);
            this.GB_Question.Name = "GB_Question";
            this.GB_Question.Size = new System.Drawing.Size(568, 102);
            this.GB_Question.TabIndex = 2;
            this.GB_Question.TabStop = false;
            this.GB_Question.Text = "Questions";
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
            // TB_CodeReponse
            // 
            this.TB_CodeReponse.Location = new System.Drawing.Point(47, 13);
            this.TB_CodeReponse.MaxLength = 10;
            this.TB_CodeReponse.Name = "TB_CodeReponse";
            this.TB_CodeReponse.Size = new System.Drawing.Size(100, 20);
            this.TB_CodeReponse.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mauv rép 2:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bonne réponse:";
            // 
            // TB_MauvaiseReponse1
            // 
            this.TB_MauvaiseReponse1.Location = new System.Drawing.Point(243, 13);
            this.TB_MauvaiseReponse1.MaxLength = 50;
            this.TB_MauvaiseReponse1.Name = "TB_MauvaiseReponse1";
            this.TB_MauvaiseReponse1.Size = new System.Drawing.Size(112, 20);
            this.TB_MauvaiseReponse1.TabIndex = 6;
            // 
            // TB_MauvaiseReponse2
            // 
            this.TB_MauvaiseReponse2.Location = new System.Drawing.Point(432, 13);
            this.TB_MauvaiseReponse2.MaxLength = 50;
            this.TB_MauvaiseReponse2.Name = "TB_MauvaiseReponse2";
            this.TB_MauvaiseReponse2.Size = new System.Drawing.Size(130, 20);
            this.TB_MauvaiseReponse2.TabIndex = 7;
            // 
            // TB_MauvaiseReponse3
            // 
            this.TB_MauvaiseReponse3.Location = new System.Drawing.Point(224, 40);
            this.TB_MauvaiseReponse3.MaxLength = 50;
            this.TB_MauvaiseReponse3.Name = "TB_MauvaiseReponse3";
            this.TB_MauvaiseReponse3.Size = new System.Drawing.Size(131, 20);
            this.TB_MauvaiseReponse3.TabIndex = 8;
            // 
            // TB_BonneReponse
            // 
            this.TB_BonneReponse.Location = new System.Drawing.Point(450, 40);
            this.TB_BonneReponse.MaxLength = 50;
            this.TB_BonneReponse.Name = "TB_BonneReponse";
            this.TB_BonneReponse.Size = new System.Drawing.Size(112, 20);
            this.TB_BonneReponse.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code réponse:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Code catégorie:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Code question:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Question:";
            // 
            // TB_CodeReponsePourQuestion
            // 
            this.TB_CodeReponsePourQuestion.Location = new System.Drawing.Point(91, 17);
            this.TB_CodeReponsePourQuestion.MaxLength = 10;
            this.TB_CodeReponsePourQuestion.Name = "TB_CodeReponsePourQuestion";
            this.TB_CodeReponsePourQuestion.Size = new System.Drawing.Size(72, 20);
            this.TB_CodeReponsePourQuestion.TabIndex = 4;
            // 
            // TB_CodeQuestion
            // 
            this.TB_CodeQuestion.Location = new System.Drawing.Point(253, 17);
            this.TB_CodeQuestion.MaxLength = 10;
            this.TB_CodeQuestion.Name = "TB_CodeQuestion";
            this.TB_CodeQuestion.Size = new System.Drawing.Size(100, 20);
            this.TB_CodeQuestion.TabIndex = 5;
            // 
            // TB_CodeCategorie
            // 
            this.TB_CodeCategorie.Location = new System.Drawing.Point(450, 17);
            this.TB_CodeCategorie.MaxLength = 10;
            this.TB_CodeCategorie.Name = "TB_CodeCategorie";
            this.TB_CodeCategorie.Size = new System.Drawing.Size(100, 20);
            this.TB_CodeCategorie.TabIndex = 6;
            // 
            // TB_EnoncerQuestion
            // 
            this.TB_EnoncerQuestion.Location = new System.Drawing.Point(67, 41);
            this.TB_EnoncerQuestion.MaxLength = 100;
            this.TB_EnoncerQuestion.Name = "TB_EnoncerQuestion";
            this.TB_EnoncerQuestion.Size = new System.Drawing.Size(483, 20);
            this.TB_EnoncerQuestion.TabIndex = 7;
            // 
            // BTN_InsererReponse
            // 
            this.BTN_InsererReponse.Location = new System.Drawing.Point(130, 71);
            this.BTN_InsererReponse.Name = "BTN_InsererReponse";
            this.BTN_InsererReponse.Size = new System.Drawing.Size(75, 23);
            this.BTN_InsererReponse.TabIndex = 10;
            this.BTN_InsererReponse.Text = "Insérer";
            this.BTN_InsererReponse.UseVisualStyleBackColor = true;
            this.BTN_InsererReponse.Click += new System.EventHandler(this.BTN_InsererReponse_Click);
            // 
            // BTN_RemplacerReponses
            // 
            this.BTN_RemplacerReponses.Location = new System.Drawing.Point(224, 71);
            this.BTN_RemplacerReponses.Name = "BTN_RemplacerReponses";
            this.BTN_RemplacerReponses.Size = new System.Drawing.Size(75, 23);
            this.BTN_RemplacerReponses.TabIndex = 11;
            this.BTN_RemplacerReponses.Text = "Remplacer";
            this.BTN_RemplacerReponses.UseVisualStyleBackColor = true;
            this.BTN_RemplacerReponses.Click += new System.EventHandler(this.BTN_RemplacerReponses_Click);
            // 
            // BTN_EffacerReponses
            // 
            this.BTN_EffacerReponses.Location = new System.Drawing.Point(316, 71);
            this.BTN_EffacerReponses.Name = "BTN_EffacerReponses";
            this.BTN_EffacerReponses.Size = new System.Drawing.Size(75, 23);
            this.BTN_EffacerReponses.TabIndex = 12;
            this.BTN_EffacerReponses.Text = "Effacer";
            this.BTN_EffacerReponses.UseVisualStyleBackColor = true;
            this.BTN_EffacerReponses.Click += new System.EventHandler(this.BTN_EffacerReponses_Click);
            // 
            // BTN_InsererQuestions
            // 
            this.BTN_InsererQuestions.Location = new System.Drawing.Point(130, 67);
            this.BTN_InsererQuestions.Name = "BTN_InsererQuestions";
            this.BTN_InsererQuestions.Size = new System.Drawing.Size(75, 23);
            this.BTN_InsererQuestions.TabIndex = 8;
            this.BTN_InsererQuestions.Text = "Insérer";
            this.BTN_InsererQuestions.UseVisualStyleBackColor = true;
            this.BTN_InsererQuestions.Click += new System.EventHandler(this.BTN_InsererQuestions_Click);
            // 
            // BTN_RemplacerQuestion
            // 
            this.BTN_RemplacerQuestion.Location = new System.Drawing.Point(224, 67);
            this.BTN_RemplacerQuestion.Name = "BTN_RemplacerQuestion";
            this.BTN_RemplacerQuestion.Size = new System.Drawing.Size(75, 23);
            this.BTN_RemplacerQuestion.TabIndex = 9;
            this.BTN_RemplacerQuestion.Text = "Remplacer";
            this.BTN_RemplacerQuestion.UseVisualStyleBackColor = true;
            this.BTN_RemplacerQuestion.Click += new System.EventHandler(this.BTN_RemplacerQuestion_Click);
            // 
            // BTN_EffacerQuestion
            // 
            this.BTN_EffacerQuestion.Location = new System.Drawing.Point(316, 67);
            this.BTN_EffacerQuestion.Name = "BTN_EffacerQuestion";
            this.BTN_EffacerQuestion.Size = new System.Drawing.Size(75, 23);
            this.BTN_EffacerQuestion.TabIndex = 10;
            this.BTN_EffacerQuestion.Text = "Effacer";
            this.BTN_EffacerQuestion.UseVisualStyleBackColor = true;
            this.BTN_EffacerQuestion.Click += new System.EventHandler(this.BTN_EffacerQuestion_Click);
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
        private System.Windows.Forms.TextBox TB_CodeCategorie;
        private System.Windows.Forms.TextBox TB_CodeQuestion;
        private System.Windows.Forms.TextBox TB_CodeReponsePourQuestion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_EffacerReponses;
        private System.Windows.Forms.Button BTN_RemplacerReponses;
        private System.Windows.Forms.Button BTN_InsererReponse;
        private System.Windows.Forms.Button BTN_EffacerQuestion;
        private System.Windows.Forms.Button BTN_RemplacerQuestion;
        private System.Windows.Forms.Button BTN_InsererQuestions;
    }
}