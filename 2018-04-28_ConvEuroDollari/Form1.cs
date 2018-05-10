using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2018_04_28_ConvEuroDollari
{
    public partial class FormMain : Form
    {
        //Definizione costanti
        const float CONV_ED = 1.24f;
        const float CONV_DE = 1f/1.24f;

        public FormMain()
        {
            InitializeComponent();
        }

        //Conversione Euro - Dollari
        private void btn_ConvDollari_Click(object sender, EventArgs e)
        {
            float euro = Convert.ToSingle(text_Euro.Text);
            float dollari = euro * CONV_ED;
            text_Dollari.Text = dollari.ToString();
        }

        //Conversione Dollari - Euro
        private void btn_ConvEuro_Click(object sender, EventArgs e)
        {
            float dollari = Convert.ToSingle(text_Dollari.Text);
            float euro = dollari * CONV_DE;
            text_Euro.Text = euro.ToString("0.00");
        }
    }
}
