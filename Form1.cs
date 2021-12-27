using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReservasi;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;

namespace ClientReservasi_113
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();

            TampilData();
            btupdate.Enabled = false;
            bthapus.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btsimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxID.Text;
            string NamaCustomer = textBoxNama.Text;
            string NoTelpon = textBoxTelpon.Text;
            int JumlahPemesanan = int.Parse(textBoxPesanan.Text);
            string IDLokasi = textBoxIdLokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IDLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxID.Text;
            string NamaCustomer = textBoxNama.Text;
            string NoTelpon = textBoxTelpon.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelpon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxID.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void TampilData()
        {
            var List = service.Pemesanan1();
            dtPemesanan.DataSource = List;
        }
        
        public void Clear()
        {
            textBoxID.Clear();
            textBoxNama.Clear();
            textBoxTelpon.Clear();
            textBoxPesanan.Clear();
            textBoxIdLokasi.Clear();

            textBoxPesanan.Enabled = true;
            textBoxIdLokasi.Enabled = true;

            btsimpan.Enabled = true;
            btupdate.Enabled = false;
            bthapus.Enabled = false;

            textBoxID.Enabled = true;
        }

        private void dtPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            textBoxNama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            textBoxTelpon.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);
            textBoxPesanan.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            textBoxIdLokasi.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);

            textBoxPesanan.Enabled = false;
            textBoxIdLokasi.Enabled = false;

            btupdate.Enabled = true;
            bthapus.Enabled = true;

            btsimpan.Enabled = false;
            textBoxID.Enabled = false;
        }
    }
}
