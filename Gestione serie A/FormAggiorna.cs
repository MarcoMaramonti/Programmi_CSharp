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
    //Delegato alla gestione dell'evento cambia-risultato
    public delegate void CambioRis(int p, int s);

    public partial class FormAggiorna : Form
    {
        int par, sq;

        //Creazione evento 
        public event CambioRis RisultatoCambiato;

        public FormAggiorna()
        {
            InitializeComponent();
        }

        private void btn_casa_Click(object sender, EventArgs e)
        {
            sq = 0;
            AvvertiModifica();
        }

        private void btn_trasf_Click(object sender, EventArgs e)
        {
            sq = 1;
            AvvertiModifica();
        }

        void AvvertiModifica()
        {
            par = Convert.ToInt32(nu_part.Value);

            if (RisultatoCambiato != null)
                RisultatoCambiato(par-1, sq);
        }
    }
}
