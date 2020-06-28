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
    public partial class FrmArtikli : MetroFramework.Forms.MetroForm
    {
        private int id;
        public FrmArtikli()
        {
            InitializeComponent();
            DohvatiArtikle();
        }

        public void DohvatiArtikle()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT * FROM public.\"Artikl\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            dgvArtikli.DataSource = bindingSource;
            npgsqlConnection.Close();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO public.\"Artikl\"(naziv, nabavna_cijena, min_kolicina, max_kolicina," +
                " ukupna_kolicina, jedinica_mjere) VALUES('" + txtNaziv.Text + "', '" + txtNabavnaCijena.Text + "', '" + txtMinKolicina.Text + "', '" + txtMaxKolicina.Text + "'," +
                " '" + txtUkupnaKolicina.Text + "', '" + txtJedinicaMjere.Text + "')", connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();
            DohvatiArtikle();
            connection.Close();
            OcistiPolja();
            dgvArtikli.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            if (dgvArtikli.CurrentRow != null)
            {
                id = int.Parse(dgvArtikli.CurrentRow.Cells[0].Value.ToString());
            }
            string upit = $"UPDATE public.\"Artikl\" SET naziv = '" + txtIzmjenaNaziv.Text + "', nabavna_cijena='" + txtIzmjenaNabavnaCijena.Text + "', " +
                "min_kolicina= '" + txtIzmjenaMinKol.Text + "', max_kolicina= '" + txtIzmjenaMaxKol.Text + "',ukupna_kolicina= '" + txtIzmjenaUkKol.Text + "', " +
                "jedinica_mjere= '" + txtIzmjenaJedMjere.Text + "' WHERE \"idArtikl\"= '" + id + "' ";
            NpgsqlCommand command = new NpgsqlCommand(upit, connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            connection.Close();
            DohvatiArtikle();
            dgvArtikli.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

        private void OcistiPolja()
        {
            txtNaziv.Clear();
            txtNabavnaCijena.Clear();
            txtMinKolicina.Clear();
            txtMaxKolicina.Clear();
            txtUkupnaKolicina.Clear();
            txtJedinicaMjere.Clear();
        }

        public void PopuniSvePodatke()
        {
            if (dgvArtikli.CurrentRow != null)
            {
                txtIzmjenaNaziv.Text = dgvArtikli.CurrentRow.Cells[1].Value.ToString();
                txtIzmjenaNabavnaCijena.Text = dgvArtikli.CurrentRow.Cells[2].Value.ToString();
                txtIzmjenaMinKol.Text = dgvArtikli.CurrentRow.Cells[3].Value.ToString();
                txtIzmjenaMaxKol.Text = dgvArtikli.CurrentRow.Cells[4].Value.ToString();
                txtIzmjenaUkKol.Text = dgvArtikli.CurrentRow.Cells[5].Value.ToString();
                txtIzmjenaJedMjere.Text = dgvArtikli.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void dgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            panelIzmjena.BringToFront();
            panelIzmjena.Visible = true;
            PopuniSvePodatke();
        }

        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            dgvArtikli.Rows[0].Selected = false;
            panelUnos.BringToFront();
        }

    }
}
