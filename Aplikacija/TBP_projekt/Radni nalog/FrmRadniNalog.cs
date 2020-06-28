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
    public partial class FrmRadniNalog : MetroFramework.Forms.MetroForm
    {
        public FrmRadniNalog()
        {
            InitializeComponent();
            PopuniComboArtikli();
            OsvjeziRadneNaloge();
        }
        private void PopuniComboArtikli()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT naziv FROM public.\"Artikl\"";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            cmbArtikli.DataSource = bindingSource;
            cmbArtikli.DisplayMember = "naziv";
            npgsqlConnection.Close();
        }
        

        private void btnIzdajNalog_Click(object sender, EventArgs e)
        {
            string naziv = dgvPrikazArtikala.CurrentRow.Cells[2].Value.ToString();
            int stanje_id = int.Parse(dgvPrikazArtikala.CurrentRow.Cells[0].Value.ToString());
            FrmUnosRadnogNaloga frmUnosRadnogNaloga = new FrmUnosRadnogNaloga(naziv, stanje_id);
            frmUnosRadnogNaloga.ShowDialog();
            OsvjeziRadneNaloge();
        }

        private void cmbArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selektirani = cmbArtikli.Text;
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = $"SELECT sns.\"idStanjaNaSkladistu\" AS id_stanja, a.\"idArtikl\" AS ID, a.naziv AS Naziv, a.nabavna_cijena AS Cijena, " +
                $"a.min_kolicina AS MIN, a.max_kolicina AS MAX, " +
                "sns.trenutna_kolicina AS Trenutna_kolicina, sns.datum AS Datum " +
                "FROM public.\"Artikl\" a " +
                $"JOIN public.\"Stanje_na_skladistu\" sns ON sns.\"Artikl_id_narudzba_artikla\" = a.\"idArtikl\" " +
                $"WHERE a.naziv = '{selektirani}' AND sns.trenutna_kolicina > a.min_kolicina " +
                $"ORDER BY sns.datum ASC";
            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            dgvPrikazArtikala.DataSource = bindingSource;
            npgsqlConnection.Close();
        }

        private void btnPogledajStanje_Click(object sender, EventArgs e)
        {
            FrmStanjeNaSkladistu frmStanjeNaSkladistu = new FrmStanjeNaSkladistu();
            this.Hide();
            frmStanjeNaSkladistu.ShowDialog();
            this.Show();
        }

        private void OsvjeziRadneNaloge()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            string upit = "SELECT r.\"idRadni_nalog\" AS ID, art.naziv AS naziv_artikla, r.datum AS datum, r.opis AS Opis, st.kolicina AS Narucena_kolicina, " +
                "z.prezime as Prezime_zaposlenika, k.naziv AS Naziv_kupca " +
                "FROM public.\"Radni_nalog\" r " +
                "JOIN public.\"Stavka_artikla_na_RN\" st ON st.\"Radni_nalog_id_Radni_nalog\" = r.\"idRadni_nalog\" " +
                "JOIN public.\"Zaposlenik\" z ON z.\"idZaposlenik\" = r.\"Zaposlenik_id_zaposlenik\" " +
                "JOIN public.\"Kupac\" k ON k.\"idKupac\" = r.\"Kupac_id_kupac\" " +
                "JOIN public.\"Artikl\" art ON st.\"Stavka_Artikl_id_artikl\" = art.\"idArtikl\"";


            podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            DataTable podaciTablice = new DataTable();
            podaci.Fill(podaciTablice);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = podaciTablice;
            dgvRadniNalog.DataSource = bindingSource;
            npgsqlConnection.Close();
        }

        private void dgvPrikazArtikala_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrikazArtikala.Rows[0].Selected == true)
            {
                btnIzdajNalog.Enabled = true;
            }
            else
                btnIzdajNalog.Enabled = false;
        }
    }
}
