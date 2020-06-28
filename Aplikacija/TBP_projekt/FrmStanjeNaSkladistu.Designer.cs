namespace TBP_projekt
{
    partial class FrmStanjeNaSkladistu
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
            this.dgvStanje = new System.Windows.Forms.DataGridView();
            this.btnNarudzba = new MetroFramework.Controls.MetroButton();
            this.btnRadniNalog = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanje
            // 
            this.dgvStanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanje.Location = new System.Drawing.Point(24, 72);
            this.dgvStanje.Name = "dgvStanje";
            this.dgvStanje.Size = new System.Drawing.Size(744, 304);
            this.dgvStanje.TabIndex = 0;
            // 
            // btnNarudzba
            // 
            this.btnNarudzba.Location = new System.Drawing.Point(24, 383);
            this.btnNarudzba.Name = "btnNarudzba";
            this.btnNarudzba.Size = new System.Drawing.Size(106, 44);
            this.btnNarudzba.TabIndex = 1;
            this.btnNarudzba.Text = "NARUDŽBA";
            this.btnNarudzba.UseSelectable = true;
            this.btnNarudzba.Click += new System.EventHandler(this.btnNarudzba_Click);
            // 
            // btnRadniNalog
            // 
            this.btnRadniNalog.Location = new System.Drawing.Point(654, 382);
            this.btnRadniNalog.Name = "btnRadniNalog";
            this.btnRadniNalog.Size = new System.Drawing.Size(114, 45);
            this.btnRadniNalog.TabIndex = 2;
            this.btnRadniNalog.Text = "RADNI NALOG";
            this.btnRadniNalog.UseSelectable = true;
            this.btnRadniNalog.Click += new System.EventHandler(this.btnRadniNalog_Click);
            // 
            // FrmStanjeNaSkladistu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.btnRadniNalog);
            this.Controls.Add(this.btnNarudzba);
            this.Controls.Add(this.dgvStanje);
            this.Name = "FrmStanjeNaSkladistu";
            this.Text = "Stanje na skladištu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanje;
        private MetroFramework.Controls.MetroButton btnNarudzba;
        private MetroFramework.Controls.MetroButton btnRadniNalog;
    }
}