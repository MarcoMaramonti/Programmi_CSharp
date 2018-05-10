namespace _2018_04_28_ConvEuroDollari
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
            this.text_Euro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Dollari = new System.Windows.Forms.TextBox();
            this.btn_ConvDollari = new System.Windows.Forms.Button();
            this.btn_ConvEuro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Euro
            // 
            this.text_Euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Euro.Location = new System.Drawing.Point(39, 58);
            this.text_Euro.Name = "text_Euro";
            this.text_Euro.Size = new System.Drawing.Size(100, 34);
            this.text_Euro.TabIndex = 0;
            this.text_Euro.Text = "0";
            this.text_Euro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dollari";
            // 
            // text_Dollari
            // 
            this.text_Dollari.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Dollari.Location = new System.Drawing.Point(185, 58);
            this.text_Dollari.Name = "text_Dollari";
            this.text_Dollari.Size = new System.Drawing.Size(100, 34);
            this.text_Dollari.TabIndex = 2;
            this.text_Dollari.Text = "0";
            this.text_Dollari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ConvDollari
            // 
            this.btn_ConvDollari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConvDollari.Location = new System.Drawing.Point(39, 124);
            this.btn_ConvDollari.Name = "btn_ConvDollari";
            this.btn_ConvDollari.Size = new System.Drawing.Size(100, 33);
            this.btn_ConvDollari.TabIndex = 4;
            this.btn_ConvDollari.Text = "Converti";
            this.btn_ConvDollari.UseVisualStyleBackColor = true;
            this.btn_ConvDollari.Click += new System.EventHandler(this.btn_ConvDollari_Click);
            // 
            // btn_ConvEuro
            // 
            this.btn_ConvEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConvEuro.Location = new System.Drawing.Point(185, 124);
            this.btn_ConvEuro.Name = "btn_ConvEuro";
            this.btn_ConvEuro.Size = new System.Drawing.Size(100, 33);
            this.btn_ConvEuro.TabIndex = 5;
            this.btn_ConvEuro.Text = "Converti";
            this.btn_ConvEuro.UseVisualStyleBackColor = true;
            this.btn_ConvEuro.Click += new System.EventHandler(this.btn_ConvEuro_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 255);
            this.Controls.Add(this.btn_ConvEuro);
            this.Controls.Add(this.btn_ConvDollari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Dollari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Euro);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Euro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Dollari;
        private System.Windows.Forms.Button btn_ConvDollari;
        private System.Windows.Forms.Button btn_ConvEuro;
    }
}

