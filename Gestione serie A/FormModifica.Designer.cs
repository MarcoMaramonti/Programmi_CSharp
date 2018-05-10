namespace Gestione_serie_A
{
    partial class FormModifica
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.nu_goalC = new System.Windows.Forms.NumericUpDown();
            this.nu_goalT = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nu_goalC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_goalT)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(245, 52);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(78, 30);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // nu_goalC
            // 
            this.nu_goalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_goalC.Location = new System.Drawing.Point(19, 52);
            this.nu_goalC.Name = "nu_goalC";
            this.nu_goalC.Size = new System.Drawing.Size(78, 30);
            this.nu_goalC.TabIndex = 1;
            this.nu_goalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nu_goalT
            // 
            this.nu_goalT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_goalT.Location = new System.Drawing.Point(119, 52);
            this.nu_goalT.Name = "nu_goalT";
            this.nu_goalT.Size = new System.Drawing.Size(78, 30);
            this.nu_goalT.TabIndex = 2;
            this.nu_goalT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 129);
            this.Controls.Add(this.nu_goalT);
            this.Controls.Add(this.nu_goalC);
            this.Controls.Add(this.btn_ok);
            this.Name = "FormModifica";
            this.Text = "MODIFICA";
            ((System.ComponentModel.ISupportInitialize)(this.nu_goalC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_goalT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.NumericUpDown nu_goalC;
        private System.Windows.Forms.NumericUpDown nu_goalT;
    }
}