namespace Gestione_serie_A
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
            this.list_part = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Agg = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Carica = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_part
            // 
            this.list_part.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.list_part.FullRowSelect = true;
            this.list_part.GridLines = true;
            this.list_part.Location = new System.Drawing.Point(51, 51);
            this.list_part.MultiSelect = false;
            this.list_part.Name = "list_part";
            this.list_part.Size = new System.Drawing.Size(413, 249);
            this.list_part.TabIndex = 0;
            this.list_part.UseCompatibleStateImageBehavior = false;
            this.list_part.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Partita";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Squadra casa";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Goal";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Goal";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Squadra trasferta";
            this.columnHeader5.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operazioniToolStripMenuItem
            // 
            this.operazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Carica,
            this.Menu_Agg});
            this.operazioniToolStripMenuItem.Name = "operazioniToolStripMenuItem";
            this.operazioniToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operazioniToolStripMenuItem.Text = "&Operazioni";
            // 
            // Menu_Agg
            // 
            this.Menu_Agg.Name = "Menu_Agg";
            this.Menu_Agg.Size = new System.Drawing.Size(152, 24);
            this.Menu_Agg.Text = "&Aggiorna";
            this.Menu_Agg.Click += new System.EventHandler(this.Menu_Agg_Click);
            // 
            // menu_Carica
            // 
            this.menu_Carica.Name = "menu_Carica";
            this.menu_Carica.Size = new System.Drawing.Size(152, 24);
            this.menu_Carica.Text = "&Carica";
            this.menu_Carica.Click += new System.EventHandler(this.menu_Carica_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(433, 329);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 38);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Chiudi";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mod.Location = new System.Drawing.Point(12, 329);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(94, 38);
            this.btn_mod.TabIndex = 4;
            this.btn_mod.Text = "Modifica";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 379);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.list_part);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "PARTITE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_part;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Agg;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_Carica;
        private System.Windows.Forms.Button btn_mod;
    }
}

