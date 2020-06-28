namespace TBP_projekt
{
    partial class FrmRadniNalog
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
            this.dgvPrikazArtikala = new System.Windows.Forms.DataGridView();
            this.cmbArtikli = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnIzdajNalog = new MetroFramework.Controls.MetroButton();
            this.btnPogledajStanje = new MetroFramework.Controls.MetroButton();
            this.dgvRadniNalog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazArtikala
            // 
            this.dgvPrikazArtikala.AllowUserToAddRows = false;
            this.dgvPrikazArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazArtikala.Location = new System.Drawing.Point(43, 129);
            this.dgvPrikazArtikala.Name = "dgvPrikazArtikala";
            this.dgvPrikazArtikala.Size = new System.Drawing.Size(846, 245);
            this.dgvPrikazArtikala.TabIndex = 0;
            this.dgvPrikazArtikala.SelectionChanged += new System.EventHandler(this.dgvPrikazArtikala_SelectionChanged);
            // 
            // cmbArtikli
            // 
            this.cmbArtikli.FormattingEnabled = true;
            this.cmbArtikli.ItemHeight = 23;
            this.cmbArtikli.Location = new System.Drawing.Point(99, 78);
            this.cmbArtikli.Name = "cmbArtikli";
            this.cmbArtikli.Size = new System.Drawing.Size(121, 29);
            this.cmbArtikli.TabIndex = 1;
            this.cmbArtikli.UseSelectable = true;
            this.cmbArtikli.SelectedIndexChanged += new System.EventHandler(this.cmbArtikli_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Artikl";
            // 
            // btnIzdajNalog
            // 
            this.btnIzdajNalog.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIzdajNalog.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnIzdajNalog.Location = new System.Drawing.Point(43, 392);
            this.btnIzdajNalog.Name = "btnIzdajNalog";
            this.btnIzdajNalog.Size = new System.Drawing.Size(129, 41);
            this.btnIzdajNalog.TabIndex = 3;
            this.btnIzdajNalog.Text = "Izdaj nalog";
            this.btnIzdajNalog.UseSelectable = true;
            this.btnIzdajNalog.Click += new System.EventHandler(this.btnIzdajNalog_Click);
            // 
            // btnPogledajStanje
            // 
            this.btnPogledajStanje.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPogledajStanje.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnPogledajStanje.Location = new System.Drawing.Point(740, 392);
            this.btnPogledajStanje.Name = "btnPogledajStanje";
            this.btnPogledajStanje.Size = new System.Drawing.Size(149, 41);
            this.btnPogledajStanje.TabIndex = 15;
            this.btnPogledajStanje.Text = "Pogledaj stanje";
            this.btnPogledajStanje.UseSelectable = true;
            this.btnPogledajStanje.Click += new System.EventHandler(this.btnPogledajStanje_Click);
            // 
            // dgvRadniNalog
            // 
            this.dgvRadniNalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadniNalog.Location = new System.Drawing.Point(43, 460);
            this.dgvRadniNalog.Name = "dgvRadniNalog";
            this.dgvRadniNalog.Size = new System.Drawing.Size(778, 224);
            this.dgvRadniNalog.TabIndex = 16;
            // 
            // FrmRadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 707);
            this.Controls.Add(this.dgvRadniNalog);
            this.Controls.Add(this.btnPogledajStanje);
            this.Controls.Add(this.btnIzdajNalog);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbArtikli);
            this.Controls.Add(this.dgvPrikazArtikala);
            this.Name = "FrmRadniNalog";
            this.Text = "Radni nalog";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazArtikala;
        private MetroFramework.Controls.MetroComboBox cmbArtikli;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnIzdajNalog;
        private MetroFramework.Controls.MetroButton btnPogledajStanje;
        private System.Windows.Forms.DataGridView dgvRadniNalog;
    }
}