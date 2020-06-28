namespace TBP_projekt
{
    partial class FrmDobavljaci
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
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            this.btnIzmjeni = new MetroFramework.Controls.MetroButton();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panelIzmjena = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailIzmjena = new MetroFramework.Controls.MetroTextBox();
            this.txtNazivIzmjena = new MetroFramework.Controls.MetroTextBox();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.panelUnos.SuspendLayout();
            this.panelIzmjena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Naziv";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "E-mail";
            // 
            // txtNaziv
            // 
            // 
            // 
            // 
            this.txtNaziv.CustomButton.Image = null;
            this.txtNaziv.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtNaziv.CustomButton.Name = "";
            this.txtNaziv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNaziv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.CustomButton.TabIndex = 1;
            this.txtNaziv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.CustomButton.UseSelectable = true;
            this.txtNaziv.CustomButton.Visible = false;
            this.txtNaziv.Lines = new string[0];
            this.txtNaziv.Location = new System.Drawing.Point(12, 75);
            this.txtNaziv.MaxLength = 32767;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.PasswordChar = '\0';
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.SelectionLength = 0;
            this.txtNaziv.SelectionStart = 0;
            this.txtNaziv.ShortcutsEnabled = true;
            this.txtNaziv.Size = new System.Drawing.Size(92, 23);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.UseSelectable = true;
            this.txtNaziv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNaziv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(12, 139);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(92, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDodaj
            // 
            this.btnDodaj.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDodaj.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDodaj.Location = new System.Drawing.Point(12, 179);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(92, 37);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseSelectable = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIzmjeni.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnIzmjeni.Location = new System.Drawing.Point(12, 179);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(92, 37);
            this.btnIzmjeni.TabIndex = 5;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseSelectable = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // panelUnos
            // 
            this.panelUnos.Controls.Add(this.metroLabel3);
            this.panelUnos.Controls.Add(this.btnDodaj);
            this.panelUnos.Controls.Add(this.metroLabel1);
            this.panelUnos.Controls.Add(this.metroLabel2);
            this.panelUnos.Controls.Add(this.txtEmail);
            this.panelUnos.Controls.Add(this.txtNaziv);
            this.panelUnos.Location = new System.Drawing.Point(23, 84);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(180, 239);
            this.panelUnos.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(12, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Unos dobavljača";
            // 
            // panelIzmjena
            // 
            this.panelIzmjena.Controls.Add(this.metroLabel4);
            this.panelIzmjena.Controls.Add(this.metroLabel5);
            this.panelIzmjena.Controls.Add(this.metroLabel6);
            this.panelIzmjena.Controls.Add(this.btnIzmjeni);
            this.panelIzmjena.Controls.Add(this.txtEmailIzmjena);
            this.panelIzmjena.Controls.Add(this.txtNazivIzmjena);
            this.panelIzmjena.Location = new System.Drawing.Point(23, 84);
            this.panelIzmjena.Name = "panelIzmjena";
            this.panelIzmjena.Size = new System.Drawing.Size(180, 239);
            this.panelIzmjena.TabIndex = 8;
            this.panelIzmjena.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(12, 17);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(157, 25);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Izmjena dobavljača";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 53);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Naziv";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 117);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "E-mail";
            // 
            // txtEmailIzmjena
            // 
            // 
            // 
            // 
            this.txtEmailIzmjena.CustomButton.Image = null;
            this.txtEmailIzmjena.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtEmailIzmjena.CustomButton.Name = "";
            this.txtEmailIzmjena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailIzmjena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailIzmjena.CustomButton.TabIndex = 1;
            this.txtEmailIzmjena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailIzmjena.CustomButton.UseSelectable = true;
            this.txtEmailIzmjena.CustomButton.Visible = false;
            this.txtEmailIzmjena.Lines = new string[0];
            this.txtEmailIzmjena.Location = new System.Drawing.Point(12, 139);
            this.txtEmailIzmjena.MaxLength = 32767;
            this.txtEmailIzmjena.Name = "txtEmailIzmjena";
            this.txtEmailIzmjena.PasswordChar = '\0';
            this.txtEmailIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailIzmjena.SelectedText = "";
            this.txtEmailIzmjena.SelectionLength = 0;
            this.txtEmailIzmjena.SelectionStart = 0;
            this.txtEmailIzmjena.ShortcutsEnabled = true;
            this.txtEmailIzmjena.Size = new System.Drawing.Size(92, 23);
            this.txtEmailIzmjena.TabIndex = 3;
            this.txtEmailIzmjena.UseSelectable = true;
            this.txtEmailIzmjena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailIzmjena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNazivIzmjena
            // 
            // 
            // 
            // 
            this.txtNazivIzmjena.CustomButton.Image = null;
            this.txtNazivIzmjena.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtNazivIzmjena.CustomButton.Name = "";
            this.txtNazivIzmjena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNazivIzmjena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNazivIzmjena.CustomButton.TabIndex = 1;
            this.txtNazivIzmjena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNazivIzmjena.CustomButton.UseSelectable = true;
            this.txtNazivIzmjena.CustomButton.Visible = false;
            this.txtNazivIzmjena.Lines = new string[0];
            this.txtNazivIzmjena.Location = new System.Drawing.Point(12, 75);
            this.txtNazivIzmjena.MaxLength = 32767;
            this.txtNazivIzmjena.Name = "txtNazivIzmjena";
            this.txtNazivIzmjena.PasswordChar = '\0';
            this.txtNazivIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNazivIzmjena.SelectedText = "";
            this.txtNazivIzmjena.SelectionLength = 0;
            this.txtNazivIzmjena.SelectionStart = 0;
            this.txtNazivIzmjena.ShortcutsEnabled = true;
            this.txtNazivIzmjena.Size = new System.Drawing.Size(92, 23);
            this.txtNazivIzmjena.TabIndex = 2;
            this.txtNazivIzmjena.UseSelectable = true;
            this.txtNazivIzmjena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNazivIzmjena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Location = new System.Drawing.Point(209, 101);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.Size = new System.Drawing.Size(354, 199);
            this.dgvDobavljaci.TabIndex = 9;
            this.dgvDobavljaci.SelectionChanged += new System.EventHandler(this.dgvDobavljaci_SelectionChanged);
            // 
            // FrmDobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 363);
            this.Controls.Add(this.dgvDobavljaci);
            this.Controls.Add(this.panelIzmjena);
            this.Controls.Add(this.panelUnos);
            this.Name = "FrmDobavljaci";
            this.Text = "Dobavljači";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmDobavljaci_Load);
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            this.panelIzmjena.ResumeLayout(false);
            this.panelIzmjena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroButton btnDodaj;
        private MetroFramework.Controls.MetroButton btnIzmjeni;
        private System.Windows.Forms.Panel panelUnos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panelIzmjena;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmailIzmjena;
        private MetroFramework.Controls.MetroTextBox txtNazivIzmjena;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
    }
}