namespace TBP_projekt
{
    partial class FrmZaposlenici
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
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            this.dgvPopisZaposlenika = new System.Windows.Forms.DataGridView();
            this.btnIzmjeni = new MetroFramework.Controls.MetroButton();
            this.panelIzmjena = new System.Windows.Forms.Panel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailIzmjena = new MetroFramework.Controls.MetroTextBox();
            this.txtKontaktIzmjena = new MetroFramework.Controls.MetroTextBox();
            this.txtPrezimeIzmjena = new MetroFramework.Controls.MetroTextBox();
            this.txtImeIzmjena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtKontakt = new MetroFramework.Controls.MetroTextBox();
            this.txtPrezime = new MetroFramework.Controls.MetroTextBox();
            this.txtIme = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZaposlenika)).BeginInit();
            this.panelIzmjena.SuspendLayout();
            this.panelUnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDodaj.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDodaj.Location = new System.Drawing.Point(80, 226);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 42);
            this.btnDodaj.TabIndex = 22;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseSelectable = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPopisZaposlenika
            // 
            this.dgvPopisZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisZaposlenika.Location = new System.Drawing.Point(229, 87);
            this.dgvPopisZaposlenika.Name = "dgvPopisZaposlenika";
            this.dgvPopisZaposlenika.Size = new System.Drawing.Size(644, 229);
            this.dgvPopisZaposlenika.TabIndex = 23;
            this.dgvPopisZaposlenika.SelectionChanged += new System.EventHandler(this.dgvPopisZaposlenika_SelectionChanged);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIzmjeni.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnIzmjeni.Location = new System.Drawing.Point(84, 227);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(97, 42);
            this.btnIzmjeni.TabIndex = 24;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseSelectable = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // panelIzmjena
            // 
            this.panelIzmjena.Controls.Add(this.metroLabel11);
            this.panelIzmjena.Controls.Add(this.txtEmailIzmjena);
            this.panelIzmjena.Controls.Add(this.btnIzmjeni);
            this.panelIzmjena.Controls.Add(this.txtKontaktIzmjena);
            this.panelIzmjena.Controls.Add(this.txtPrezimeIzmjena);
            this.panelIzmjena.Controls.Add(this.txtImeIzmjena);
            this.panelIzmjena.Controls.Add(this.metroLabel6);
            this.panelIzmjena.Controls.Add(this.metroLabel7);
            this.panelIzmjena.Controls.Add(this.metroLabel8);
            this.panelIzmjena.Controls.Add(this.metroLabel9);
            this.panelIzmjena.Location = new System.Drawing.Point(11, 76);
            this.panelIzmjena.Name = "panelIzmjena";
            this.panelIzmjena.Size = new System.Drawing.Size(200, 307);
            this.panelIzmjena.TabIndex = 26;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(17, 5);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(164, 25);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Izmjena zaposlenika";
            // 
            // txtEmailIzmjena
            // 
            // 
            // 
            // 
            this.txtEmailIzmjena.CustomButton.Image = null;
            this.txtEmailIzmjena.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtEmailIzmjena.CustomButton.Name = "";
            this.txtEmailIzmjena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailIzmjena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailIzmjena.CustomButton.TabIndex = 1;
            this.txtEmailIzmjena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailIzmjena.CustomButton.UseSelectable = true;
            this.txtEmailIzmjena.CustomButton.Visible = false;
            this.txtEmailIzmjena.Lines = new string[0];
            this.txtEmailIzmjena.Location = new System.Drawing.Point(84, 178);
            this.txtEmailIzmjena.MaxLength = 32767;
            this.txtEmailIzmjena.Name = "txtEmailIzmjena";
            this.txtEmailIzmjena.PasswordChar = '\0';
            this.txtEmailIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailIzmjena.SelectedText = "";
            this.txtEmailIzmjena.SelectionLength = 0;
            this.txtEmailIzmjena.SelectionStart = 0;
            this.txtEmailIzmjena.ShortcutsEnabled = true;
            this.txtEmailIzmjena.Size = new System.Drawing.Size(97, 23);
            this.txtEmailIzmjena.TabIndex = 30;
            this.txtEmailIzmjena.UseSelectable = true;
            this.txtEmailIzmjena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailIzmjena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKontaktIzmjena
            // 
            // 
            // 
            // 
            this.txtKontaktIzmjena.CustomButton.Image = null;
            this.txtKontaktIzmjena.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtKontaktIzmjena.CustomButton.Name = "";
            this.txtKontaktIzmjena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKontaktIzmjena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKontaktIzmjena.CustomButton.TabIndex = 1;
            this.txtKontaktIzmjena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKontaktIzmjena.CustomButton.UseSelectable = true;
            this.txtKontaktIzmjena.CustomButton.Visible = false;
            this.txtKontaktIzmjena.Lines = new string[0];
            this.txtKontaktIzmjena.Location = new System.Drawing.Point(84, 134);
            this.txtKontaktIzmjena.MaxLength = 32767;
            this.txtKontaktIzmjena.Name = "txtKontaktIzmjena";
            this.txtKontaktIzmjena.PasswordChar = '\0';
            this.txtKontaktIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKontaktIzmjena.SelectedText = "";
            this.txtKontaktIzmjena.SelectionLength = 0;
            this.txtKontaktIzmjena.SelectionStart = 0;
            this.txtKontaktIzmjena.ShortcutsEnabled = true;
            this.txtKontaktIzmjena.Size = new System.Drawing.Size(97, 23);
            this.txtKontaktIzmjena.TabIndex = 29;
            this.txtKontaktIzmjena.UseSelectable = true;
            this.txtKontaktIzmjena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKontaktIzmjena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrezimeIzmjena
            // 
            // 
            // 
            // 
            this.txtPrezimeIzmjena.CustomButton.Image = null;
            this.txtPrezimeIzmjena.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtPrezimeIzmjena.CustomButton.Name = "";
            this.txtPrezimeIzmjena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrezimeIzmjena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrezimeIzmjena.CustomButton.TabIndex = 1;
            this.txtPrezimeIzmjena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrezimeIzmjena.CustomButton.UseSelectable = true;
            this.txtPrezimeIzmjena.CustomButton.Visible = false;
            this.txtPrezimeIzmjena.Lines = new string[0];
            this.txtPrezimeIzmjena.Location = new System.Drawing.Point(84, 91);
            this.txtPrezimeIzmjena.MaxLength = 32767;
            this.txtPrezimeIzmjena.Name = "txtPrezimeIzmjena";
            this.txtPrezimeIzmjena.PasswordChar = '\0';
            this.txtPrezimeIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrezimeIzmjena.SelectedText = "";
            this.txtPrezimeIzmjena.SelectionLength = 0;
            this.txtPrezimeIzmjena.SelectionStart = 0;
            this.txtPrezimeIzmjena.ShortcutsEnabled = true;
            this.txtPrezimeIzmjena.Size = new System.Drawing.Size(97, 23);
            this.txtPrezimeIzmjena.TabIndex = 28;
            this.txtPrezimeIzmjena.UseSelectable = true;
            this.txtPrezimeIzmjena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrezimeIzmjena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtImeIzmjena
            // 
            // 
            // 
            // 
            this.txtImeIzmjena.CustomButton.Image = null;
            this.txtImeIzmjena.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtImeIzmjena.CustomButton.Name = "";
            this.txtImeIzmjena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtImeIzmjena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImeIzmjena.CustomButton.TabIndex = 1;
            this.txtImeIzmjena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImeIzmjena.CustomButton.UseSelectable = true;
            this.txtImeIzmjena.CustomButton.Visible = false;
            this.txtImeIzmjena.Lines = new string[0];
            this.txtImeIzmjena.Location = new System.Drawing.Point(84, 50);
            this.txtImeIzmjena.MaxLength = 32767;
            this.txtImeIzmjena.Name = "txtImeIzmjena";
            this.txtImeIzmjena.PasswordChar = '\0';
            this.txtImeIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImeIzmjena.SelectedText = "";
            this.txtImeIzmjena.SelectionLength = 0;
            this.txtImeIzmjena.SelectionStart = 0;
            this.txtImeIzmjena.ShortcutsEnabled = true;
            this.txtImeIzmjena.Size = new System.Drawing.Size(97, 23);
            this.txtImeIzmjena.TabIndex = 27;
            this.txtImeIzmjena.UseSelectable = true;
            this.txtImeIzmjena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImeIzmjena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 182);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Email";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(21, 134);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Kontakt";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(21, 91);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(57, 19);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "Prezime";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(21, 50);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(31, 19);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "Ime";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(17, 5);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(144, 25);
            this.metroLabel10.TabIndex = 32;
            this.metroLabel10.Text = "Unos zaposlenika";
            // 
            // panelUnos
            // 
            this.panelUnos.Controls.Add(this.metroLabel10);
            this.panelUnos.Controls.Add(this.txtEmail);
            this.panelUnos.Controls.Add(this.txtKontakt);
            this.panelUnos.Controls.Add(this.txtPrezime);
            this.panelUnos.Controls.Add(this.btnDodaj);
            this.panelUnos.Controls.Add(this.txtIme);
            this.panelUnos.Controls.Add(this.metroLabel4);
            this.panelUnos.Controls.Add(this.metroLabel3);
            this.panelUnos.Controls.Add(this.metroLabel2);
            this.panelUnos.Controls.Add(this.label);
            this.panelUnos.Location = new System.Drawing.Point(11, 76);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(200, 307);
            this.panelUnos.TabIndex = 27;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(80, 171);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(97, 23);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKontakt
            // 
            // 
            // 
            // 
            this.txtKontakt.CustomButton.Image = null;
            this.txtKontakt.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtKontakt.CustomButton.Name = "";
            this.txtKontakt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKontakt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKontakt.CustomButton.TabIndex = 1;
            this.txtKontakt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKontakt.CustomButton.UseSelectable = true;
            this.txtKontakt.CustomButton.Visible = false;
            this.txtKontakt.Lines = new string[0];
            this.txtKontakt.Location = new System.Drawing.Point(80, 127);
            this.txtKontakt.MaxLength = 32767;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.PasswordChar = '\0';
            this.txtKontakt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKontakt.SelectedText = "";
            this.txtKontakt.SelectionLength = 0;
            this.txtKontakt.SelectionStart = 0;
            this.txtKontakt.ShortcutsEnabled = true;
            this.txtKontakt.Size = new System.Drawing.Size(97, 23);
            this.txtKontakt.TabIndex = 29;
            this.txtKontakt.UseSelectable = true;
            this.txtKontakt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKontakt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrezime
            // 
            // 
            // 
            // 
            this.txtPrezime.CustomButton.Image = null;
            this.txtPrezime.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtPrezime.CustomButton.Name = "";
            this.txtPrezime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrezime.CustomButton.TabIndex = 1;
            this.txtPrezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrezime.CustomButton.UseSelectable = true;
            this.txtPrezime.CustomButton.Visible = false;
            this.txtPrezime.Lines = new string[0];
            this.txtPrezime.Location = new System.Drawing.Point(80, 84);
            this.txtPrezime.MaxLength = 32767;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.PasswordChar = '\0';
            this.txtPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrezime.SelectedText = "";
            this.txtPrezime.SelectionLength = 0;
            this.txtPrezime.SelectionStart = 0;
            this.txtPrezime.ShortcutsEnabled = true;
            this.txtPrezime.Size = new System.Drawing.Size(97, 23);
            this.txtPrezime.TabIndex = 28;
            this.txtPrezime.UseSelectable = true;
            this.txtPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIme
            // 
            // 
            // 
            // 
            this.txtIme.CustomButton.Image = null;
            this.txtIme.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtIme.CustomButton.Name = "";
            this.txtIme.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIme.CustomButton.TabIndex = 1;
            this.txtIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIme.CustomButton.UseSelectable = true;
            this.txtIme.CustomButton.Visible = false;
            this.txtIme.Lines = new string[0];
            this.txtIme.Location = new System.Drawing.Point(80, 43);
            this.txtIme.MaxLength = 32767;
            this.txtIme.Name = "txtIme";
            this.txtIme.PasswordChar = '\0';
            this.txtIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIme.SelectedText = "";
            this.txtIme.SelectionLength = 0;
            this.txtIme.SelectionStart = 0;
            this.txtIme.ShortcutsEnabled = true;
            this.txtIme.Size = new System.Drawing.Size(97, 23);
            this.txtIme.TabIndex = 27;
            this.txtIme.UseSelectable = true;
            this.txtIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Email";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 127);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Kontakt";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Prezime";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 19);
            this.label.TabIndex = 22;
            this.label.Text = "Ime";
            this.label.UseCustomBackColor = true;
            this.label.UseCustomForeColor = true;
            // 
            // FrmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 404);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.panelIzmjena);
            this.Controls.Add(this.dgvPopisZaposlenika);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZaposlenici";
            this.Resizable = false;
            this.Text = "Zaposlenici";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZaposlenika)).EndInit();
            this.panelIzmjena.ResumeLayout(false);
            this.panelIzmjena.PerformLayout();
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnDodaj;
        private System.Windows.Forms.DataGridView dgvPopisZaposlenika;
        private MetroFramework.Controls.MetroButton btnIzmjeni;
        private System.Windows.Forms.Panel panelIzmjena;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtEmailIzmjena;
        private MetroFramework.Controls.MetroTextBox txtKontaktIzmjena;
        private MetroFramework.Controls.MetroTextBox txtPrezimeIzmjena;
        private MetroFramework.Controls.MetroTextBox txtImeIzmjena;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Panel panelUnos;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtKontakt;
        private MetroFramework.Controls.MetroTextBox txtPrezime;
        private MetroFramework.Controls.MetroTextBox txtIme;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel label;
    }
}

