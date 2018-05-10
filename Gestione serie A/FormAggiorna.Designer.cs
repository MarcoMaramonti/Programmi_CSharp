namespace Gestione_serie_A
{
    partial class FormAggiorna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nu_part = new System.Windows.Forms.NumericUpDown();
            this.btn_casa = new System.Windows.Forms.Button();
            this.btn_trasf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_part)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partita";
            // 
            // nu_part
            // 
            this.nu_part.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nu_part.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_part.Location = new System.Drawing.Point(140, 41);
            this.nu_part.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nu_part.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_part.Name = "nu_part";
            this.nu_part.Size = new System.Drawing.Size(120, 34);
            this.nu_part.TabIndex = 2;
            this.nu_part.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nu_part.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_casa
            // 
            this.btn_casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_casa.Location = new System.Drawing.Point(34, 116);
            this.btn_casa.Name = "btn_casa";
            this.btn_casa.Size = new System.Drawing.Size(90, 34);
            this.btn_casa.TabIndex = 3;
            this.btn_casa.Text = "Gol casa";
            this.btn_casa.UseVisualStyleBackColor = true;
            this.btn_casa.Click += new System.EventHandler(this.btn_casa_Click);
            // 
            // btn_trasf
            // 
            this.btn_trasf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trasf.Location = new System.Drawing.Point(140, 116);
            this.btn_trasf.Name = "btn_trasf";
            this.btn_trasf.Size = new System.Drawing.Size(120, 34);
            this.btn_trasf.TabIndex = 4;
            this.btn_trasf.Text = "Gol trasferta";
            this.btn_trasf.UseVisualStyleBackColor = true;
            this.btn_trasf.Click += new System.EventHandler(this.btn_trasf_Click);
            // 
            // FormAggiorna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 215);
            this.Controls.Add(this.btn_trasf);
            this.Controls.Add(this.btn_casa);
            this.Controls.Add(this.nu_part);
            this.Controls.Add(this.label1);
            this.Name = "FormAggiorna";
            this.Text = "AGGIORNAMENTO";
            ((System.ComponentModel.ISupportInitialize)(this.nu_part)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nu_part;
        private System.Windows.Forms.Button btn_casa;
        private System.Windows.Forms.Button btn_trasf;
    }
}