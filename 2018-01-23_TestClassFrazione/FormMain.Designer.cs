namespace _2018_01_23_TestClassFrazione
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_fine = new System.Windows.Forms.Button();
            this.text_n1 = new System.Windows.Forms.TextBox();
            this.text_nris = new System.Windows.Forms.TextBox();
            this.text_n2 = new System.Windows.Forms.TextBox();
            this.text_d1 = new System.Windows.Forms.TextBox();
            this.text_d2 = new System.Windows.Forms.TextBox();
            this.text_dris = new System.Windows.Forms.TextBox();
            this.cb_op = new System.Windows.Forms.ComboBox();
            this.btn_ug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frazione 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frazione 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Risultato";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_fine
            // 
            this.btn_fine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fine.Location = new System.Drawing.Point(395, 247);
            this.btn_fine.Name = "btn_fine";
            this.btn_fine.Size = new System.Drawing.Size(75, 29);
            this.btn_fine.TabIndex = 3;
            this.btn_fine.Text = "&Fine";
            this.btn_fine.UseVisualStyleBackColor = true;
            this.btn_fine.Click += new System.EventHandler(this.btn_fine_Click);
            // 
            // text_n1
            // 
            this.text_n1.Location = new System.Drawing.Point(29, 68);
            this.text_n1.Name = "text_n1";
            this.text_n1.Size = new System.Drawing.Size(67, 22);
            this.text_n1.TabIndex = 4;
            this.text_n1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_nris
            // 
            this.text_nris.Location = new System.Drawing.Point(380, 68);
            this.text_nris.Name = "text_nris";
            this.text_nris.Size = new System.Drawing.Size(57, 22);
            this.text_nris.TabIndex = 5;
            this.text_nris.Text = "0";
            this.text_nris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_n2
            // 
            this.text_n2.Location = new System.Drawing.Point(202, 68);
            this.text_n2.Name = "text_n2";
            this.text_n2.Size = new System.Drawing.Size(67, 22);
            this.text_n2.TabIndex = 6;
            this.text_n2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_d1
            // 
            this.text_d1.Location = new System.Drawing.Point(29, 130);
            this.text_d1.Name = "text_d1";
            this.text_d1.Size = new System.Drawing.Size(67, 22);
            this.text_d1.TabIndex = 7;
            this.text_d1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_d2
            // 
            this.text_d2.Location = new System.Drawing.Point(202, 130);
            this.text_d2.Name = "text_d2";
            this.text_d2.Size = new System.Drawing.Size(67, 22);
            this.text_d2.TabIndex = 8;
            this.text_d2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_dris
            // 
            this.text_dris.Location = new System.Drawing.Point(380, 130);
            this.text_dris.Name = "text_dris";
            this.text_dris.Size = new System.Drawing.Size(57, 22);
            this.text_dris.TabIndex = 9;
            this.text_dris.Text = "0";
            this.text_dris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_op
            // 
            this.cb_op.FormattingEnabled = true;
            this.cb_op.Items.AddRange(new object[] {
            "       +",
            "        -",
            "        x",
            "        :"});
            this.cb_op.Location = new System.Drawing.Point(117, 100);
            this.cb_op.Name = "cb_op";
            this.cb_op.Size = new System.Drawing.Size(62, 24);
            this.cb_op.TabIndex = 10;
            // 
            // btn_ug
            // 
            this.btn_ug.BackColor = System.Drawing.Color.White;
            this.btn_ug.Location = new System.Drawing.Point(301, 100);
            this.btn_ug.Name = "btn_ug";
            this.btn_ug.Size = new System.Drawing.Size(54, 23);
            this.btn_ug.TabIndex = 11;
            this.btn_ug.Text = "=";
            this.btn_ug.UseVisualStyleBackColor = false;
            this.btn_ug.Click += new System.EventHandler(this.btn_ug_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 301);
            this.Controls.Add(this.btn_ug);
            this.Controls.Add(this.cb_op);
            this.Controls.Add(this.text_dris);
            this.Controls.Add(this.text_d2);
            this.Controls.Add(this.text_d1);
            this.Controls.Add(this.text_n2);
            this.Controls.Add(this.text_nris);
            this.Controls.Add(this.text_n1);
            this.Controls.Add(this.btn_fine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Test Frazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_fine;
        private System.Windows.Forms.TextBox text_n1;
        private System.Windows.Forms.TextBox text_nris;
        private System.Windows.Forms.TextBox text_n2;
        private System.Windows.Forms.TextBox text_d1;
        private System.Windows.Forms.TextBox text_d2;
        private System.Windows.Forms.TextBox text_dris;
        private System.Windows.Forms.ComboBox cb_op;
        private System.Windows.Forms.Button btn_ug;
    }
}

