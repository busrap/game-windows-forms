namespace SehirTahminEtmeOyunu {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnHarfGir = new System.Windows.Forms.Button();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGirilenHarfler = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpOyunAlani = new System.Windows.Forms.GroupBox();
            this.btnOyunuBaslat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTahminEt);
            this.groupBox1.Controls.Add(this.txtKelime);
            this.groupBox1.Controls.Add(this.btnHarfGir);
            this.groupBox1.Controls.Add(this.lblKalanHak);
            this.groupBox1.Controls.Add(this.txtHarf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGirilenHarfler);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(912, 192);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(723, 29);
            this.btnTahminEt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(150, 44);
            this.btnTahminEt.TabIndex = 14;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.AcceptsReturn = true;
            this.txtKelime.Location = new System.Drawing.Point(492, 39);
            this.txtKelime.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(196, 30);
            this.txtKelime.TabIndex = 13;
            // 
            // btnHarfGir
            // 
            this.btnHarfGir.Location = new System.Drawing.Point(264, 29);
            this.btnHarfGir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnHarfGir.Name = "btnHarfGir";
            this.btnHarfGir.Size = new System.Drawing.Size(150, 44);
            this.btnHarfGir.TabIndex = 8;
            this.btnHarfGir.Text = "Harf Gir";
            this.btnHarfGir.UseVisualStyleBackColor = true;
            this.btnHarfGir.Click += new System.EventHandler(this.btnHarfGir_Click);
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Location = new System.Drawing.Point(260, 136);
            this.lblKalanHak.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(23, 25);
            this.lblKalanHak.TabIndex = 12;
            this.lblKalanHak.Text = "4";
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(30, 36);
            this.txtHarf.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(196, 30);
            this.txtHarf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kalan Yanlış Yapma Hakkınız :";
            // 
            // lblGirilenHarfler
            // 
            this.lblGirilenHarfler.AutoSize = true;
            this.lblGirilenHarfler.Location = new System.Drawing.Point(260, 103);
            this.lblGirilenHarfler.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGirilenHarfler.Name = "lblGirilenHarfler";
            this.lblGirilenHarfler.Size = new System.Drawing.Size(0, 25);
            this.lblGirilenHarfler.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Girilen Harfler  : ";
            // 
            // grpOyunAlani
            // 
            this.grpOyunAlani.Location = new System.Drawing.Point(15, 69);
            this.grpOyunAlani.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpOyunAlani.Name = "grpOyunAlani";
            this.grpOyunAlani.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpOyunAlani.Size = new System.Drawing.Size(912, 123);
            this.grpOyunAlani.TabIndex = 15;
            this.grpOyunAlani.TabStop = false;
            this.grpOyunAlani.Text = "Oyun Alanı";
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Location = new System.Drawing.Point(15, 15);
            this.btnOyunuBaslat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(912, 44);
            this.btnOyunuBaslat.TabIndex = 14;
            this.btnOyunuBaslat.Text = "Yeni Oyunu Başlat";
            this.btnOyunuBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOyunAlani);
            this.Controls.Add(this.btnOyunuBaslat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnHarfGir;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGirilenHarfler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpOyunAlani;
        private System.Windows.Forms.Button btnOyunuBaslat;
    }
}

