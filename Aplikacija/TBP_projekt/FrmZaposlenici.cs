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
    public partial class FrmZaposlenici : MetroFramework.Forms.MetroForm
    {
        private int id;
        public FrmZaposlenici()
        {
            InitializeComponent();
            DohvatiZaposlenike();

        }
        public void DohvatiZaposlenike()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT * FROM public.\"Zaposlenik\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            dgvPopisZaposlenika.DataSource = bindingSource;
            npgsqlConnection.Close();

        }

        public void PopuniSvePodatke()
        {
            if (dgvPopisZaposlenika.CurrentRow != null)
            {
                txtImeIzmjena.Text = dgvPopisZaposlenika.CurrentRow.Cells[1].Value.ToString();
                txtPrezimeIzmjena.Text = dgvPopisZaposlenika.CurrentRow.Cells[2].Value.ToString();
                txtKontaktIzmjena.Text = dgvPopisZaposlenika.CurrentRow.Cells[3].Value.ToString();
                txtEmailIzmjena.Text = dgvPopisZaposlenika.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            if (dgvPopisZaposlenika.CurrentRow != null)
            {
                id = int.Parse(dgvPopisZaposlenika.CurrentRow.Cells[0].Value.ToString());
            }
            string upit = $"UPDATE public.\"Zaposlenik\" SET ime = '" + txtImeIzmjena.Text + "', prezime='" + txtPrezimeIzmjena.Text + "', " +
                "kontakt= '" + txtKontaktIzmjena.Text + "', email= '" + txtEmailIzmjena.Text + "' WHERE \"idZaposlenik\"= '" + id + "' ";
            NpgsqlCommand command = new NpgsqlCommand(upit, connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            connection.Close();
            DohvatiZaposlenike();
            dgvPopisZaposlenika.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void OcistiPolja()
        {
            txtIme.Clear();
            txtPrezime.Clear();
            txtKontakt.Clear();
            txtEmail.Clear();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO public.\"Zaposlenik\"(ime, prezime, kontakt, email" +
                ") VALUES('" + txtIme.Text + "', '" + txtPrezime.Text + "', '" + txtKontakt.Text + "', '" + txtEmail.Text  +"')", connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();
            DohvatiZaposlenike();
            connection.Close();
            OcistiPolja();
            dgvPopisZaposlenika.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void dgvPopisZaposlenika_SelectionChanged(object sender, EventArgs e)
        {
            panelIzmjena.BringToFront();
            PopuniSvePodatke();
        }

        private void FrmZaposlenici_Load(object sender, EventArgs e)
        {
            dgvPopisZaposlenika.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

    }
}
