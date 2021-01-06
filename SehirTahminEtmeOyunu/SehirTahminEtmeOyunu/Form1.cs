using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirTahminEtmeOyunu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string[] sehirlerListesi = { "İstanbul", "Ankara", "İzmir", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };

        string bulunacakSehirIsmi = "";
        int bulunanHarfSayisi = 0;
        int kalanHak = 4;

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e) {
            btnHarfGir.Enabled = false;
            btnTahminEt.Enabled = false;
        }

        void Resetle() {
            bulunanHarfSayisi = 0;
            btnHarfGir.Enabled = true;
            btnTahminEt.Enabled = true;
            lblGirilenHarfler.Text = "";
            kalanHak = 4;
            lblKalanHak.Text = kalanHak.ToString();

            YeniSehirSec();

            grpOyunAlani.Controls.Clear();
        }

        private void YeniSehirSec() {
            int randomSayi = rnd.Next(0, sehirlerListesi.Length);
            bulunacakSehirIsmi = sehirlerListesi[randomSayi];
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e) {
            Resetle();

            for (int i = 0; i < bulunacakSehirIsmi.Length; i++) {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Width = 20;
                lbl.Height = 20;
                lbl.Location = new Point(30 * i + 40, 30);
                lbl.Text = bulunacakSehirIsmi[i].ToString();
                lbl.BackColor = Color.Red;
                lbl.ForeColor = Color.Red;
                grpOyunAlani.Controls.Add(lbl);
            }
        }

        private void btnHarfGir_Click(object sender, EventArgs e) {
            bool harfVarMi = false;

            if (txtHarf.Text.Length != 1) {
                MessageBox.Show("Lütfen tek harf giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (lblGirilenHarfler.Text.Contains(txtHarf.Text)) {
                    MessageBox.Show("Bu harfi daha önce girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtHarf.Text = "";
                    txtHarf.Focus();
                    return;
                }

                foreach (Control item in grpOyunAlani.Controls) {
                    if (item is Label) {
                        Label lbl = item as Label;
                        if (lbl.Text.ToLower() == txtHarf.Text.ToLower()) {
                            lbl.ForeColor = Color.Black;
                            lbl.BackColor = Color.LightGreen;

                            harfVarMi = true;
                            bulunanHarfSayisi++;
                        }
                    }
                }
            }

            if (!harfVarMi) {
                kalanHak--;
                lblKalanHak.Text = kalanHak.ToString();

                if (kalanHak == 0) {
                    btnHarfGir.Enabled = false;
                    btnTahminEt.Enabled = false;
                    MessageBox.Show("Oyun Bitti, kaybettiniz.Oyunu Tekrar başlatınız!\n Cevap : " + bulunacakSehirIsmi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            lblGirilenHarfler.Text += txtHarf.Text + "  ";

            if (bulunanHarfSayisi == bulunacakSehirIsmi.Length) {
                btnHarfGir.Enabled = false;
                btnTahminEt.Enabled = false;
                MessageBox.Show("Oyun Bitti, kazandınız.Tebrikler...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtHarf.Text = "";
            txtHarf.Focus();
        }

        private void btnTahminEt_Click(object sender, EventArgs e) {
            if (bulunacakSehirIsmi.ToLower() == txtKelime.Text.ToLower()) {
                foreach (Control item in grpOyunAlani.Controls) {
                    if (item is Label) {
                        Label lbl = item as Label;
                        lbl.ForeColor = Color.Black;
                        lbl.BackColor = Color.LightGreen;
                    }
                }

                MessageBox.Show("Oyun Bitti. Tebrikler Kazandınız. Yeni Oyun için yeni kelime giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Oyun Bitti. Kaybettiniz. Yeni Oyun için yeni kelime giriniz. \n Cevap : " + bulunacakSehirIsmi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnHarfGir.Enabled = false;
            btnTahminEt.Enabled = false;
        }
    }
}
