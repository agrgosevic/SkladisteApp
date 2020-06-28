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
    public partial class FrmNarudzba : MetroFramework.Forms.MetroForm
    {
        
        public FrmNarudzba()
        {
            InitializeComponent();
            OsvjeziStanje();
            OsvjeziNarudzbe();
        }

        private void btnUnosNarudzbe_Click(object sender, EventArgs e)
        {
            string naziv = dgvArtikliZaNarudzbu.CurrentRow.Cells[1].Value.ToString();
            FrmUnosNarudzbe frmUnosNarudzbe = new FrmUnosNarudzbe(naziv);
            frmUnosNarudzbe.ShowDialog();
            OsvjeziNarudzbe();
        }

        private void OsvjeziStanje()
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
            dgvArtikliZaNarudzbu.DataSource = bindingSource;
            npgsqlConnection.Close();
        }

        private void btnPogledajStanje_Click(object sender, EventArgs e)
        {
            FrmStanjeNaSkladistu frmStanjeNaSkladistu = new FrmStanjeNaSkladistu();
            this.Hide();
            frmStanjeNaSkladistu.ShowDialog();
            this.Show();
        }

        private void OsvjeziNarudzbe()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT n.\"idNarudzba\" AS ID, art.naziv AS naziv_artikla, n.datum AS datum, n.opis AS Opis, nara.kolicina AS Narucena_kolicina, " +
                "z.prezime as Prezime_zaposlenika, d.naziv AS Naziv_dobavljaca " +
                "FROM public.\"Narudzba\" n " +
                "JOIN public.\"Narudzba_artikla\" nara ON nara.\"Narudzba_id_narudzba\" = n.\"idNarudzba\" " +
                "JOIN public.\"Zaposlenik\" z ON z.\"idZaposlenik\" = n.\"Zaposlenik_id_zaposlenik\" " +
                "JOIN public.\"Dobavljac\" d ON d.\"idDobavljac\" = n.\"Dobavljac_id_dobavljac\" " +
                "JOIN public.\"Artikl\" art ON nara.\"Artikl_id_artikl\" = art.\"idArtikl\"";



            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            dgvNarudzbe.DataSource = bindingSource;
            npgsqlConnection.Close();
        }
    }
}
