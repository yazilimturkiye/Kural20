using System; //yazlimturk
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // seslerin oynatılmasını sağlayan kütüphane.
using Microsoft.Win32;



//this.WindowState = FormWindowState.Minimized;
//notifyIcon1.ShowBalloonTip(1, "Bilgi", "Uygulama arkaplanda çalışmaya devam etmekte.", ToolTipIcon.Info);
//this.Hide();


namespace Kural20v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int mola = 0; // değiken mola verilir ise 1 olacak, verilmez ise 2 olacak, buna göre işlem yapılan mola değişkeni. Başlangıç değeri 0
        public static int verilen_mola = 0;
        public static int atlanan_mola = 0;
        public static int toplamgecen_sure = 0;
        public static SoundPlayer player = new SoundPlayer();
        string dizin = Application.StartupPath + "\\alarm.wav"; // alarm ses dosyası.

        private void Form1_Load(object sender, EventArgs e) // Form LOAD
        {
            durdur_buton.Enabled = false;
            toolStripMenuItem_Durdur.Enabled = false;
            toolStripMenuItem_Devam.Enabled = true;

        }

        private void baslat_buton_Click(object sender, EventArgs e) // başlatma butonu
        {
            sayac_timer.Start();
            mola_timer.Enabled = true;
            baslat_buton.Enabled = false;
            durdur_buton.Enabled = true;
            toolStripMenuItem_Durdur.Enabled = true;
            toolStripMenuItem_Devam.Enabled = false;
        }

        private void durdur_buton_Click(object sender, EventArgs e) // durdurma butonu
        {
            sayac_timer.Stop();
            durdur_buton.Enabled = false;
            baslat_buton.Enabled = true;
            toolStripMenuItem_Durdur.Enabled = false;
            toolStripMenuItem_Devam.Enabled = true;
        }

        private void sifirla_buton_Click(object sender, EventArgs e) //sıfırlama butonu
        {
            saniye.Text = "00";
            dakika.Text = "00";
            baslat_buton.Enabled = true;
            sayac_timer.Enabled = false;
            progressBar1.Value = 0;
            durdur_buton.Enabled = false;
        }

        private void sayac_timer_Tick(object sender, EventArgs e) // Timer1 yani sayaç timeri
        {
            mola = 0;
            if (int.Parse(saniye.Text) < 9)
            {
                saniye.Text = "0" + (int.Parse(saniye.Text) + 1).ToString();
                ikinokta.Visible = !ikinokta.Visible; // Dakika ve Saniye arasında duran iki noktanın yanıp sönmesi.
            }
            else
            {
                saniye.Text = (int.Parse(saniye.Text) + 1).ToString();
            }
            if (int.Parse(saniye.Text) == 60)
            {
                saniye.Text = "00";
                if (int.Parse(dakika.Text) < 9)
                {
                    dakika.Text = "0" + (int.Parse(dakika.Text) + 1).ToString();
                }
                else
                {
                    dakika.Text = (int.Parse(dakika.Text) + 1).ToString();
                }
                progressBar1.Value += 5;
            }
            if (int.Parse(dakika.Text) == 20) //dakika 20 olduğunda alarm çalışıcak.
            {
                sayac_timer.Stop();
                player.SoundLocation = dizin;
                player.PlayLooping();
                toplamgecen_sure += 20;
                AlarmForm alarmformu = new AlarmForm();
                alarmformu.ShowDialog();

            }
        }

        private void mola_timer_Tick(object sender, EventArgs e) //Timer2 yani mola detayları
        {
            verilen_mola_sayisi.Text = verilen_mola.ToString();
            atlanilan_mola_sayisi.Text = atlanan_mola.ToString();
            if (mola == 1) //ara verilmemis ise sayac islemine devam et ve detayı işle
            {
                player.Stop();
                toplamgecen_sure = 0;
                ara_vermeden_gecen_sure.Text = "0Dk";
                moladetay_listbox.Items.Add(DateTime.Now.ToShortDateString() + "                                  " + DateTime.Now.ToShortTimeString() + "                                           " + "Evet"); // mola detayını listbox'a yazdıran kod
                mola_timer.Enabled = false;

            }
            if (mola == 2) //ara verilmis ise sayacı durdur ve detayı işle
            {
                player.Stop();
                saniye.Text = "00";
                dakika.Text = "00";
                sayac_timer.Enabled = true;
                progressBar1.Value = 0;
                ara_vermeden_gecen_sure.Text = toplamgecen_sure.ToString() + "Dk";
                moladetay_listbox.Items.Add(DateTime.Now.ToShortDateString() + "                                  " + DateTime.Now.ToShortTimeString() + "                                           " + "Hayır");


            }
            if (verilen_mola == atlanan_mola)
            {
                goz_sagligi.Text = "Stabil";
                goz_sagligi.ForeColor = Color.Black;
            }
            else if (verilen_mola > atlanan_mola)
            {
                goz_sagligi.Text = "İyi";
                goz_sagligi.ForeColor = Color.Green;
            }
            else if (atlanan_mola > verilen_mola)
            {
                goz_sagligi.Text = "Kötü";
                goz_sagligi.ForeColor = Color.Red;
            }
            if (toplamgecen_sure > 39)
            {
                ara_vermeden_gecen_sure.ForeColor = Color.Red;
            }
            else if (toplamgecen_sure < 1)
            {
                ara_vermeden_gecen_sure.ForeColor = Color.Black;
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.yazilimturkiye.com");
        }

        private void toolStripMenuItem_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void toolStripMenuItem_Durdur_Click(object sender, EventArgs e)
        {
                sayac_timer.Stop();
                durdur_buton.Enabled = false;
                baslat_buton.Enabled = true;
                notifyIcon1.ShowBalloonTip(1, "Bilgi", "Sayac Durduruldu!", ToolTipIcon.Info);
                toolStripMenuItem_Devam.Enabled = true;
                toolStripMenuItem_Durdur.Enabled = false;

        }

        private void toolStripMenuItem_Devam_Click(object sender, EventArgs e)
        {
            sayac_timer.Start();
            mola_timer.Enabled = true;
            baslat_buton.Enabled = false;
            durdur_buton.Enabled = true;
            toolStripMenuItem_Durdur.Enabled = true;
            toolStripMenuItem_Devam.Enabled = false;
            notifyIcon1.ShowBalloonTip(1, "Bilgi", "Sayac Devam ediyor!", ToolTipIcon.Info);
        }

        private void button_ayarlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gün boyu bilgisayar başında çalışanlardan iseniz, gün içinde gözlerinizin dinlenmesi için kaç defa masa başından kalkıyorsunuz? Kural20 Göz Sağlığı Takip Uygulaması gün içinde size her 20 dakikada bir 20 metre uzağa 20 saniye boyunca bakmanız için uyarı veren bir ücretsiz masaüstü programıdır., ", "Kural20 Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
