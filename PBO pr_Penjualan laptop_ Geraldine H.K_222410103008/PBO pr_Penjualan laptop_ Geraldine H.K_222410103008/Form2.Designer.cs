namespace PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelNama = new Label();
            labelHarga = new Label();
            labelStok = new Label();
            txtNama = new TextBox();
            panel1 = new Panel();
            labelPenjualanLeptop = new Label();
            pictureBox1 = new PictureBox();
            txtHarga = new TextBox();
            txtStok = new TextBox();
            labelDataLaptop = new Label();
            btnSimpan = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(373, 133);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(53, 20);
            labelNama.TabIndex = 0;
            labelNama.Text = "NAMA";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(373, 200);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(59, 20);
            labelHarga.TabIndex = 1;
            labelHarga.Text = "HARGA";
            // 
            // labelStok
            // 
            labelStok.AutoSize = true;
            labelStok.Location = new Point(373, 258);
            labelStok.Name = "labelStok";
            labelStok.Size = new Size(44, 20);
            labelStok.TabIndex = 2;
            labelStok.Text = "STOK";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(454, 126);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(252, 27);
            txtNama.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(labelPenjualanLeptop);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 435);
            panel1.TabIndex = 4;
            // 
            // labelPenjualanLeptop
            // 
            labelPenjualanLeptop.AutoSize = true;
            labelPenjualanLeptop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPenjualanLeptop.Location = new Point(68, 278);
            labelPenjualanLeptop.Name = "labelPenjualanLeptop";
            labelPenjualanLeptop.Size = new Size(200, 28);
            labelPenjualanLeptop.TabIndex = 10;
            labelPenjualanLeptop.Text = "PENJUALAN LAPTOP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(454, 193);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(252, 27);
            txtHarga.TabIndex = 5;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(454, 251);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(252, 27);
            txtStok.TabIndex = 6;
            // 
            // labelDataLaptop
            // 
            labelDataLaptop.AutoSize = true;
            labelDataLaptop.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataLaptop.Location = new Point(482, 30);
            labelDataLaptop.Name = "labelDataLaptop";
            labelDataLaptop.Size = new Size(195, 38);
            labelDataLaptop.TabIndex = 7;
            labelDataLaptop.Text = "DATA LAPTOP";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.IndianRed;
            btnSimpan.Location = new Point(613, 344);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(labelDataLaptop);
            Controls.Add(txtStok);
            Controls.Add(txtHarga);
            Controls.Add(panel1);
            Controls.Add(txtNama);
            Controls.Add(labelStok);
            Controls.Add(labelHarga);
            Controls.Add(labelNama);
            Name = "Form2";
            Text = "transaksi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label labelHarga;
        private Label labelStok;
        private TextBox txtNama;
        private Panel panel1;
        private TextBox txtHarga;
        private TextBox txtStok;
        private Label labelDataLaptop;
        private Button btnSimpan;
        private Label labelPenjualanLeptop;
        private PictureBox pictureBox1;
    }
}