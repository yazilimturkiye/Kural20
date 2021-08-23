namespace Kural20v2._0
{
    partial class AlarmForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mola_ver_buton = new System.Windows.Forms.Button();
            this.mola_atlama_buton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.muzikkapat_buton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(196, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dakikadır Bilgisayarın Başındasın ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(182, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 80);
            this.label3.TabIndex = 2;
            this.label3.Text = "Göz sağlığın için artık ara verme vaktin geldi.\r\nŞimdi 20 SANİYE boyunca 20 METRE" +
    " UZAĞA \r\nbakmalısın. Eğer bunu yapmazsan göz \r\nhastalıklarına yakalanma oranın %" +
    "80 artıcaktır.";
            // 
            // mola_ver_buton
            // 
            this.mola_ver_buton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mola_ver_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mola_ver_buton.ImageIndex = 1;
            this.mola_ver_buton.ImageList = this.ımageList1;
            this.mola_ver_buton.Location = new System.Drawing.Point(193, 238);
            this.mola_ver_buton.Name = "mola_ver_buton";
            this.mola_ver_buton.Size = new System.Drawing.Size(160, 50);
            this.mola_ver_buton.TabIndex = 3;
            this.mola_ver_buton.Text = "Evet, Mola Ver";
            this.mola_ver_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mola_ver_buton.UseVisualStyleBackColor = true;
            this.mola_ver_buton.Click += new System.EventHandler(this.mola_ver_buton_Click);
            // 
            // mola_atlama_buton
            // 
            this.mola_atlama_buton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mola_atlama_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mola_atlama_buton.ImageKey = "kapatbuton1.fw.png";
            this.mola_atlama_buton.ImageList = this.ımageList1;
            this.mola_atlama_buton.Location = new System.Drawing.Point(359, 238);
            this.mola_atlama_buton.Name = "mola_atlama_buton";
            this.mola_atlama_buton.Size = new System.Drawing.Size(160, 50);
            this.mola_atlama_buton.TabIndex = 4;
            this.mola_atlama_buton.Text = "Hayır, Devam Et";
            this.mola_atlama_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mola_atlama_buton.UseVisualStyleBackColor = true;
            this.mola_atlama_buton.Click += new System.EventHandler(this.mola_atlama_buton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Veridğin Mola Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Atladığın Mola Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(159, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(164, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // muzikkapat_buton
            // 
            this.muzikkapat_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muzikkapat_buton.ImageIndex = 2;
            this.muzikkapat_buton.ImageList = this.ımageList1;
            this.muzikkapat_buton.Location = new System.Drawing.Point(15, 238);
            this.muzikkapat_buton.Name = "muzikkapat_buton";
            this.muzikkapat_buton.Size = new System.Drawing.Size(50, 50);
            this.muzikkapat_buton.TabIndex = 10;
            this.muzikkapat_buton.UseVisualStyleBackColor = true;
            this.muzikkapat_buton.Click += new System.EventHandler(this.muzikkapat_buton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kapatbuton1.fw.png");
            this.ımageList1.Images.SetKeyName(1, "onay.fw.png");
            this.ımageList1.Images.SetKeyName(2, "seskapat.fw.png");
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 300);
            this.Controls.Add(this.muzikkapat_buton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mola_atlama_buton);
            this.Controls.Add(this.mola_ver_buton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlarmForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlarmForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlarmForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AlarmForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mola_ver_buton;
        private System.Windows.Forms.Button mola_atlama_buton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button muzikkapat_buton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}