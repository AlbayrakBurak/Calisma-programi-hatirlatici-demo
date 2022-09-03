using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismaprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text == "" || sifre.Text == "")
            {
                MessageBox.Show("Kulllanıcı Adı veya Şifre boş geçilemez");
            }
            else
            {
                if (kullaniciAdi.Text == "hamzinski" && sifre.Text == "hamza" || kullaniciAdi.Text == "veys" && sifre.Text == "burak") 
                {
                    Form3 frm = new Form3();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış. Eğer üyeliğiniz yoksa iletişime geçiniz");

                }
            }
        }

        private void goster_CheckedChanged(object sender, EventArgs e)
        {
            if(goster.CheckState==CheckState.Checked)
            {
                sifre.UseSystemPasswordChar = true;
                goster.Text = "Gizle";
            }
            else if(goster.CheckState==CheckState.Unchecked)
            {
                sifre.UseSystemPasswordChar = false;
                goster.Text = "Goster";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            this.Close();
        }

        private void kullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                kullaniciAdi.Text = "veys";
                sifre.Text = "burak";
            }
        }
    }
}
