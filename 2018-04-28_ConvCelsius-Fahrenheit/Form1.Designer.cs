namespace _2018_04_28_ConvCelsius_Fahrenheit
{
    partial class Form1
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
            this.text_Celsius = new System.Windows.Forms.TextBox();
            this.btn_ConvF = new System.Windows.Forms.Button();
            this.btn_ConvC = new System.Windows.Forms.Button();
            this.text_Far = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gradi Celsius";
            // 
            // text_Celsius
            // 
            this.text_Celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Celsius.Location = new System.Drawing.Point(26, 76);
            this.text_Celsius.Name = "text_Celsius";
            this.text_Celsius.Size = new System.Drawing.Size(100, 30);
            this.text_Celsius.TabIndex = 1;
            this.text_Celsius.Text = "0";
            this.text_Celsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ConvF
            // 
            this.btn_ConvF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConvF.Location = new System.Drawing.Point(26, 139);
            this.btn_ConvF.Name = "btn_ConvF";
            this.btn_ConvF.Size = new System.Drawing.Size(100, 31);
            this.btn_ConvF.TabIndex = 2;
            this.btn_ConvF.Text = "Converti";
            this.btn_ConvF.UseVisualStyleBackColor = true;
            this.btn_ConvF.Click += new System.EventHandler(this.btn_ConvF_Click);
            // 
            // btn_ConvC
            // 
            this.btn_ConvC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConvC.Location = new System.Drawing.Point(168, 139);
            this.btn_ConvC.Name = "btn_ConvC";
            this.btn_ConvC.Size = new System.Drawing.Size(100, 31);
            this.btn_ConvC.TabIndex = 5;
            this.btn_ConvC.Text = "Converti";
            this.btn_ConvC.UseVisualStyleBackColor = true;
            this.btn_ConvC.Click += new System.EventHandler(this.btn_ConvC_Click);
            // 
            // text_Far
            // 
            this.text_Far.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Far.Location = new System.Drawing.Point(168, 76);
            this.text_Far.Name = "text_Far";
            this.text_Far.Size = new System.Drawing.Size(100, 30);
            this.text_Far.TabIndex = 4;
            this.text_Far.Text = "0";
            this.text_Far.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gradi Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 255);
            this.Controls.Add(this.btn_ConvC);
            this.Controls.Add(this.text_Far);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ConvF);
            this.Controls.Add(this.text_Celsius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Celsius;
        private System.Windows.Forms.Button btn_ConvF;
        private System.Windows.Forms.Button btn_ConvC;
        private System.Windows.Forms.TextBox text_Far;
        private System.Windows.Forms.Label label2;
    }
}

