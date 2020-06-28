namespace TBP_projekt
{
    partial class FrmKupci
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.dgvKupci = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panelIzmjena = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnIzmjeni = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNazivIzmjena = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).BeginInit();
            this.panelUnos.SuspendLayout();
            this.panelIzmjena.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            // 
            // 
            // 
            this.txtNaziv.CustomButton.Image = null;
            this.txtNaziv.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtNaziv.CustomButton.Name = "";
            this.txtNaziv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNaziv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.CustomButton.TabIndex = 1;
            this.txtNaziv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.CustomButton.UseSelectable = true;
            this.txtNaziv.CustomButton.Visible = false;
            this.txtNaziv.Lines = new string[0];
            this.txtNaziv.Location = new System.Drawing.Point(12, 72);
            this.txtNaziv.MaxLength = 32767;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.PasswordChar = '\0';
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.SelectionLength = 0;
            this.txtNaziv.SelectionStart = 0;
            this.txtNaziv.ShortcutsEnabled = true;
            this.txtNaziv.Size = new System.Drawing.Size(93, 23);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.UseSelectable = true;
            this.txtNaziv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNaziv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvKupci
            // 
            this.dgvKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupci.Location = new System.Drawing.Point(186, 85);
            this.dgvKupci.Name = "dgvKupci";
            this.dgvKupci.Size = new System.Drawing.Size(245, 165);
            this.dgvKupci.TabIndex = 2;
            this.dgvKupci.SelectionChanged += new System.EventHandler(this.dgvKupci_SelectionChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDodaj.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDodaj.Location = new System.Drawing.Point(12, 125);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(93, 31);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseSelectable = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // panelUnos
            // 
            this.panelUnos.Controls.Add(this.metroLabel2);
            this.panelUnos.Controls.Add(this.btnDodaj);
            this.panelUnos.Controls.Add(this.metroLabel1);
            this.panelUnos.Controls.Add(this.txtNaziv);
            this.panelUnos.Location = new System.Drawing.Point(23, 85);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(134, 171);
            this.panelUnos.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(7, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Unos kupca";
            // 
            // panelIzmjena
            // 
            this.panelIzmjena.Controls.Add(this.metroLabel3);
            this.panelIzmjena.Controls.Add(this.btnIzmjeni);
            this.panelIzmjena.Controls.Add(this.metroLabel4);
            this.panelIzmjena.Controls.Add(this.txtNazivIzmjena);
            this.panelIzmjena.Location = new System.Drawing.Point(23, 85);
            this.panelIzmjena.Name = "panelIzmjena";
            this.panelIzmjena.Size = new System.Drawing.Size(134, 171);
            this.panelIzmjena.TabIndex = 5;
            this.panelIzmjena.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(7, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Izmjena kupca";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIzmjeni.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnIzmjeni.Location = new System.Drawing.Point(12, 125);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(93, 31);
            this.btnIzmjeni.TabIndex = 3;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseSelectable = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Naziv";
            // 
            // txtNazivIzmjena
            // 
            // 
            // 
            // 
            this.txtNazivIzmjena.CustomButton.Image = null;
            this.txtNazivIzmjena.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtNazivIzmjena.CustomButton.Name = "";
            this.txtNazivIzmjena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNazivIzmjena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNazivIzmjena.CustomButton.TabIndex = 1;
            this.txtNazivIzmjena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNazivIzmjena.CustomButton.UseSelectable = true;
            this.txtNazivIzmjena.CustomButton.Visible = false;
            this.txtNazivIzmjena.Lines = new string[0];
            this.txtNazivIzmjena.Location = new System.Drawing.Point(12, 72);
            this.txtNazivIzmjena.MaxLength = 32767;
            this.txtNazivIzmjena.Name = "txtNazivIzmjena";
            this.txtNazivIzmjena.PasswordChar = '\0';
            this.txtNazivIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNazivIzmjena.SelectedText = "";
            this.txtNazivIzmjena.SelectionLength = 0;
            this.txtNazivIzmjena.SelectionStart = 0;
            this.txtNazivIzmjena.ShortcutsEnabled = true;
            this.txtNazivIzmjena.Size = new System.Drawing.Size(93, 23);
            this.txtNazivIzmjena.TabIndex = 1;
            this.txtNazivIzmjena.UseSelectable = true;
            this.txtNazivIzmjena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNazivIzmjena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmKupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 296);
            this.Controls.Add(this.panelIzmjena);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.dgvKupci);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKupci";
            this.Text = "Kupci";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmKupci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).EndInit();
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            this.panelIzmjena.ResumeLayout(false);
            this.panelIzmjena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private System.Windows.Forms.DataGridView dgvKupci;
        private MetroFramework.Controls.MetroButton btnDodaj;
        private System.Windows.Forms.Panel panelUnos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panelIzmjena;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnIzmjeni;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNazivIzmjena;
    }
}