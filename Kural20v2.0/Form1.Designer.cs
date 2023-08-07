namespace Kural20v2._0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dakika = new System.Windows.Forms.Label();
            this.ikinokta = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.Label();
            this.baslat_buton = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.durdur_buton = new System.Windows.Forms.Button();
            this.sifirla_buton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Durum_grup = new System.Windows.Forms.GroupBox();
            this.ara_vermeden_gecen_sure = new System.Windows.Forms.Label();
            this.goz_sagligi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.atlanilan_mola_sayisi = new System.Windows.Forms.Label();
            this.verilen_mola_sayisi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Sayac_grup = new System.Windows.Forms.GroupBox();
            this.moladetay_grup = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.moladetay_listbox = new System.Windows.Forms.ListBox();
            this.sayac_timer = new System.Windows.Forms.Timer(this.components);
            this.mola_timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Durdur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Devam = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ayarlar = new System.Windows.Forms.Button();
            this.Durum_grup.SuspendLayout();
            this.Sayac_grup.SuspendLayout();
            this.moladetay_grup.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dakika
            // 
            this.dakika.AutoSize = true;
            this.dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakika.Location = new System.Drawing.Point(81, 36);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(104, 73);
            this.dakika.TabIndex = 3;
            this.dakika.Text = "00";
            // 
            // ikinokta
            // 
            this.ikinokta.AutoSize = true;
            this.ikinokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ikinokta.Location = new System.Drawing.Point(193, 54);
            this.ikinokta.Name = "ikinokta";
            this.ikinokta.Size = new System.Drawing.Size(29, 42);
            this.ikinokta.TabIndex = 4;
            this.ikinokta.Text = ":";
            // 
            // saniye
            // 
            this.saniye.AutoSize = true;
            this.saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniye.Location = new System.Drawing.Point(232, 36);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(104, 73);
            this.saniye.TabIndex = 5;
            this.saniye.Text = "00";
            // 
            // baslat_buton
            // 
            this.baslat_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat_buton.ImageIndex = 0;
            this.baslat_buton.ImageList = this.ımageList1;
            this.baslat_buton.Location = new System.Drawing.Point(6, 115);
            this.baslat_buton.Name = "baslat_buton";
            this.baslat_buton.Size = new System.Drawing.Size(161, 50);
            this.baslat_buton.TabIndex = 6;
            this.baslat_buton.UseVisualStyleBackColor = true;
            this.baslat_buton.Click += new System.EventHandler(this.baslat_buton_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "start.fw.png");
            this.ımageList1.Images.SetKeyName(1, "reset.fw.png");
            this.ımageList1.Images.SetKeyName(2, "stop.fw.png");
            this.ımageList1.Images.SetKeyName(3, "ayarlar.fw.png");
            this.ımageList1.Images.SetKeyName(4, "kapatbuton1.fw.png");
            this.ımageList1.Images.SetKeyName(5, "kucultbuton1.fw.png");
            this.ımageList1.Images.SetKeyName(6, "ayarlar.png");
            // 
            // durdur_buton
            // 
            this.durdur_buton.ImageIndex = 2;
            this.durdur_buton.ImageList = this.ımageList1;
            this.durdur_buton.Location = new System.Drawing.Point(173, 115);
            this.durdur_buton.Name = "durdur_buton";
            this.durdur_buton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.durdur_buton.Size = new System.Drawing.Size(66, 50);
            this.durdur_buton.TabIndex = 7;
            this.durdur_buton.UseVisualStyleBackColor = true;
            this.durdur_buton.Click += new System.EventHandler(this.durdur_buton_Click);
            // 
            // sifirla_buton
            // 
            this.sifirla_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirla_buton.ImageIndex = 1;
            this.sifirla_buton.ImageList = this.ımageList1;
            this.sifirla_buton.Location = new System.Drawing.Point(245, 115);
            this.sifirla_buton.Name = "sifirla_buton";
            this.sifirla_buton.Size = new System.Drawing.Size(159, 50);
            this.sifirla_buton.TabIndex = 8;
            this.sifirla_buton.UseVisualStyleBackColor = true;
            this.sifirla_buton.Click += new System.EventHandler(this.sifirla_buton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(105, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dakika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(255, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Saniye";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Crimson;
            this.progressBar1.Location = new System.Drawing.Point(0, 122);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(434, 6);
            this.progressBar1.TabIndex = 12;
            // 
            // Durum_grup
            // 
            this.Durum_grup.BackColor = System.Drawing.Color.Transparent;
            this.Durum_grup.Controls.Add(this.ara_vermeden_gecen_sure);
            this.Durum_grup.Controls.Add(this.goz_sagligi);
            this.Durum_grup.Controls.Add(this.label10);
            this.Durum_grup.Controls.Add(this.label9);
            this.Durum_grup.Controls.Add(this.atlanilan_mola_sayisi);
            this.Durum_grup.Controls.Add(this.verilen_mola_sayisi);
            this.Durum_grup.Controls.Add(this.label8);
            this.Durum_grup.Controls.Add(this.label7);
            this.Durum_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Durum_grup.Location = new System.Drawing.Point(12, 317);
            this.Durum_grup.Name = "Durum_grup";
            this.Durum_grup.Size = new System.Drawing.Size(410, 143);
            this.Durum_grup.TabIndex = 13;
            this.Durum_grup.TabStop = false;
            // 
            // ara_vermeden_gecen_sure
            // 
            this.ara_vermeden_gecen_sure.AutoSize = true;
            this.ara_vermeden_gecen_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara_vermeden_gecen_sure.Location = new System.Drawing.Point(201, 106);
            this.ara_vermeden_gecen_sure.Name = "ara_vermeden_gecen_sure";
            this.ara_vermeden_gecen_sure.Size = new System.Drawing.Size(112, 16);
            this.ara_vermeden_gecen_sure.TabIndex = 8;
            this.ara_vermeden_gecen_sure.Text = "Hesaplanıyor...";
            // 
            // goz_sagligi
            // 
            this.goz_sagligi.AutoSize = true;
            this.goz_sagligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goz_sagligi.Location = new System.Drawing.Point(153, 76);
            this.goz_sagligi.Name = "goz_sagligi";
            this.goz_sagligi.Size = new System.Drawing.Size(47, 16);
            this.goz_sagligi.TabIndex = 7;
            this.goz_sagligi.Text = "Stabil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ara Vermeden Geçilen Süre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Göz Sağlığı Durumu :";
            // 
            // atlanilan_mola_sayisi
            // 
            this.atlanilan_mola_sayisi.AutoSize = true;
            this.atlanilan_mola_sayisi.Location = new System.Drawing.Point(305, 46);
            this.atlanilan_mola_sayisi.Name = "atlanilan_mola_sayisi";
            this.atlanilan_mola_sayisi.Size = new System.Drawing.Size(11, 16);
            this.atlanilan_mola_sayisi.TabIndex = 3;
            this.atlanilan_mola_sayisi.Text = "-";
            // 
            // verilen_mola_sayisi
            // 
            this.verilen_mola_sayisi.AutoSize = true;
            this.verilen_mola_sayisi.Location = new System.Drawing.Point(90, 46);
            this.verilen_mola_sayisi.Name = "verilen_mola_sayisi";
            this.verilen_mola_sayisi.Size = new System.Drawing.Size(11, 16);
            this.verilen_mola_sayisi.TabIndex = 2;
            this.verilen_mola_sayisi.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Atlanılan Mola Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Verilen Mola Sayısı";
            // 
            // Sayac_grup
            // 
            this.Sayac_grup.BackColor = System.Drawing.Color.Transparent;
            this.Sayac_grup.Controls.Add(this.dakika);
            this.Sayac_grup.Controls.Add(this.ikinokta);
            this.Sayac_grup.Controls.Add(this.label5);
            this.Sayac_grup.Controls.Add(this.label6);
            this.Sayac_grup.Controls.Add(this.saniye);
            this.Sayac_grup.Controls.Add(this.baslat_buton);
            this.Sayac_grup.Controls.Add(this.durdur_buton);
            this.Sayac_grup.Controls.Add(this.sifirla_buton);
            this.Sayac_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sayac_grup.Location = new System.Drawing.Point(12, 134);
            this.Sayac_grup.Name = "Sayac_grup";
            this.Sayac_grup.Size = new System.Drawing.Size(410, 177);
            this.Sayac_grup.TabIndex = 14;
            this.Sayac_grup.TabStop = false;
            // 
            // moladetay_grup
            // 
            this.moladetay_grup.BackColor = System.Drawing.Color.Transparent;
            this.moladetay_grup.Controls.Add(this.label14);
            this.moladetay_grup.Controls.Add(this.label13);
            this.moladetay_grup.Controls.Add(this.label12);
            this.moladetay_grup.Controls.Add(this.moladetay_listbox);
            this.moladetay_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.moladetay_grup.Location = new System.Drawing.Point(12, 466);
            this.moladetay_grup.Name = "moladetay_grup";
            this.moladetay_grup.Size = new System.Drawing.Size(410, 210);
            this.moladetay_grup.TabIndex = 15;
            this.moladetay_grup.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Mola";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Saat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tarih";
            // 
            // moladetay_listbox
            // 
            this.moladetay_listbox.FormattingEnabled = true;
            this.moladetay_listbox.ItemHeight = 16;
            this.moladetay_listbox.Location = new System.Drawing.Point(14, 38);
            this.moladetay_listbox.Name = "moladetay_listbox";
            this.moladetay_listbox.ScrollAlwaysVisible = true;
            this.moladetay_listbox.Size = new System.Drawing.Size(378, 148);
            this.moladetay_listbox.TabIndex = 0;
            // 
            // sayac_timer
            // 
            this.sayac_timer.Interval = 10;
            this.sayac_timer.Tick += new System.EventHandler(this.sayac_timer_Tick);
            // 
            // mola_timer
            // 
            this.mola_timer.Tick += new System.EventHandler(this.mola_timer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Kural20 Göz Sağlığı Uygulaması";
            this.notifyIcon1.BalloonTipTitle = "Kural20";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Kural20";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Kapat,
            this.toolStripMenuItem_Durdur,
            this.toolStripMenuItem_Devam});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // toolStripMenuItem_Kapat
            // 
            this.toolStripMenuItem_Kapat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_Kapat.Image")));
            this.toolStripMenuItem_Kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_Kapat.Name = "toolStripMenuItem_Kapat";
            this.toolStripMenuItem_Kapat.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_Kapat.Text = "Kapat";
            this.toolStripMenuItem_Kapat.Click += new System.EventHandler(this.toolStripMenuItem_Kapat_Click);
            // 
            // toolStripMenuItem_Durdur
            // 
            this.toolStripMenuItem_Durdur.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_Durdur.Image")));
            this.toolStripMenuItem_Durdur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_Durdur.Name = "toolStripMenuItem_Durdur";
            this.toolStripMenuItem_Durdur.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_Durdur.Text = "Durdur";
            this.toolStripMenuItem_Durdur.Click += new System.EventHandler(this.toolStripMenuItem_Durdur_Click);
            // 
            // toolStripMenuItem_Devam
            // 
            this.toolStripMenuItem_Devam.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_Devam.Image")));
            this.toolStripMenuItem_Devam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_Devam.Name = "toolStripMenuItem_Devam";
            this.toolStripMenuItem_Devam.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_Devam.Text = "Devam Et";
            this.toolStripMenuItem_Devam.Click += new System.EventHandler(this.toolStripMenuItem_Devam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Göz Sağlığı Takip Uygulaması";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(306, 679);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 16);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yazilimturkiye.com";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(117, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "v3.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kural20";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 120);
            this.label4.TabIndex = 28;
            // 
            // button_ayarlar
            // 
            this.button_ayarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ayarlar.ImageIndex = 6;
            this.button_ayarlar.ImageList = this.ımageList1;
            this.button_ayarlar.Location = new System.Drawing.Point(12, 63);
            this.button_ayarlar.Name = "button_ayarlar";
            this.button_ayarlar.Size = new System.Drawing.Size(50, 50);
            this.button_ayarlar.TabIndex = 29;
            this.button_ayarlar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 704);
            this.Controls.Add(this.button_ayarlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moladetay_grup);
            this.Controls.Add(this.Sayac_grup);
            this.Controls.Add(this.Durum_grup);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule20";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Durum_grup.ResumeLayout(false);
            this.Durum_grup.PerformLayout();
            this.Sayac_grup.ResumeLayout(false);
            this.Sayac_grup.PerformLayout();
            this.moladetay_grup.ResumeLayout(false);
            this.moladetay_grup.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dakika;
        private System.Windows.Forms.Label ikinokta;
        private System.Windows.Forms.Label saniye;
        private System.Windows.Forms.Button baslat_buton;
        private System.Windows.Forms.Button durdur_buton;
        private System.Windows.Forms.Button sifirla_buton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox Durum_grup;
        private System.Windows.Forms.GroupBox Sayac_grup;
        private System.Windows.Forms.GroupBox moladetay_grup;
        private System.Windows.Forms.Label ara_vermeden_gecen_sure;
        private System.Windows.Forms.Label goz_sagligi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label atlanilan_mola_sayisi;
        private System.Windows.Forms.Label verilen_mola_sayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox moladetay_listbox;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer sayac_timer;
        private System.Windows.Forms.Timer mola_timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Kapat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Durdur;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Devam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ayarlar;
    }
}

