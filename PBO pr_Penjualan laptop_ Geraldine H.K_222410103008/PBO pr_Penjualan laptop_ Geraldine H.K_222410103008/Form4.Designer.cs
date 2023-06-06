namespace PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTransaksi = new TextBox();
            txtLaptopyangdibeli = new TextBox();
            txtStokyangcibeli = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 426);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 138);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Transaksi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 210);
            label2.Name = "label2";
            label2.Size = new Size(56, 40);
            label2.TabIndex = 2;
            label2.Text = "Jenis \r\nLaptop";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 291);
            label3.Name = "label3";
            label3.Size = new Size(78, 40);
            label3.TabIndex = 3;
            label3.Text = "Stok yang \r\nDibeli";
            // 
            // txtTransaksi
            // 
            txtTransaksi.Location = new Point(465, 138);
            txtTransaksi.Name = "txtTransaksi";
            txtTransaksi.Size = new Size(238, 27);
            txtTransaksi.TabIndex = 4;
            // 
            // txtLaptopyangdibeli
            // 
            txtLaptopyangdibeli.Location = new Point(465, 207);
            txtLaptopyangdibeli.Name = "txtLaptopyangdibeli";
            txtLaptopyangdibeli.Size = new Size(238, 27);
            txtLaptopyangdibeli.TabIndex = 5;
            // 
            // txtStokyangcibeli
            // 
            txtStokyangcibeli.Location = new Point(465, 288);
            txtStokyangcibeli.Name = "txtStokyangcibeli";
            txtStokyangcibeli.Size = new Size(238, 27);
            txtStokyangcibeli.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(609, 364);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(433, 54);
            label4.Name = "label4";
            label4.Size = new Size(303, 33);
            label4.TabIndex = 8;
            label4.Text = "DETAIL TRANSAKSI";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtStokyangcibeli);
            Controls.Add(txtLaptopyangdibeli);
            Controls.Add(txtTransaksi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTransaksi;
        private TextBox txtLaptopyangdibeli;
        private TextBox txtStokyangcibeli;
        private Button button1;
        private Label label4;
    }
}