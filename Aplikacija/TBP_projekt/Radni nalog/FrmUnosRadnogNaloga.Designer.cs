namespace TBP_projekt
{
    partial class FrmUnosRadnogNaloga
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
            this.txtArtikl = new MetroFramework.Controls.MetroTextBox();
            this.cmbZaposlenik = new MetroFramework.Controls.MetroComboBox();
            this.cmbKupac = new MetroFramework.Controls.MetroComboBox();
            this.dtDatum = new MetroFramework.Controls.MetroDateTime();
            this.txtKolicina = new MetroFramework.Controls.MetroTextBox();
            this.btnIzdajNalog = new MetroFramework.Controls.MetroButton();
            this.txtOpis = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Zaposlenik";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Naziv artikla";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 227);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Kupac";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(44, 277);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Datum";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(44, 333);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Količina";
            // 
            // txtArtikl
            // 
            // 
            // 
            // 
            this.txtArtikl.CustomButton.Image = null;
            this.txtArtikl.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtArtikl.CustomButton.Name = "";
            this.txtArtikl.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtArtikl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArtikl.CustomButton.TabIndex = 1;
            this.txtArtikl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArtikl.CustomButton.UseSelectable = true;
            this.txtArtikl.CustomButton.Visible = false;
            this.txtArtikl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtArtikl.Lines = new string[0];
            this.txtArtikl.Location = new System.Drawing.Point(133, 169);
            this.txtArtikl.MaxLength = 32767;
            this.txtArtikl.Multiline = true;
            this.txtArtikl.Name = "txtArtikl";
            this.txtArtikl.PasswordChar = '\0';
            this.txtArtikl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArtikl.SelectedText = "";
            this.txtArtikl.SelectionLength = 0;
            this.txtArtikl.SelectionStart = 0;
            this.txtArtikl.ShortcutsEnabled = true;
            this.txtArtikl.Size = new System.Drawing.Size(169, 29);
            this.txtArtikl.TabIndex = 6;
            this.txtArtikl.UseSelectable = true;
            this.txtArtikl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArtikl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.ItemHeight = 23;
            this.cmbZaposlenik.Location = new System.Drawing.Point(133, 116);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(169, 29);
            this.cmbZaposlenik.TabIndex = 7;
            this.cmbZaposlenik.UseSelectable = true;
            // 
            // cmbKupac
            // 
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.ItemHeight = 23;
            this.cmbKupac.Location = new System.Drawing.Point(133, 227);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(169, 29);
            this.cmbKupac.TabIndex = 8;
            this.cmbKupac.UseSelectable = true;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(133, 277);
            this.dtDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(169, 29);
            this.dtDatum.TabIndex = 11;
            // 
            // txtKolicina
            // 
            // 
            // 
            // 
            this.txtKolicina.CustomButton.Image = null;
            this.txtKolicina.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtKolicina.CustomButton.Name = "";
            this.txtKolicina.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtKolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKolicina.CustomButton.TabIndex = 1;
            this.txtKolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKolicina.CustomButton.UseSelectable = true;
            this.txtKolicina.CustomButton.Visible = false;
            this.txtKolicina.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKolicina.Lines = new string[0];
            this.txtKolicina.Location = new System.Drawing.Point(133, 333);
            this.txtKolicina.MaxLength = 32767;
            this.txtKolicina.Multiline = true;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.PasswordChar = '\0';
            this.txtKolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKolicina.SelectedText = "";
            this.txtKolicina.SelectionLength = 0;
            this.txtKolicina.SelectionStart = 0;
            this.txtKolicina.ShortcutsEnabled = true;
            this.txtKolicina.Size = new System.Drawing.Size(169, 29);
            this.txtKolicina.TabIndex = 12;
            this.txtKolicina.UseSelectable = true;
            this.txtKolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIzdajNalog
            // 
            this.btnIzdajNalog.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIzdajNalog.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnIzdajNalog.Location = new System.Drawing.Point(150, 424);
            this.btnIzdajNalog.Name = "btnIzdajNalog";
            this.btnIzdajNalog.Size = new System.Drawing.Size(94, 41);
            this.btnIzdajNalog.TabIndex = 13;
            this.btnIzdajNalog.Text = "Potvrdi";
            this.btnIzdajNalog.UseSelectable = true;
            this.btnIzdajNalog.Click += new System.EventHandler(this.btnIzdajNalog_Click);
            // 
            // txtOpis
            // 
            // 
            // 
            // 
            this.txtOpis.CustomButton.Image = null;
            this.txtOpis.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtOpis.CustomButton.Name = "";
            this.txtOpis.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtOpis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpis.CustomButton.TabIndex = 1;
            this.txtOpis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpis.CustomButton.UseSelectable = true;
            this.txtOpis.CustomButton.Visible = false;
            this.txtOpis.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOpis.Lines = new string[0];
            this.txtOpis.Location = new System.Drawing.Point(133, 378);
            this.txtOpis.MaxLength = 32767;
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.PasswordChar = '\0';
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOpis.SelectedText = "";
            this.txtOpis.SelectionLength = 0;
            this.txtOpis.SelectionStart = 0;
            this.txtOpis.ShortcutsEnabled = true;
            this.txtOpis.Size = new System.Drawing.Size(169, 29);
            this.txtOpis.TabIndex = 14;
            this.txtOpis.UseSelectable = true;
            this.txtOpis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOpis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmUnosRadnogNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 497);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnIzdajNalog);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.cmbKupac);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.txtArtikl);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmUnosRadnogNaloga";
            this.Resizable = false;
            this.Text = "Unos radnog naloga";
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
        private MetroFramework.Controls.MetroTextBox txtArtikl;
        private MetroFramework.Controls.MetroComboBox cmbZaposlenik;
        private MetroFramework.Controls.MetroComboBox cmbKupac;
        private MetroFramework.Controls.MetroDateTime dtDatum;
        private MetroFramework.Controls.MetroTextBox txtKolicina;
        private MetroFramework.Controls.MetroButton btnIzdajNalog;
        private MetroFramework.Controls.MetroTextBox txtOpis;
    }
}