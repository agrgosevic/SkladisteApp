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
    public partial class FrmDobavljaci : MetroFramework.Forms.MetroForm
    {
        private int id;
        public FrmDobavljaci()
        {
            InitializeComponent();
            DohvatiKupce();
        }

        public void DohvatiKupce()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT * FROM public.\"Dobavljac\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            dgvDobavljaci.DataSource = bindingSource;
            npgsqlConnection.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO public.\"Dobavljac\"(naziv, email) VALUES('" + txtNaziv.Text + "','" + txtEmail.Text + "')", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();

            DohvatiKupce();
            connection.Close();
            txtNaziv.Clear();
            txtEmail.Clear();
            dgvDobavljaci.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            if (dgvDobavljaci.CurrentRow != null)
            {
                id = int.Parse(dgvDobavljaci.CurrentRow.Cells[0].Value.ToString());
            }
            string upit = $"UPDATE public.\"Dobavljac\" SET naziv = '" + txtNazivIzmjena.Text + "', email='" + txtEmailIzmjena.Text + "' WHERE \"idDobavljac\"= '" + id + "' ";
            NpgsqlCommand command = new NpgsqlCommand(upit, connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            connection.Close();
            DohvatiKupce();
            dgvDobavljaci.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void dgvDobavljaci_SelectionChanged(object sender, EventArgs e)
        {
            panelIzmjena.BringToFront();
            panelIzmjena.Visible = true;
            if (dgvDobavljaci.CurrentRow != null)
            {
                txtNazivIzmjena.Text = dgvDobavljaci.CurrentRow.Cells[1].Value.ToString();
                txtEmailIzmjena.Text = dgvDobavljaci.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void FrmDobavljaci_Load(object sender, EventArgs e)
        {
            dgvDobavljaci.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }
    }
}
