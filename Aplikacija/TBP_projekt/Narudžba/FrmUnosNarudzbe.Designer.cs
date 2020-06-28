namespace TBP_projekt
{
    partial class FrmUnosNarudzbe
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbZaposlenici = new MetroFramework.Controls.MetroComboBox();
            this.cmbDobavljaci = new MetroFramework.Controls.MetroComboBox();
            this.txtNazivArtikla = new MetroFramework.Controls.MetroTextBox();
            this.txtKolicina = new MetroFramework.Controls.MetroTextBox();
            this.dtDatum = new MetroFramework.Controls.MetroDateTime();
            this.txtOpis = new MetroFramework.Controls.MetroTextBox();
            this.btnNaruci = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Zaposlenik";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Dobavljač";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Naziv artikla";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 215);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Količina";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 262);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Datum";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 309);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Opis";
            // 
            // cmbZaposlenici
            // 
            this.cmbZaposlenici.FormattingEnabled = true;
            this.cmbZaposlenici.ItemHeight = 23;
            this.cmbZaposlenici.Location = new System.Drawing.Point(109, 84);
            this.cmbZaposlenici.Name = "cmbZaposlenici";
            this.cmbZaposlenici.Size = new System.Drawing.Size(163, 29);
            this.cmbZaposlenici.TabIndex = 6;
            this.cmbZaposlenici.UseSelectable = true;
            // 
            // cmbDobavljaci
            // 
            this.cmbDobavljaci.FormattingEnabled = true;
            this.cmbDobavljaci.ItemHeight = 23;
            this.cmbDobavljaci.Location = new System.Drawing.Point(109, 125);
            this.cmbDobavljaci.Name = "cmbDobavljaci";
            this.cmbDobavljaci.Size = new System.Drawing.Size(163, 29);
            this.cmbDobavljaci.TabIndex = 7;
            this.cmbDobavljaci.UseSelectable = true;
            // 
            // txtNazivArtikla
            // 
            // 
            // 
            // 
            this.txtNazivArtikla.CustomButton.Image = null;
            this.txtNazivArtikla.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtNazivArtikla.CustomButton.Name = "";
            this.txtNazivArtikla.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNazivArtikla.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNazivArtikla.CustomButton.TabIndex = 1;
            this.txtNazivArtikla.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNazivArtikla.CustomButton.UseSelectable = true;
            this.txtNazivArtikla.CustomButton.Visible = false;
            this.txtNazivArtikla.Lines = new string[0];
            this.txtNazivArtikla.Location = new System.Drawing.Point(109, 177);
            this.txtNazivArtikla.MaxLength = 32767;
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.PasswordChar = '\0';
            this.txtNazivArtikla.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNazivArtikla.SelectedText = "";
            this.txtNazivArtikla.SelectionLength = 0;
            this.txtNazivArtikla.SelectionStart = 0;
            this.txtNazivArtikla.ShortcutsEnabled = true;
            this.txtNazivArtikla.Size = new System.Drawing.Size(163, 23);
            this.txtNazivArtikla.TabIndex = 8;
            this.txtNazivArtikla.UseSelectable = true;
            this.txtNazivArtikla.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNazivArtikla.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKolicina
            // 
            // 
            // 
            // 
            this.txtKolicina.CustomButton.Image = null;
            this.txtKolicina.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtKolicina.CustomButton.Name = "";
            this.txtKolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKolicina.CustomButton.TabIndex = 1;
            this.txtKolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKolicina.CustomButton.UseSelectable = true;
            this.txtKolicina.CustomButton.Visible = false;
            this.txtKolicina.Lines = new string[0];
            this.txtKolicina.Location = new System.Drawing.Point(109, 215);
            this.txtKolicina.MaxLength = 32767;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.PasswordChar = '\0';
            this.txtKolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKolicina.SelectedText = "";
            this.txtKolicina.SelectionLength = 0;
            this.txtKolicina.SelectionStart = 0;
            this.txtKolicina.ShortcutsEnabled = true;
            this.txtKolicina.Size = new System.Drawing.Size(163, 23);
            this.txtKolicina.TabIndex = 9;
            this.txtKolicina.UseSelectable = true;
            this.txtKolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(109, 252);
            this.dtDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(163, 29);
            this.dtDatum.TabIndex = 10;
            // 
            // txtOpis
            // 
            // 
            // 
            // 
            this.txtOpis.CustomButton.Image = null;
            this.txtOpis.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtOpis.CustomButton.Name = "";
            this.txtOpis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOpis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpis.CustomButton.TabIndex = 1;
            this.txtOpis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpis.CustomButton.UseSelectable = true;
            this.txtOpis.CustomButton.Visible = false;
            this.txtOpis.Lines = new string[0];
            this.txtOpis.Location = new System.Drawing.Point(109, 305);
            this.txtOpis.MaxLength = 32767;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.PasswordChar = '\0';
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOpis.SelectedText = "";
            this.txtOpis.SelectionLength = 0;
            this.txtOpis.SelectionStart = 0;
            this.txtOpis.ShortcutsEnabled = true;
            this.txtOpis.Size = new System.Drawing.Size(163, 23);
            this.txtOpis.TabIndex = 11;
            this.txtOpis.UseSelectable = true;
            this.txtOpis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOpis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNaruci
            // 
            this.btnNaruci.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNaruci.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnNaruci.Location = new System.Drawing.Point(109, 363);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(108, 45);
            this.btnNaruci.TabIndex = 12;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseSelectable = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // FrmUnosNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtNazivArtikla);
            this.Controls.Add(this.cmbDobavljaci);
            this.Controls.Add(this.cmbZaposlenici);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmUnosNarudzbe";
            this.Text = "Unos narudžbe";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbZaposlenici;
        private MetroFramework.Controls.MetroComboBox cmbDobavljaci;
        private MetroFramework.Controls.MetroTextBox txtNazivArtikla;
        private MetroFramework.Controls.MetroTextBox txtKolicina;
        private MetroFramework.Controls.MetroDateTime dtDatum;
        private MetroFramework.Controls.MetroTextBox txtOpis;
        private MetroFramework.Controls.MetroButton btnNaruci;
    }
}