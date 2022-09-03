using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //ses eklemek

namespace calismaprogram
{  
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
       
        private void gorevler_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           // Form2 frm1 = new Form2();
            //frm1.Show();
            // this.Hide();

        }
        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();

        int sayac = 0;
        int satır = 0;
        int sütun = 1;
        private void button1_Click(object sender, EventArgs e)
        
        {
             
        
            if (gorevler2.TextLength == 0 || saatler.TextLength == 0)
            {
                MessageBox.Show("Lütfen Seçim Yapın.");
            }
            else
            {
                satır++;
                sayac++;
                MessageBox.Show("Etkinlik Eklenmiştir.");
            
                for (int i = 1; i <= satır; i++)
                {
                    // Form2 frm2 = new Form2();
                    //frm2.yazı = this.gorevler.SelectedItem.ToString();
                    // frm2.ShowDialog();

                    
                    CheckBox ch = new CheckBox();
                    Label lbl = new Label();
                    ch.Text = this.gorevler2.Text; //checkbox isim kutusu nerden alınacagını soyledık
                    lbl.Text = this.saatler.Text;
                    lbl.Name = sayac.ToString();
                    ch.Name = sayac.ToString();
                    ch.Size = new Size(100, 17);
                    lbl.Size = new Size(34,13);
                    lbl.Location = new Point(183 * sütun, 46 * i);
                    ch.Location = new Point(6 * sütun, 46 * i);
                    Controls.Add(ch);
                    Controls.Add(lbl);
                    
                }
                if (satır == 6)
                {
                    satır = 0;
                    sütun++;
                }
                if (sayac == 5)
                {
                    button1.Enabled = false;
                }



            }
            timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
        }

        private void saatler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pc saati güncel
            label5.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (saatler.Text == label5.Text)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Users\burak\source\repos\calismaprogram\calismaprogram\Echo.wav";

                
                    player.Play();
                    MessageBox.Show("Etlinliğiniz Başlayacaktır...");

                
                timer2.Enabled = false;
                player.Stop();
                gorevler2.Text = " ";
                
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void saatler_TextChanged(object sender, EventArgs e)
        {

        }

        private void gorevler2_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
}

