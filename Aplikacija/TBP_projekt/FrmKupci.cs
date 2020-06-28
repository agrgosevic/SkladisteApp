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
    public partial class FrmKupci : MetroFramework.Forms.MetroForm
    {
        private int id;
        public FrmKupci()
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
            string upit = "SELECT * FROM public.\"Kupac\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            dgvKupci.DataSource = bindingSource;
            npgsqlConnection.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO public.\"Kupac\"(naziv) VALUES('" + txtNaziv.Text + "')", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();

            DohvatiKupce();
            connection.Close();
            txtNaziv.Clear();
            dgvKupci.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            if (dgvKupci.CurrentRow != null)
            {
                id = int.Parse(dgvKupci.CurrentRow.Cells[0].Value.ToString());
            }
            string upit = $"UPDATE public.\"Kupac\" SET naziv = '" + txtNazivIzmjena.Text  + "' WHERE \"idKupac\"= '" + id + "' ";
            NpgsqlCommand command = new NpgsqlCommand(upit, connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            connection.Close();
            DohvatiKupce();
            dgvKupci.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void dgvKupci_SelectionChanged(object sender, EventArgs e)
        {
            panelIzmjena.BringToFront();
            panelIzmjena.Visible = true;
            if (dgvKupci.CurrentRow != null)
            {
                txtNazivIzmjena.Text = dgvKupci.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void FrmKupci_Load(object sender, EventArgs e)
        {
            dgvKupci.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }
    }
}
