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
    public partial class EffacerJoueur : Form
    {
        public EffacerJoueur()
        {
            InitializeComponent();
        }

        private void BTN_Suprimer_Click(object sender, EventArgs e)
        {
            // Commande qui efface le joueur et ses données à partir de son alias (TB_AliasSupprimer)
            // La procedure devrait faire un message d'erreur si le joueur n'existe pas

           MessageBox.Show("Fonctionnalité de suppression d'un joueur non implémentée.");
        }

        private void TB_AliasSupprimer_TextChanged(object sender, EventArgs e)
        {
            // Si la boîte est vide, on peut pas supprimer...
            if (TB_AliasSupprimer.Text.ToString().Length > 0)
            {
                BTN_Suprimer.Enabled = true;
            }
            else
            {
                BTN_Suprimer.Enabled = false;
            }
        }
    }
}
