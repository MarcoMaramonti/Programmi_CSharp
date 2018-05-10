using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2018_04_28_ConvCelsius_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Conversione da Celsius a Fahrenheit
        private void btn_ConvF_Click(object sender, EventArgs e)
        {
            float Gradi_C = Convert.ToSingle(text_Celsius.Text);
            float Gradi_F = (Gradi_C * 1.8f) + 32f;
            text_Far.Text = Gradi_F.ToString("0.0");
        }

        //Conversione da Fahrenheit a Celsius
        private void btn_ConvC_Click(object sender, EventArgs e)
        {
            float Gradi_F = Convert.ToSingle(text_Far.Text);
            float Gradi_C = (Gradi_F - 32f) / 1.8f;
            text_Celsius.Text = Gradi_C.ToString("0.0");
        }
    }
}
