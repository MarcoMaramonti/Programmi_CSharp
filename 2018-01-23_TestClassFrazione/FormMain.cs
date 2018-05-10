using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrazioneName;

namespace _2018_01_23_TestClassFrazione
{
    public partial class FormMain : Form
    {
        Frazione f1, f2, f3;

        public FormMain()
        {
            InitializeComponent();
            cb_op.SelectedIndex = 0; 
        }

        private void btn_fine_Click(object sender, EventArgs e)
        {
            Close();
        }

        //handler bottone uguale
        private void btn_ug_Click(object sender, EventArgs e)
        {
            int n, d, op;

            n = Convert.ToInt32(text_n1.Text);
            d = Convert.ToInt32(text_d1.Text);
            f1 = new Frazione(n, d);

            n = Convert.ToInt32(text_n2.Text);
            d = Convert.ToInt32(text_d2.Text);
            f2 = new Frazione(n, d);

            op = cb_op.SelectedIndex;
            switch (op)
            {
                case 0:   //+
                    f3 = f1 + f2;
                    break;

                case 1:   //-
                    f3 = f1 - f2;
                    break;

                case 2:   //x
                    f3 = f1 * f2;
                    break;

                case 3:   //:
                    f3 = f1 / f2;
                    break;
            }

            text_nris.Text = f3.n.ToString();
            text_dris.Text = f3.d.ToString();
        }
    }
}
