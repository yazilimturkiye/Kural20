using System; //yazlimturk
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Kural20v2._0
{
    public partial class AlarmForm : Form
    {
        public AlarmForm()
        {
            InitializeComponent();
        }

        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            if (Form1.toplamgecen_sure == 0)
            {
                label1.Text = "20";
            }
            else
            {
                label1.Text = Form1.toplamgecen_sure.ToString();
            }

            timer1.Enabled = true;
            label6.Text = Form1.verilen_mola.ToString();
            label7.Text = Form1.atlanan_mola.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }

        private void mola_ver_buton_Click(object sender, EventArgs e)
        {

            Form1.mola = 1;
            Form1.verilen_mola += 1;
            Form form = Application.OpenForms["Form1"];
            if (form == null)
                form = new Form1();
            form.Show();
            this.Close();
        }

        private void mola_atlama_buton_Click(object sender, EventArgs e)
        {
            Form1.mola = 2;
            Form1.atlanan_mola += 1;
            this.Close();
        }

        private void muzikkapat_buton_Click(object sender, EventArgs e)
        {
            Form1.player.Stop();
        }

        private void AlarmForm_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void AlarmForm_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void AlarmForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private const int WS_SYSMENU = 0x80000; //form kontrol butonlarını gizler.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
    }
}
