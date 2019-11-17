using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_Kutuphane
{
    public partial class Form1 : MetroForm
    {
        string[] kitaplar = { "Hikaye", "Roman", "Çocuk Kitabı", "Biyografi", "Tarih", "Mimari", "Bilim Kurgu", "Fantastik"};

        //void Temizle(Control ctrl)
        //{
        //    foreach (Control item in ctrl.Controls)
        //    {
        //        if (item is TextBox)
        //        {
        //            item.Text = "";
        //        }
        //        if (item is NumericUpDown)
        //        {
        //            item.Text.Min();
        //        }
        //        if (item is DateTimePicker)
        //        {
        //            item.Text.Min();
        //        }
        //        if (item is ComboBox)
        //        {
        //            item.Text = "";
        //        }
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kitaplar.Length; i++)
            {
                cmbTur.Items.Add(kitaplar[i]);
            }
        }

        private void txtKitapAdi_Click(object sender, EventArgs e)
        {
                
        }

        private void txtKitapAdi_Validating(object sender, CancelEventArgs e)
        {
            if (txtKitapAdi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtKitapAdi, "Bu alanı boş geçemezsin!");
            }            
        }

        private void txtYazarAdi_Click(object sender, EventArgs e)
        {

        }

        private void txtYazarAdi_Validated(object sender, EventArgs e)
        {
            if (txtYazarAdi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtYazarAdi, "Bu alanı boş geçemezsin!");
            }
        }

        private void txtISBNNo_Validated(object sender, EventArgs e)
        {
            if (txtISBNNo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtISBNNo, "Bu alanı boş geçemezsin!");
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Kutuphane ktp = new Kutuphane();
            ktp.KitapAdi = txtKitapAdi.Text;
            ktp.YazarAdi = txtYazarAdi.Text;
            ktp.YayinEvi = txtYayinEvi.Text;
            ktp.ISBN = txtISBNNo.Text;
            ktp.Tur = cmbTur.Text;
            ktp.SayfaSayisi = nmrSayfaSayisi.Text;
            ktp.BaskiSayisi = nmrBaskiSayisi.Text;
            ktp.BasimYili = dtBasimYili.Text;

            lstKitaplar.Items.Add(ktp);

            //Temizle(groupBox1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int i = lstKitaplar.SelectedIndex;

            ktp.KitapAdi = txtKitapAdi.Text;
            ktp.YazarAdi = txtYazarAdi.Text;
            ktp.YayinEvi = txtYayinEvi.Text;
            ktp.BaskiSayisi = nmrBaskiSayisi.Text;
            ktp.SayfaSayisi = nmrSayfaSayisi.Text;
            ktp.BasimYili = dtBasimYili.Text;
            ktp.Tur = cmbTur.Text;
            ktp.ISBN = txtISBNNo.Text;

            lstKitaplar.Items.RemoveAt(index);
            lstKitaplar.Items.Insert(index, ktp);            
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        Kutuphane ktp;
        int index = 0;

        private void tsmDuzenle_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen eleman seçiniz!");
                return;
            }

            ktp = (Kutuphane)lstKitaplar.SelectedItem;
            txtISBNNo.Text = ktp.ISBN;
            txtKitapAdi.Text = ktp.KitapAdi;
            txtYayinEvi.Text = ktp.YayinEvi;
            txtYazarAdi.Text = ktp.YazarAdi;
            cmbTur.Text = ktp.Tur;
            nmrSayfaSayisi.Text = ktp.SayfaSayisi;
            nmrBaskiSayisi.Text = ktp.BaskiSayisi;
            dtBasimYili.Text = ktp.BasimYili;

            index = lstKitaplar.SelectedIndex;
        }

        private void tsmSil_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen Eleman Seçiniz!");
                return;
            }
            lstKitaplar.Items.Remove(lstKitaplar.SelectedItem);
            MessageBox.Show("Kitabınız silindi.");
        }
    }
}
