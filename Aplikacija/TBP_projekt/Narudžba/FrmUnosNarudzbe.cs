using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TBP_projekt
{
    public partial class FrmUnosNarudzbe : MetroFramework.Forms.MetroForm
    {
        //KonekcijaNaBazu konekcija;
        int zaposlenik;
        public FrmUnosNarudzbe(string artiklNaziv)
        {
            InitializeComponent();
            txtNazivArtikla.Enabled = false;
            PopuniComboZaposlenik();
            PopuniComboDobavljaca();
            txtNazivArtikla.Text = artiklNaziv;
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
        }

        private void PopuniComboZaposlenik()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT prezime FROM public.\"Zaposlenik\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            cmbZaposlenici.DataSource = bindingSource;
            cmbZaposlenici.DisplayMember = "prezime";
            npgsqlConnection.Close();
        }

        private void PopuniComboDobavljaca()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT naziv FROM public.\"Dobavljac\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            cmbDobavljaci.DataSource = bindingSource;
            cmbDobavljaci.DisplayMember = "naziv";
            npgsqlConnection.Close();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string upitZaposlenik = "SELECT \"idZaposlenik\" FROM public.\"Zaposlenik\" WHERE prezime=" + "'" + cmbZaposlenici.Text + "'" + ";";
            NpgsqlCommand command33 = new NpgsqlCommand(upitZaposlenik, connection);
            int zaposlenik_id;
            using (NpgsqlDataReader dataReader3 = command33.ExecuteReader())
            {
                dataReader3.Read();
                zaposlenik_id = dataReader3.GetInt32(0);
            }

            string upitDobavljac = "SELECT \"idDobavljac\" FROM public.\"Dobavljac\" WHERE naziv=" + "'" + cmbDobavljaci.Text + "'" + ";";
            NpgsqlCommand command34 = new NpgsqlCommand(upitDobavljac, connection);
            int dobavljac_id;
            using (NpgsqlDataReader dataReader4 = command34.ExecuteReader())
            {
                dataReader4.Read();
                dobavljac_id = dataReader4.GetInt32(0);
            }

            string upitArtikl = "SELECT \"idArtikl\" FROM public.\"Artikl\" WHERE naziv=" + "'" + txtNazivArtikla.Text + "'" + ";";
            NpgsqlCommand command35 = new NpgsqlCommand(upitArtikl, connection);
            int artikl_id;
            using (NpgsqlDataReader dataReader4 = command35.ExecuteReader())
            {
                dataReader4.Read();
                artikl_id = dataReader4.GetInt32(0);
            }

            string upitNarudzba = "SELECT \"idNarudzba\" FROM public.\"Narudzba\" ORDER BY \"idNarudzba\" DESC LIMIT 1";
            NpgsqlCommand command36 = new NpgsqlCommand(upitNarudzba, connection);
            int narudzba_id;
            using (NpgsqlDataReader dataReader4 = command36.ExecuteReader())
            {
                dataReader4.Read();
                narudzba_id = dataReader4.GetInt32(0);
            }

            
            string d = $"{dtDatum.Value.Year}-{dtDatum.Value.Month}-{dtDatum.Value.Day}";
            DateTime datum = DateTime.Parse(d);

            try
            {
                string upit = $"SELECT public.funkcija_dodavanje_narudzbe({zaposlenik_id}, {dobavljac_id}, '{d}', '{txtOpis.Text}', '{txtKolicina.Text}', {artikl_id})";
                NpgsqlCommand command = new NpgsqlCommand(upit, connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show("Uspjesno ste unijeli narudzbu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unesena kolicina mora biti veca od definirane minimalne kolicine i manja od maksimalne kolicina tog artikla!");
            }

            connection.Close();
            this.Close();
        }


    }
}
