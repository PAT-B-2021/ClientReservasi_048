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
    public partial class Register : Form
    {

        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        public Register()
        {
            InitializeComponent();
            TampilData();
            textBox1.Visible = false;
            bt_update.Enabled = false;
            bt_hapus.Enabled = true;
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string kategori = cb_kategori.Text;
            string a = service.Register(username, password, kategori);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || cb_kategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string kategori = cb_kategori.Text;
            int id = Convert.ToInt32(textBox1.Text);
            string a = service.UpdateRegister(username, password, kategori, id);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || cb_kategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_hapus_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?",
                "Hapus Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = service.DeleteRegister(username);
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void TampilData()
        {
            var list = service.DataRegist();
            dt_register.DataSource = list;
        }

        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            cb_kategori.SelectedItem = null;

            bt_simpan.Enabled = true;
            bt_update.Enabled = false;
            bt_hapus.Enabled = false;
        }

        private void dt_register_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dt_register.Rows[e.RowIndex].Cells[0].Value);
            textBoxUsername.Text = Convert.ToString(dt_register.Rows[e.RowIndex].Cells[1].Value);
            textBoxPassword.Text = Convert.ToString(dt_register.Rows[e.RowIndex].Cells[2].Value);
            cb_kategori.Text = Convert.ToString(dt_register.Rows[e.RowIndex].Cells[3].Value);

            bt_update.Enabled = true;
            bt_hapus.Enabled = true;

            bt_simpan.Enabled = false;
        }
    }
}
