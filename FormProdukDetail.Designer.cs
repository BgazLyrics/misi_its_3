namespace KoneksiDatabase
{
    partial class FormProdukDetail
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
            this.txtNamaProduk = new System.Windows.Forms.TextBox();
            this.NamaProduk = new System.Windows.Forms.Label();
            this.NamaHarga = new System.Windows.Forms.Label();
            this.txtNamaHarga = new System.Windows.Forms.TextBox();
            this.NamaStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.deskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Produk";
            // 
            // txtNamaProduk
            // 
            this.txtNamaProduk.Location = new System.Drawing.Point(12, 87);
            this.txtNamaProduk.Name = "txtNamaProduk";
            this.txtNamaProduk.Size = new System.Drawing.Size(353, 22);
            this.txtNamaProduk.TabIndex = 1;
            // 
            // NamaProduk
            // 
            this.NamaProduk.AutoSize = true;
            this.NamaProduk.Location = new System.Drawing.Point(21, 56);
            this.NamaProduk.Name = "NamaProduk";
            this.NamaProduk.Size = new System.Drawing.Size(44, 16);
            this.NamaProduk.TabIndex = 2;
            this.NamaProduk.Text = "Nama";
            this.NamaProduk.Click += new System.EventHandler(this.label2_Click);
            // 
            // NamaHarga
            // 
            this.NamaHarga.AutoSize = true;
            this.NamaHarga.Location = new System.Drawing.Point(21, 125);
            this.NamaHarga.Name = "NamaHarga";
            this.NamaHarga.Size = new System.Drawing.Size(45, 16);
            this.NamaHarga.TabIndex = 4;
            this.NamaHarga.Text = "Harga";
            this.NamaHarga.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNamaHarga
            // 
            this.txtNamaHarga.Location = new System.Drawing.Point(12, 156);
            this.txtNamaHarga.Name = "txtNamaHarga";
            this.txtNamaHarga.Size = new System.Drawing.Size(353, 22);
            this.txtNamaHarga.TabIndex = 3;
            this.txtNamaHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaHarga_KeyPress);
            // 
            // NamaStok
            // 
            this.NamaStok.AutoSize = true;
            this.NamaStok.Location = new System.Drawing.Point(21, 192);
            this.NamaStok.Name = "NamaStok";
            this.NamaStok.Size = new System.Drawing.Size(34, 16);
            this.NamaStok.TabIndex = 6;
            this.NamaStok.Text = "Stok";
            this.NamaStok.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(12, 223);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(353, 22);
            this.txtStok.TabIndex = 5;
            this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStok_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kategori";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(179, 431);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(275, 431);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 289);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(351, 24);
            this.cmbKategori.TabIndex = 11;
            // 
            // deskripsi
            // 
            this.deskripsi.AutoSize = true;
            this.deskripsi.Location = new System.Drawing.Point(19, 334);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(64, 16);
            this.deskripsi.TabIndex = 12;
            this.deskripsi.Text = "Deskripsi";
            this.deskripsi.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(10, 353);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(353, 22);
            this.txtDeskripsi.TabIndex = 13;
            // 
            // FormProdukDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 477);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NamaStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.NamaHarga);
            this.Controls.Add(this.txtNamaHarga);
            this.Controls.Add(this.NamaProduk);
            this.Controls.Add(this.txtNamaProduk);
            this.Controls.Add(this.label1);
            this.Name = "FormProdukDetail";
            this.Text = "FormProdukDetail";
            this.Load += new System.EventHandler(this.FormProdukDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaProduk;
        private System.Windows.Forms.Label NamaProduk;
        private System.Windows.Forms.Label NamaHarga;
        private System.Windows.Forms.TextBox txtNamaHarga;
        private System.Windows.Forms.Label NamaStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label deskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
    }
}