namespace TP2_jeuQuiz
{
   partial class aPropos
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aPropos));
         this.LBL_TexteInfo = new System.Windows.Forms.Label();
         this.PN_Quiz = new System.Windows.Forms.Panel();
         this.LBL_JeuQuizNom = new System.Windows.Forms.Label();
         this.BTN_Fermer = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // LBL_TexteInfo
         // 
         this.LBL_TexteInfo.Location = new System.Drawing.Point(12, 182);
         this.LBL_TexteInfo.Name = "LBL_TexteInfo";
         this.LBL_TexteInfo.Size = new System.Drawing.Size(192, 65);
         this.LBL_TexteInfo.TabIndex = 0;
         this.LBL_TexteInfo.Text = "Par\r\nAlexandre-Xavier Labonté-Lamoureux\r\net \r\nDavid Rodier";
         this.LBL_TexteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // PN_Quiz
         // 
         this.PN_Quiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PN_Quiz.BackgroundImage")));
         this.PN_Quiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.PN_Quiz.Location = new System.Drawing.Point(56, 22);
         this.PN_Quiz.Name = "PN_Quiz";
         this.PN_Quiz.Size = new System.Drawing.Size(100, 118);
         this.PN_Quiz.TabIndex = 1;
         // 
         // LBL_JeuQuizNom
         // 
         this.LBL_JeuQuizNom.AutoSize = true;
         this.LBL_JeuQuizNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LBL_JeuQuizNom.Location = new System.Drawing.Point(72, 154);
         this.LBL_JeuQuizNom.Name = "LBL_JeuQuizNom";
         this.LBL_JeuQuizNom.Size = new System.Drawing.Size(71, 20);
         this.LBL_JeuQuizNom.TabIndex = 2;
         this.LBL_JeuQuizNom.Text = "Jeu Quiz";
         this.LBL_JeuQuizNom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // BTN_Fermer
         // 
         this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.BTN_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.BTN_Fermer.Location = new System.Drawing.Point(68, 254);
         this.BTN_Fermer.Name = "BTN_Fermer";
         this.BTN_Fermer.Size = new System.Drawing.Size(75, 23);
         this.BTN_Fermer.TabIndex = 3;
         this.BTN_Fermer.Text = "Fermer";
         this.BTN_Fermer.UseVisualStyleBackColor = true;
         // 
         // aPropos
         // 
         this.AcceptButton = this.BTN_Fermer;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.BTN_Fermer;
         this.ClientSize = new System.Drawing.Size(215, 289);
         this.Controls.Add(this.BTN_Fermer);
         this.Controls.Add(this.LBL_JeuQuizNom);
         this.Controls.Add(this.PN_Quiz);
         this.Controls.Add(this.LBL_TexteInfo);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "aPropos";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "À propos";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label LBL_TexteInfo;
      private System.Windows.Forms.Panel PN_Quiz;
      private System.Windows.Forms.Label LBL_JeuQuizNom;
      private System.Windows.Forms.Button BTN_Fermer;
   }
}