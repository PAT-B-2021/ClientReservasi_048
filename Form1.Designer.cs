
namespace ClientReservasi_113
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxTelpon = new System.Windows.Forms.TextBox();
            this.textBoxPesanan = new System.Windows.Forms.TextBox();
            this.textBoxIdLokasi = new System.Windows.Forms.TextBox();
            this.btsimpan = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.bthapus = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            this.cekLokasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailLokasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekLokasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailLokasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reservasi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Lokasi";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(231, 63);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(337, 22);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(231, 117);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(337, 22);
            this.textBoxNama.TabIndex = 6;
            // 
            // textBoxTelpon
            // 
            this.textBoxTelpon.Location = new System.Drawing.Point(231, 184);
            this.textBoxTelpon.Name = "textBoxTelpon";
            this.textBoxTelpon.Size = new System.Drawing.Size(337, 22);
            this.textBoxTelpon.TabIndex = 7;
            // 
            // textBoxPesanan
            // 
            this.textBoxPesanan.Location = new System.Drawing.Point(231, 242);
            this.textBoxPesanan.Name = "textBoxPesanan";
            this.textBoxPesanan.Size = new System.Drawing.Size(337, 22);
            this.textBoxPesanan.TabIndex = 8;
            // 
            // textBoxIdLokasi
            // 
            this.textBoxIdLokasi.Location = new System.Drawing.Point(231, 303);
            this.textBoxIdLokasi.Name = "textBoxIdLokasi";
            this.textBoxIdLokasi.Size = new System.Drawing.Size(337, 22);
            this.textBoxIdLokasi.TabIndex = 9;
            // 
            // btsimpan
            // 
            this.btsimpan.Location = new System.Drawing.Point(657, 117);
            this.btsimpan.Name = "btsimpan";
            this.btsimpan.Size = new System.Drawing.Size(118, 28);
            this.btsimpan.TabIndex = 10;
            this.btsimpan.Text = "Simpan";
            this.btsimpan.UseVisualStyleBackColor = true;
            this.btsimpan.Click += new System.EventHandler(this.btsimpan_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(657, 162);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(118, 28);
            this.btupdate.TabIndex = 11;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(657, 206);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(118, 28);
            this.bthapus.TabIndex = 12;
            this.bthapus.Text = "Hapus";
            this.bthapus.UseVisualStyleBackColor = true;
            this.bthapus.Click += new System.EventHandler(this.bthapus_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(657, 247);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(118, 28);
            this.btclear.TabIndex = 13;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(69, 361);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(706, 207);
            this.dtPemesanan.TabIndex = 14;
            this.dtPemesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellClick);
            // 
            // cekLokasiBindingSource
            // 
            this.cekLokasiBindingSource.DataSource = typeof(ServiceReservasi.CekLokasi);
            // 
            // detailLokasiBindingSource
            // 
            this.detailLokasiBindingSource.DataSource = typeof(ServiceReservasi.DetailLokasi);
            // 
            // pemesananBindingSource
            // 
            this.pemesananBindingSource.DataSource = typeof(ServiceReservasi.Pemesanan);
            // 
            // pemesananResponseBindingSource
            // 
            this.pemesananResponseBindingSource.DataSource = typeof(ClientReservasi_113.ServiceReference1.PemesananResponse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 596);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsimpan);
            this.Controls.Add(this.textBoxIdLokasi);
            this.Controls.Add(this.textBoxPesanan);
            this.Controls.Add(this.textBoxTelpon);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekLokasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailLokasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxTelpon;
        private System.Windows.Forms.TextBox textBoxPesanan;
        private System.Windows.Forms.TextBox textBoxIdLokasi;
        private System.Windows.Forms.Button btsimpan;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.DataGridView dtPemesanan;
        private System.Windows.Forms.BindingSource pemesananBindingSource;
        private System.Windows.Forms.BindingSource cekLokasiBindingSource;
        private System.Windows.Forms.BindingSource detailLokasiBindingSource;
        private System.Windows.Forms.BindingSource pemesananResponseBindingSource;
    }
}

