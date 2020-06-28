namespace TBP_projekt
{
    partial class FrmArtikli
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
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.txtNabavnaCijena = new MetroFramework.Controls.MetroTextBox();
            this.txtMinKolicina = new MetroFramework.Controls.MetroTextBox();
            this.txtMaxKolicina = new MetroFramework.Controls.MetroTextBox();
            this.txtUkupnaKolicina = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.txtJedinicaMjere = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.panelIzmjena = new System.Windows.Forms.Panel();
            this.txtIzmjenaJedMjere = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtIzmjenaMinKol = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.btnIzmjena = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txtIzmjenaUkKol = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtIzmjenaMaxKol = new MetroFramework.Controls.MetroTextBox();
            this.txtIzmjenaNaziv = new MetroFramework.Controls.MetroTextBox();
            this.txtIzmjenaNabavnaCijena = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.panelUnos.SuspendLayout();
            this.panelIzmjena.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Naziv";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nabavna cijena";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Min količina";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Max količina";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 213);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Ukupna količina";
            // 
            // txtNaziv
            // 
            // 
            // 
            // 
            this.txtNaziv.CustomButton.Image = null;
            this.txtNaziv.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtNaziv.CustomButton.Name = "";
            this.txtNaziv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNaziv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.CustomButton.TabIndex = 1;
            this.txtNaziv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.CustomButton.UseSelectable = true;
            this.txtNaziv.CustomButton.Visible = false;
            this.txtNaziv.Lines = new string[0];
            this.txtNaziv.Location = new System.Drawing.Point(115, 50);
            this.txtNaziv.MaxLength = 32767;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.PasswordChar = '\0';
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.SelectionLength = 0;
            this.txtNaziv.SelectionStart = 0;
            this.txtNaziv.ShortcutsEnabled = true;
            this.txtNaziv.Size = new System.Drawing.Size(90, 23);
            this.txtNaziv.TabIndex = 5;
            this.txtNaziv.UseSelectable = true;
            this.txtNaziv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNaziv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNabavnaCijena
            // 
            // 
            // 
            // 
            this.txtNabavnaCijena.CustomButton.Image = null;
            this.txtNabavnaCijena.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtNabavnaCijena.CustomButton.Name = "";
            this.txtNabavnaCijena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNabavnaCijena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNabavnaCijena.CustomButton.TabIndex = 1;
            this.txtNabavnaCijena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNabavnaCijena.CustomButton.UseSelectable = true;
            this.txtNabavnaCijena.CustomButton.Visible = false;
            this.txtNabavnaCijena.Lines = new string[0];
            this.txtNabavnaCijena.Location = new System.Drawing.Point(115, 90);
            this.txtNabavnaCijena.MaxLength = 32767;
            this.txtNabavnaCijena.Name = "txtNabavnaCijena";
            this.txtNabavnaCijena.PasswordChar = '\0';
            this.txtNabavnaCijena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNabavnaCijena.SelectedText = "";
            this.txtNabavnaCijena.SelectionLength = 0;
            this.txtNabavnaCijena.SelectionStart = 0;
            this.txtNabavnaCijena.ShortcutsEnabled = true;
            this.txtNabavnaCijena.Size = new System.Drawing.Size(90, 23);
            this.txtNabavnaCijena.TabIndex = 6;
            this.txtNabavnaCijena.UseSelectable = true;
            this.txtNabavnaCijena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNabavnaCijena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMinKolicina
            // 
            // 
            // 
            // 
            this.txtMinKolicina.CustomButton.Image = null;
            this.txtMinKolicina.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtMinKolicina.CustomButton.Name = "";
            this.txtMinKolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMinKolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinKolicina.CustomButton.TabIndex = 1;
            this.txtMinKolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMinKolicina.CustomButton.UseSelectable = true;
            this.txtMinKolicina.CustomButton.Visible = false;
            this.txtMinKolicina.Lines = new string[0];
            this.txtMinKolicina.Location = new System.Drawing.Point(115, 130);
            this.txtMinKolicina.MaxLength = 32767;
            this.txtMinKolicina.Name = "txtMinKolicina";
            this.txtMinKolicina.PasswordChar = '\0';
            this.txtMinKolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinKolicina.SelectedText = "";
            this.txtMinKolicina.SelectionLength = 0;
            this.txtMinKolicina.SelectionStart = 0;
            this.txtMinKolicina.ShortcutsEnabled = true;
            this.txtMinKolicina.Size = new System.Drawing.Size(90, 23);
            this.txtMinKolicina.TabIndex = 7;
            this.txtMinKolicina.UseSelectable = true;
            this.txtMinKolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMinKolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaxKolicina
            // 
            // 
            // 
            // 
            this.txtMaxKolicina.CustomButton.Image = null;
            this.txtMaxKolicina.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtMaxKolicina.CustomButton.Name = "";
            this.txtMaxKolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaxKolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxKolicina.CustomButton.TabIndex = 1;
            this.txtMaxKolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxKolicina.CustomButton.UseSelectable = true;
            this.txtMaxKolicina.CustomButton.Visible = false;
            this.txtMaxKolicina.Lines = new string[0];
            this.txtMaxKolicina.Location = new System.Drawing.Point(115, 171);
            this.txtMaxKolicina.MaxLength = 32767;
            this.txtMaxKolicina.Name = "txtMaxKolicina";
            this.txtMaxKolicina.PasswordChar = '\0';
            this.txtMaxKolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxKolicina.SelectedText = "";
            this.txtMaxKolicina.SelectionLength = 0;
            this.txtMaxKolicina.SelectionStart = 0;
            this.txtMaxKolicina.ShortcutsEnabled = true;
            this.txtMaxKolicina.Size = new System.Drawing.Size(90, 23);
            this.txtMaxKolicina.TabIndex = 8;
            this.txtMaxKolicina.UseSelectable = true;
            this.txtMaxKolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxKolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUkupnaKolicina
            // 
            // 
            // 
            // 
            this.txtUkupnaKolicina.CustomButton.Image = null;
            this.txtUkupnaKolicina.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtUkupnaKolicina.CustomButton.Name = "";
            this.txtUkupnaKolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUkupnaKolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUkupnaKolicina.CustomButton.TabIndex = 1;
            this.txtUkupnaKolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUkupnaKolicina.CustomButton.UseSelectable = true;
            this.txtUkupnaKolicina.CustomButton.Visible = false;
            this.txtUkupnaKolicina.Lines = new string[0];
            this.txtUkupnaKolicina.Location = new System.Drawing.Point(115, 209);
            this.txtUkupnaKolicina.MaxLength = 32767;
            this.txtUkupnaKolicina.Name = "txtUkupnaKolicina";
            this.txtUkupnaKolicina.PasswordChar = '\0';
            this.txtUkupnaKolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUkupnaKolicina.SelectedText = "";
            this.txtUkupnaKolicina.SelectionLength = 0;
            this.txtUkupnaKolicina.SelectionStart = 0;
            this.txtUkupnaKolicina.ShortcutsEnabled = true;
            this.txtUkupnaKolicina.Size = new System.Drawing.Size(90, 23);
            this.txtUkupnaKolicina.TabIndex = 9;
            this.txtUkupnaKolicina.UseSelectable = true;
            this.txtUkupnaKolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUkupnaKolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(56, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 25);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Unos artikla";
            // 
            // btnDodaj
            // 
            this.btnDodaj.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDodaj.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDodaj.Location = new System.Drawing.Point(115, 289);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 35);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseSelectable = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(229, 86);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(780, 301);
            this.dgvArtikli.TabIndex = 12;
            this.dgvArtikli.SelectionChanged += new System.EventHandler(this.dgvArtikli_SelectionChanged);
            // 
            // panelUnos
            // 
            this.panelUnos.Controls.Add(this.txtJedinicaMjere);
            this.panelUnos.Controls.Add(this.metroLabel13);
            this.panelUnos.Controls.Add(this.txtMinKolicina);
            this.panelUnos.Controls.Add(this.metroLabel1);
            this.panelUnos.Controls.Add(this.metroLabel2);
            this.panelUnos.Controls.Add(this.btnDodaj);
            this.panelUnos.Controls.Add(this.metroLabel3);
            this.panelUnos.Controls.Add(this.metroLabel6);
            this.panelUnos.Controls.Add(this.metroLabel4);
            this.panelUnos.Controls.Add(this.txtUkupnaKolicina);
            this.panelUnos.Controls.Add(this.metroLabel5);
            this.panelUnos.Controls.Add(this.txtMaxKolicina);
            this.panelUnos.Controls.Add(this.txtNaziv);
            this.panelUnos.Controls.Add(this.txtNabavnaCijena);
            this.panelUnos.Location = new System.Drawing.Point(4, 63);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(219, 345);
            this.panelUnos.TabIndex = 14;
            // 
            // txtJedinicaMjere
            // 
            // 
            // 
            // 
            this.txtJedinicaMjere.CustomButton.Image = null;
            this.txtJedinicaMjere.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtJedinicaMjere.CustomButton.Name = "";
            this.txtJedinicaMjere.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJedinicaMjere.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJedinicaMjere.CustomButton.TabIndex = 1;
            this.txtJedinicaMjere.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJedinicaMjere.CustomButton.UseSelectable = true;
            this.txtJedinicaMjere.CustomButton.Visible = false;
            this.txtJedinicaMjere.Lines = new string[0];
            this.txtJedinicaMjere.Location = new System.Drawing.Point(116, 245);
            this.txtJedinicaMjere.MaxLength = 32767;
            this.txtJedinicaMjere.Name = "txtJedinicaMjere";
            this.txtJedinicaMjere.PasswordChar = '\0';
            this.txtJedinicaMjere.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJedinicaMjere.SelectedText = "";
            this.txtJedinicaMjere.SelectionLength = 0;
            this.txtJedinicaMjere.SelectionStart = 0;
            this.txtJedinicaMjere.ShortcutsEnabled = true;
            this.txtJedinicaMjere.Size = new System.Drawing.Size(88, 23);
            this.txtJedinicaMjere.TabIndex = 13;
            this.txtJedinicaMjere.UseSelectable = true;
            this.txtJedinicaMjere.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJedinicaMjere.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(17, 245);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(93, 19);
            this.metroLabel13.TabIndex = 12;
            this.metroLabel13.Text = "Jedinica mjere";
            // 
            // panelIzmjena
            // 
            this.panelIzmjena.Controls.Add(this.txtIzmjenaJedMjere);
            this.panelIzmjena.Controls.Add(this.metroLabel14);
            this.panelIzmjena.Controls.Add(this.txtIzmjenaMinKol);
            this.panelIzmjena.Controls.Add(this.metroLabel15);
            this.panelIzmjena.Controls.Add(this.metroLabel16);
            this.panelIzmjena.Controls.Add(this.btnIzmjena);
            this.panelIzmjena.Controls.Add(this.metroLabel17);
            this.panelIzmjena.Controls.Add(this.metroLabel18);
            this.panelIzmjena.Controls.Add(this.metroLabel19);
            this.panelIzmjena.Controls.Add(this.txtIzmjenaUkKol);
            this.panelIzmjena.Controls.Add(this.metroLabel20);
            this.panelIzmjena.Controls.Add(this.txtIzmjenaMaxKol);
            this.panelIzmjena.Controls.Add(this.txtIzmjenaNaziv);
            this.panelIzmjena.Controls.Add(this.txtIzmjenaNabavnaCijena);
            this.panelIzmjena.Location = new System.Drawing.Point(4, 63);
            this.panelIzmjena.Name = "panelIzmjena";
            this.panelIzmjena.Size = new System.Drawing.Size(219, 345);
            this.panelIzmjena.TabIndex = 16;
            this.panelIzmjena.Visible = false;
            // 
            // txtIzmjenaJedMjere
            // 
            // 
            // 
            // 
            this.txtIzmjenaJedMjere.CustomButton.Image = null;
            this.txtIzmjenaJedMjere.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtIzmjenaJedMjere.CustomButton.Name = "";
            this.txtIzmjenaJedMjere.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIzmjenaJedMjere.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIzmjenaJedMjere.CustomButton.TabIndex = 1;
            this.txtIzmjenaJedMjere.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIzmjenaJedMjere.CustomButton.UseSelectable = true;
            this.txtIzmjenaJedMjere.CustomButton.Visible = false;
            this.txtIzmjenaJedMjere.Lines = new string[0];
            this.txtIzmjenaJedMjere.Location = new System.Drawing.Point(116, 245);
            this.txtIzmjenaJedMjere.MaxLength = 32767;
            this.txtIzmjenaJedMjere.Name = "txtIzmjenaJedMjere";
            this.txtIzmjenaJedMjere.PasswordChar = '\0';
            this.txtIzmjenaJedMjere.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIzmjenaJedMjere.SelectedText = "";
            this.txtIzmjenaJedMjere.SelectionLength = 0;
            this.txtIzmjenaJedMjere.SelectionStart = 0;
            this.txtIzmjenaJedMjere.ShortcutsEnabled = true;
            this.txtIzmjenaJedMjere.Size = new System.Drawing.Size(88, 23);
            this.txtIzmjenaJedMjere.TabIndex = 13;
            this.txtIzmjenaJedMjere.UseSelectable = true;
            this.txtIzmjenaJedMjere.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIzmjenaJedMjere.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(17, 245);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(93, 19);
            this.metroLabel14.TabIndex = 12;
            this.metroLabel14.Text = "Jedinica mjere";
            // 
            // txtIzmjenaMinKol
            // 
            // 
            // 
            // 
            this.txtIzmjenaMinKol.CustomButton.Image = null;
            this.txtIzmjenaMinKol.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtIzmjenaMinKol.CustomButton.Name = "";
            this.txtIzmjenaMinKol.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIzmjenaMinKol.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIzmjenaMinKol.CustomButton.TabIndex = 1;
            this.txtIzmjenaMinKol.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIzmjenaMinKol.CustomButton.UseSelectable = true;
            this.txtIzmjenaMinKol.CustomButton.Visible = false;
            this.txtIzmjenaMinKol.Lines = new string[0];
            this.txtIzmjenaMinKol.Location = new System.Drawing.Point(115, 130);
            this.txtIzmjenaMinKol.MaxLength = 32767;
            this.txtIzmjenaMinKol.Name = "txtIzmjenaMinKol";
            this.txtIzmjenaMinKol.PasswordChar = '\0';
            this.txtIzmjenaMinKol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIzmjenaMinKol.SelectedText = "";
            this.txtIzmjenaMinKol.SelectionLength = 0;
            this.txtIzmjenaMinKol.SelectionStart = 0;
            this.txtIzmjenaMinKol.ShortcutsEnabled = true;
            this.txtIzmjenaMinKol.Size = new System.Drawing.Size(90, 23);
            this.txtIzmjenaMinKol.TabIndex = 7;
            this.txtIzmjenaMinKol.UseSelectable = true;
            this.txtIzmjenaMinKol.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIzmjenaMinKol.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(17, 54);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(41, 19);
            this.metroLabel15.TabIndex = 0;
            this.metroLabel15.Text = "Naziv";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(17, 94);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(98, 19);
            this.metroLabel16.TabIndex = 1;
            this.metroLabel16.Text = "Nabavna cijena";
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIzmjena.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnIzmjena.Location = new System.Drawing.Point(115, 289);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(90, 35);
            this.btnIzmjena.TabIndex = 11;
            this.btnIzmjena.Text = "Izmjena";
            this.btnIzmjena.UseSelectable = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(17, 134);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(78, 19);
            this.metroLabel17.TabIndex = 2;
            this.metroLabel17.Text = "Min količina";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.Location = new System.Drawing.Point(56, 9);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(122, 25);
            this.metroLabel18.TabIndex = 10;
            this.metroLabel18.Text = "Izmjena artikla";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(17, 175);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(81, 19);
            this.metroLabel19.TabIndex = 3;
            this.metroLabel19.Text = "Max količina";
            // 
            // txtIzmjenaUkKol
            // 
            // 
            // 
            // 
            this.txtIzmjenaUkKol.CustomButton.Image = null;
            this.txtIzmjenaUkKol.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtIzmjenaUkKol.CustomButton.Name = "";
            this.txtIzmjenaUkKol.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIzmjenaUkKol.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIzmjenaUkKol.CustomButton.TabIndex = 1;
            this.txtIzmjenaUkKol.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIzmjenaUkKol.CustomButton.UseSelectable = true;
            this.txtIzmjenaUkKol.CustomButton.Visible = false;
            this.txtIzmjenaUkKol.Lines = new string[0];
            this.txtIzmjenaUkKol.Location = new System.Drawing.Point(115, 209);
            this.txtIzmjenaUkKol.MaxLength = 32767;
            this.txtIzmjenaUkKol.Name = "txtIzmjenaUkKol";
            this.txtIzmjenaUkKol.PasswordChar = '\0';
            this.txtIzmjenaUkKol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIzmjenaUkKol.SelectedText = "";
            this.txtIzmjenaUkKol.SelectionLength = 0;
            this.txtIzmjenaUkKol.SelectionStart = 0;
            this.txtIzmjenaUkKol.ShortcutsEnabled = true;
            this.txtIzmjenaUkKol.Size = new System.Drawing.Size(90, 23);
            this.txtIzmjenaUkKol.TabIndex = 9;
            this.txtIzmjenaUkKol.UseSelectable = true;
            this.txtIzmjenaUkKol.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIzmjenaUkKol.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(17, 213);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(100, 19);
            this.metroLabel20.TabIndex = 4;
            this.metroLabel20.Text = "Ukupna količina";
            // 
            // txtIzmjenaMaxKol
            // 
            // 
            // 
            // 
            this.txtIzmjenaMaxKol.CustomButton.Image = null;
            this.txtIzmjenaMaxKol.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtIzmjenaMaxKol.CustomButton.Name = "";
            this.txtIzmjenaMaxKol.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIzmjenaMaxKol.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIzmjenaMaxKol.CustomButton.TabIndex = 1;
            this.txtIzmjenaMaxKol.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIzmjenaMaxKol.CustomButton.UseSelectable = true;
            this.txtIzmjenaMaxKol.CustomButton.Visible = false;
            this.txtIzmjenaMaxKol.Lines = new string[0];
            this.txtIzmjenaMaxKol.Location = new System.Drawing.Point(115, 171);
            this.txtIzmjenaMaxKol.MaxLength = 32767;
            this.txtIzmjenaMaxKol.Name = "txtIzmjenaMaxKol";
            this.txtIzmjenaMaxKol.PasswordChar = '\0';
            this.txtIzmjenaMaxKol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIzmjenaMaxKol.SelectedText = "";
            this.txtIzmjenaMaxKol.SelectionLength = 0;
            this.txtIzmjenaMaxKol.SelectionStart = 0;
            this.txtIzmjenaMaxKol.ShortcutsEnabled = true;
            this.txtIzmjenaMaxKol.Size = new System.Drawing.Size(90, 23);
            this.txtIzmjenaMaxKol.TabIndex = 8;
            this.txtIzmjenaMaxKol.UseSelectable = true;
            this.txtIzmjenaMaxKol.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIzmjenaMaxKol.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIzmjenaNaziv
            // 
            // 
            // 
            // 
            this.txtIzmjenaNaziv.CustomButton.Image = null;
            this.txtIzmjenaNaziv.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtIzmjenaNaziv.CustomButton.Name = "";
            this.txtIzmjenaNaziv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIzmjenaNaziv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIzmjenaNaziv.CustomButton.TabIndex = 1;
            this.txtIzmjenaNaziv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIzmjenaNaziv.CustomButton.UseSelectable = true;
            this.txtIzmjenaNaziv.CustomButton.Visible = false;
            this.txtIzmjenaNaziv.Lines = new string[0];
            this.txtIzmjenaNaziv.Location = new System.Drawing.Point(115, 50);
            this.txtIzmjenaNaziv.MaxLength = 32767;
            this.txtIzmjenaNaziv.Name = "txtIzmjenaNaziv";
            this.txtIzmjenaNaziv.PasswordChar = '\0';
            this.txtIzmjenaNaziv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIzmjenaNaziv.SelectedText = "";
            this.txtIzmjenaNaziv.SelectionLength = 0;
            this.txtIzmjenaNaziv.SelectionStart = 0;
            this.txtIzmjenaNaziv.ShortcutsEnabled = true;
            this.txtIzmjenaNaziv.Size = new System.Drawing.Size(90, 23);
            this.txtIzmjenaNaziv.TabIndex = 5;
            this.txtIzmjenaNaziv.UseSelectable = true;
            this.txtIzmjenaNaziv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIzmjenaNaziv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIzmjenaNabavnaCijena
            // 
            // 
            // 
            // 
            this.txtIzmjenaNabavnaCijena.CustomButton.Image = null;
            this.txtIzmjenaNabavnaCijena.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtIzmjenaNabavnaCijena.CustomButton.Name = "";
            this.txtIzmjenaNabavnaCijena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIzmjenaNabavnaCijena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIzmjenaNabavnaCijena.CustomButton.TabIndex = 1;
            this.txtIzmjenaNabavnaCijena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIzmjenaNabavnaCijena.CustomButton.UseSelectable = true;
            this.txtIzmjenaNabavnaCijena.CustomButton.Visible = false;
            this.txtIzmjenaNabavnaCijena.Lines = new string[0];
            this.txtIzmjenaNabavnaCijena.Location = new System.Drawing.Point(115, 90);
            this.txtIzmjenaNabavnaCijena.MaxLength = 32767;
            this.txtIzmjenaNabavnaCijena.Name = "txtIzmjenaNabavnaCijena";
            this.txtIzmjenaNabavnaCijena.PasswordChar = '\0';
            this.txtIzmjenaNabavnaCijena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIzmjenaNabavnaCijena.SelectedText = "";
            this.txtIzmjenaNabavnaCijena.SelectionLength = 0;
            this.txtIzmjenaNabavnaCijena.SelectionStart = 0;
            this.txtIzmjenaNabavnaCijena.ShortcutsEnabled = true;
            this.txtIzmjenaNabavnaCijena.Size = new System.Drawing.Size(90, 23);
            this.txtIzmjenaNabavnaCijena.TabIndex = 6;
            this.txtIzmjenaNabavnaCijena.UseSelectable = true;
            this.txtIzmjenaNabavnaCijena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIzmjenaNabavnaCijena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 435);
            this.Controls.Add(this.panelIzmjena);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.dgvArtikli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmArtikli";
            this.Text = "Artikli";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            this.panelIzmjena.ResumeLayout(false);
            this.panelIzmjena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private MetroFramework.Controls.MetroTextBox txtNabavnaCijena;
        private MetroFramework.Controls.MetroTextBox txtMinKolicina;
        private MetroFramework.Controls.MetroTextBox txtMaxKolicina;
        private MetroFramework.Controls.MetroTextBox txtUkupnaKolicina;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnDodaj;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Panel panelUnos;
        private MetroFramework.Controls.MetroTextBox txtJedinicaMjere;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.Panel panelIzmjena;
        private MetroFramework.Controls.MetroTextBox txtIzmjenaJedMjere;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtIzmjenaMinKol;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroButton btnIzmjena;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txtIzmjenaUkKol;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtIzmjenaMaxKol;
        private MetroFramework.Controls.MetroTextBox txtIzmjenaNaziv;
        private MetroFramework.Controls.MetroTextBox txtIzmjenaNabavnaCijena;
    }
}