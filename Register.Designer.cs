
namespace ClientReservasi_113
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.bt_simpan = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_hapus = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.dt_register = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_register)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(198, 78);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(315, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(198, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(315, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // bt_simpan
            // 
            this.bt_simpan.Location = new System.Drawing.Point(587, 78);
            this.bt_simpan.Name = "bt_simpan";
            this.bt_simpan.Size = new System.Drawing.Size(121, 27);
            this.bt_simpan.TabIndex = 6;
            this.bt_simpan.Text = "Simpan";
            this.bt_simpan.UseVisualStyleBackColor = true;
            this.bt_simpan.Click += new System.EventHandler(this.bt_simpan_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(587, 124);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(121, 27);
            this.bt_update.TabIndex = 7;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_hapus
            // 
            this.bt_hapus.Location = new System.Drawing.Point(587, 171);
            this.bt_hapus.Name = "bt_hapus";
            this.bt_hapus.Size = new System.Drawing.Size(121, 27);
            this.bt_hapus.TabIndex = 8;
            this.bt_hapus.Text = "Hapus";
            this.bt_hapus.UseVisualStyleBackColor = true;
            this.bt_hapus.Click += new System.EventHandler(this.bt_hapus_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(587, 217);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(121, 27);
            this.bt_clear.TabIndex = 9;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // dt_register
            // 
            this.dt_register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_register.Location = new System.Drawing.Point(74, 301);
            this.dt_register.Name = "dt_register";
            this.dt_register.RowHeadersWidth = 51;
            this.dt_register.RowTemplate.Height = 24;
            this.dt_register.Size = new System.Drawing.Size(634, 177);
            this.dt_register.TabIndex = 10;
            this.dt_register.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_register_CellContentClick);
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Items.AddRange(new object[] {
            "Admin",
            "Resepsionis"});
            this.cb_kategori.Location = new System.Drawing.Point(198, 220);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(315, 24);
            this.cb_kategori.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Text ini hanya sebagai penyimpan id sementara";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_kategori);
            this.Controls.Add(this.dt_register);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_hapus);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_simpan);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.dt_register)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button bt_simpan;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_hapus;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.DataGridView dt_register;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.TextBox textBox1;
    }
}