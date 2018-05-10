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
    public partial class FormModifica : Form
    {
        public int goal_c, goal_t;

        public FormModifica(int c = 0, int t = 0)
        {
            InitializeComponent();
            goal_c = c;
            goal_t = t;
            nu_goalC.Value = goal_c;
            nu_goalT.Value = goal_t;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            goal_c = Convert.ToInt32(nu_goalC);
            goal_t = Convert.ToInt32(nu_goalT);
        }
    }
}
