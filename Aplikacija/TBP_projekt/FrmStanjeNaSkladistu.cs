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
    public partial class FrmStanjeNaSkladistu : MetroFramework.Forms.MetroForm
    {
        public FrmStanjeNaSkladistu()
        {
            InitializeComponent();
            OsvjeziStanje();
        }

        private void OsvjeziStanje()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; User Id=admin; Password=admin; Database=TBP_Baza";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();

            //NpgsqlDataAdapter podaci = new NpgsqlDataAdapter();
            //string upit = "SELECT \"idArtikl\", naziv, nabavna_cijena, min_kolicina, max_kolicina, trenutna_kolicina, datum FROM public.\"Artikl\", public.\"Stanje_na_skladistu\"";
            string upit = "SELECT a.\"idArtikl\" AS ID, a.naziv AS Naziv, a.nabavna_cijena AS Cijena, a.min_kolicina AS MIN, a.max_kolicina AS MAX, " +
                "sns.trenutna_kolicina AS Trenutna_kolicina, sns.datum AS Datum " +
                "FROM public.\"Artikl\" a " +
                "JOIN public.\"Stanje_na_skladistu\" sns ON sns.\"Artikl_id_narudzba_artikla\" = a.\"idArtikl\"";



            NpgsqlDataAdapter podaci = new NpgsqlDataAdapter(upit,npgsqlConnection);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Reset();
            podaci.Fill(ds);
            dt = ds.Tables[0];
            dgvStanje.DataSource = dt;




            //podaci.SelectCommand = new NpgsqlCommand(upit, npgsqlConnection);
            //DataTable podaciTablice = new DataTable();
            //podaci.Fill(podaciTablice);

            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = podaciTablice;
            //dgvStanje.DataSource = bindingSource;
            //npgsqlConnection.Close();
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNarudzba frmNarudzba = new FrmNarudzba();
            frmNarudzba.ShowDialog();
        }

        private void btnRadniNalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRadniNalog frmRadniNalog = new FrmRadniNalog();
            frmRadniNalog.ShowDialog();
        }
    }
}
