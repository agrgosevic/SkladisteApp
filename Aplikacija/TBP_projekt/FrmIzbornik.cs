using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_projekt
{
    public partial class FrmIzbornik : MetroFramework.Forms.MetroForm
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmZaposlenici frmZaposlenici = new FrmZaposlenici();
            this.Hide();
            frmZaposlenici.ShowDialog();
            this.Show();
        }

        private void btnDobavljaci_Click(object sender, EventArgs e)
        {
            FrmDobavljaci frmDobavljaci = new FrmDobavljaci();
            this.Hide();
            frmDobavljaci.ShowDialog();
            this.Show();
        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            FrmKupci frmKupci = new FrmKupci();
            this.Hide();
            frmKupci.ShowDialog();
            this.Show();
        }

        private void btnStanjeNaSkladistu_Click(object sender, EventArgs e)
        {
            FrmStanjeNaSkladistu frmStanjeNaSkladistu = new FrmStanjeNaSkladistu();
            this.Hide();
            frmStanjeNaSkladistu.ShowDialog();
            this.Show();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            FrmArtikli frmArtikli = new FrmArtikli();
            this.Hide();
            frmArtikli.ShowDialog();
            this.Show();
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            FrmNarudzba frmNarudzba = new FrmNarudzba();
            this.Hide();
            frmNarudzba.ShowDialog();
            this.Show();
        }

        private void btnRadniNalog_Click(object sender, EventArgs e)
        {
            FrmRadniNalog frmRadniNalog = new FrmRadniNalog();
            this.Hide();
            frmRadniNalog.ShowDialog();
            this.Show();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
