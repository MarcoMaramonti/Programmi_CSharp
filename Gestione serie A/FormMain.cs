using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestione_serie_A
{
    public partial class FormMain : Form
    {
        partite gior = new partite();
        FormAggiorna fg = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void menu_Carica_Click(object sender, EventArgs e)
        {
            gior.carica("Giornata.txt");
            Visualizza();
        }

        void Visualizza()
        {
            list_part.Items.Clear();
            ListViewItem x;
            for (int i = 0; i < gior.ns; i++)
            {
                x = new ListViewItem((i+1).ToString());
                x.SubItems.Add(gior.tab[i, 0].nome);
                x.SubItems.Add(gior.tab[i, 0].goal.ToString());
                x.SubItems.Add(gior.tab[i, 1].goal.ToString());
                x.SubItems.Add(gior.tab[i, 1].nome);
                list_part.Items.Add(x);
            }
        }

        //funzione delegata alla gestione dell'evento aggiorna
        private void Menu_Agg_Click(object sender, EventArgs e)
        {
            if (gior.ns == 0)
            {
                MessageBox.Show("Partite non caricate", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (fg == null)
            {
                fg = new FormAggiorna();
                fg.RisultatoCambiato += AggiornaPartite;
            }
            fg.Show();
        }

        void AggiornaPartite(int r, int c)
        {
            gior.tab[r, c].goal++;
            Visualizza();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (list_part.SelectedIndices.Count == 0)
                return;

            int riga = list_part.SelectedIndices[0];
            FormModifica fm = new FormModifica(gior.tab[riga,0].goal, gior.tab[riga,1].goal);
            fm.ShowDialog();

            gior.tab[riga,0].goal = fm.goal_c;
            gior.tab[riga, 1].goal = fm.goal_t;

            Visualizza();

            list_part.SelectedIndices.Clear();
        }
    }
}
