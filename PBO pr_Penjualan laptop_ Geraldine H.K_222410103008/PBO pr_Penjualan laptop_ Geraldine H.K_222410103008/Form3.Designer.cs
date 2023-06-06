namespace PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008
{
    partial class Form3
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
            panel1 = new Panel();
            labelNamaLapt = new Label();
            labelIdentTransaksi = new Label();
            txtnamalaptop = new TextBox();
            txttidentitastransaksi = new TextBox();
            labeljudulIdenLapt = new Label();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 445);
            panel1.TabIndex = 0;
            // 
            // labelNamaLapt
            // 
            labelNamaLapt.AutoSize = true;
            labelNamaLapt.Location = new Point(329, 164);
            labelNamaLapt.Name = "labelNamaLapt";
            labelNamaLapt.Size = new Size(100, 20);
            labelNamaLapt.TabIndex = 1;
            labelNamaLapt.Text = "Nama Laptop";
            // 
            // labelIdentTransaksi
            // 
            labelIdentTransaksi.AutoSize = true;
            labelIdentTransaksi.Location = new Point(329, 242);
            labelIdentTransaksi.Name = "labelIdentTransaksi";
            labelIdentTransaksi.Size = new Size(129, 20);
            labelIdentTransaksi.TabIndex = 2;
            labelIdentTransaksi.Text = "Identitas Transaksi";
            // 
            // txtnamalaptop
            // 
            txtnamalaptop.Location = new Point(470, 164);
            txtnamalaptop.Name = "txtnamalaptop";
            txtnamalaptop.Size = new Size(242, 27);
            txtnamalaptop.TabIndex = 3;
            // 
            // txttidentitastransaksi
            // 
            txttidentitastransaksi.Location = new Point(470, 235);
            txttidentitastransaksi.Name = "txttidentitastransaksi";
            txttidentitastransaksi.Size = new Size(242, 27);
            txttidentitastransaksi.TabIndex = 4;
            // 
            // labeljudulIdenLapt
            // 
            labeljudulIdenLapt.AutoSize = true;
            labeljudulIdenLapt.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labeljudulIdenLapt.Location = new Point(470, 45);
            labeljudulIdenLapt.Name = "labeljudulIdenLapt";
            labeljudulIdenLapt.Size = new Size(185, 33);
            labeljudulIdenLapt.TabIndex = 5;
            labeljudulIdenLapt.Text = "Transaksi";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.IndianRed;
            btnSimpan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSimpan.Location = new Point(607, 334);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(105, 31);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(labeljudulIdenLapt);
            Controls.Add(txttidentitastransaksi);
            Controls.Add(txtnamalaptop);
            Controls.Add(labelIdentTransaksi);
            Controls.Add(labelNamaLapt);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelNamaLapt;
        private Label labelIdentTransaksi;
        private TextBox txtnamalaptop;
        private TextBox txttidentitastransaksi;
        private Label labeljudulIdenLapt;
        private Button btnSimpan;
    }
}