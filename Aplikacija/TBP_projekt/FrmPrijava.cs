using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TBP_projekt
{
    public partial class FrmPrijava : MetroFramework.Forms.MetroForm
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }
        string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
        NpgsqlConnection npgsqlConnection;

        private void DohvatiZaposlenika()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            string upit = $"SELECT email, lozinka FROM public.\"Zaposlenik\" WHERE email = {txtEmail.Text} and lozinka = {txtLozinka.Text}";
            NpgsqlCommand command = new NpgsqlCommand(upit, npgsqlConnection);
            NpgsqlDataReader reader = command.ExecuteReader();

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            //DohvatiZaposlenika();
            //if(txtEmail.Text == "" && txtLozinka.Text == "")
            //{
            //    MessageBox.Show("Niste unijeli dobar email ili lozinku!");
            //}
            //else
            //{
            //    this.Hide();
            //    FrmIzbornik frmIzbornik = new FrmIzbornik();
            //    frmIzbornik.Show();
            //}
            try
            {
                //string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
                //NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
                npgsqlConnection.Open();
                string upit = $"SELECT email, lozinka FROM public.\"Zaposlenik\" WHERE email = {txtEmail.Text} and lozinka = {txtLozinka.Text}";
                NpgsqlCommand command = new NpgsqlCommand(upit, npgsqlConnection);

                command.Parameters.AddWithValue("email", txtEmail.Text);
                command.Parameters.AddWithValue("lozinka", txtLozinka.Text);
                int rezultat = (int)command.ExecuteScalar();
                npgsqlConnection.Close();
                if (rezultat == 1)
                {
                    this.Hide();
                    FrmIzbornik frmIzbornik = new FrmIzbornik();
                    frmIzbornik.Show();
                }
                else
                {
                    MessageBox.Show("Niste unijeli dobar email ili lozinku!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nes nije dobro!" + ex.Message);
            }
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            npgsqlConnection = new NpgsqlConnection(connectionString);
        }
    }
}
