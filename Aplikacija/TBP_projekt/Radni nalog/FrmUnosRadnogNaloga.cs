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
    public partial class FrmUnosRadnogNaloga : MetroFramework.Forms.MetroForm
    {
        private string nazivArtikla;
        private int stanje_id;
        public FrmUnosRadnogNaloga(string naziv, int stanje)
        {
            InitializeComponent();
            nazivArtikla = naziv;
            stanje_id = stanje;
            txtArtikl.Text = nazivArtikla;
            txtArtikl.Enabled = false;
            PopuniComboKupac();
            PopuniComboZaposlenik();
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
            cmbZaposlenik.DataSource = bindingSource;
            cmbZaposlenik.DisplayMember = "prezime";
            npgsqlConnection.Close();
        }
        private void PopuniComboKupac()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT naziv FROM public.\"Kupac\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            cmbKupac.DataSource = bindingSource;
            cmbKupac.DisplayMember = "naziv";
            npgsqlConnection.Close();
        }

        private void btnIzdajNalog_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string upitZaposlenik = "SELECT \"idZaposlenik\" FROM public.\"Zaposlenik\" WHERE prezime=" + "'" + cmbZaposlenik.Text + "'" + ";";
            NpgsqlCommand command33 = new NpgsqlCommand(upitZaposlenik, connection);
            int zaposlenik_id;
            using (NpgsqlDataReader dataReader3 = command33.ExecuteReader())
            {
                dataReader3.Read();
                zaposlenik_id = dataReader3.GetInt32(0);
            }

            string upitKupac = "SELECT \"idKupac\" FROM public.\"Kupac\" WHERE naziv=" + "'" + cmbKupac.Text + "'" + ";";
            NpgsqlCommand command34 = new NpgsqlCommand(upitKupac, connection);
            int kupac_id;
            using (NpgsqlDataReader dataReader4 = command34.ExecuteReader())
            {
                dataReader4.Read();
                kupac_id = dataReader4.GetInt32(0);
            }

            string upitArtikl = "SELECT \"idArtikl\" FROM public.\"Artikl\" WHERE naziv=" + "'" + txtArtikl.Text + "'" + ";";
            NpgsqlCommand command35 = new NpgsqlCommand(upitArtikl, connection);
            int artikl_id;
            using (NpgsqlDataReader dataReader4 = command35.ExecuteReader())
            {
                dataReader4.Read();
                artikl_id = dataReader4.GetInt32(0);
            }

            
            string d = $"{dtDatum.Value.Year}-{dtDatum.Value.Month}-{dtDatum.Value.Day}";
            DateTime datum = DateTime.Parse(d);

            try
            {
                string upit = $"SELECT public.funkcija_oduzimanje_sa_stanja({zaposlenik_id}, {kupac_id}, '{d}', '{txtOpis.Text}', '{txtKolicina.Text}', {artikl_id}, null, {stanje_id})";
                NpgsqlCommand command = new NpgsqlCommand(upit, connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show("Uspjesno ste izdali radni nalog!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ne moze se unijeti kolicina koja ce smanjiti ukupnu kolicinu ispod minimalne");
            }

            connection.Close();
            this.Close();
        }
    }
}
