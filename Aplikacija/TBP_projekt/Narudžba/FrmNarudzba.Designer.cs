namespace TBP_projekt
{
    partial class FrmNarudzba
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
            this.dgvArtikliZaNarudzbu = new System.Windows.Forms.DataGridView();
            this.btnUnosNarudzbe = new MetroFramework.Controls.MetroButton();
            this.btnPogledajStanje = new MetroFramework.Controls.MetroButton();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliZaNarudzbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikliZaNarudzbu
            // 
            this.dgvArtikliZaNarudzbu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliZaNarudzbu.Location = new System.Drawing.Point(23, 73);
            this.dgvArtikliZaNarudzbu.Name = "dgvArtikliZaNarudzbu";
            this.dgvArtikliZaNarudzbu.Size = new System.Drawing.Size(743, 242);
            this.dgvArtikliZaNarudzbu.TabIndex = 0;
            // 
            // btnUnosNarudzbe
            // 
            this.btnUnosNarudzbe.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUnosNarudzbe.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnUnosNarudzbe.Location = new System.Drawing.Point(23, 323);
            this.btnUnosNarudzbe.Name = "btnUnosNarudzbe";
            this.btnUnosNarudzbe.Size = new System.Drawing.Size(129, 41);
            this.btnUnosNarudzbe.TabIndex = 1;
            this.btnUnosNarudzbe.Text = "Unos narudžbe";
            this.btnUnosNarudzbe.UseSelectable = true;
            this.btnUnosNarudzbe.Click += new System.EventHandler(this.btnUnosNarudzbe_Click);
            // 
            // btnPogledajStanje
            // 
            this.btnPogledajStanje.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPogledajStanje.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnPogledajStanje.Location = new System.Drawing.Point(621, 322);
            this.btnPogledajStanje.Name = "btnPogledajStanje";
            this.btnPogledajStanje.Size = new System.Drawing.Size(149, 41);
            this.btnPogledajStanje.TabIndex = 16;
            this.btnPogledajStanje.Text = "Pogledaj stanje";
            this.btnPogledajStanje.UseSelectable = true;
            this.btnPogledajStanje.Click += new System.EventHandler(this.btnPogledajStanje_Click);
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(24, 401);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.Size = new System.Drawing.Size(746, 229);
            this.dgvNarudzbe.TabIndex = 17;
            // 
            // FrmNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 686);
            this.Controls.Add(this.dgvNarudzbe);
            this.Controls.Add(this.btnPogledajStanje);
            this.Controls.Add(this.btnUnosNarudzbe);
            this.Controls.Add(this.dgvArtikliZaNarudzbu);
            this.Name = "FrmNarudzba";
            this.Resizable = false;
            this.Text = "Narudžba";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliZaNarudzbu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikliZaNarudzbu;
        private MetroFramework.Controls.MetroButton btnUnosNarudzbe;
        private MetroFramework.Controls.MetroButton btnPogledajStanje;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
    }
}