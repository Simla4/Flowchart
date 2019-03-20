namespace FlowChart
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kodlarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taşıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalıştırToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.kodlarıGörüntüleToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çalıştırToolStripMenuItem
            // 
            this.çalıştırToolStripMenuItem.Name = "çalıştırToolStripMenuItem";
            this.çalıştırToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.çalıştırToolStripMenuItem.Text = "Çalıştır";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // kodlarıGörüntüleToolStripMenuItem
            // 
            this.kodlarıGörüntüleToolStripMenuItem.Name = "kodlarıGörüntüleToolStripMenuItem";
            this.kodlarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kodlarıGörüntüleToolStripMenuItem.Text = "Kodları Görüntüle";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.taşıToolStripMenuItem,
            this.temizleToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // taşıToolStripMenuItem
            // 
            this.taşıToolStripMenuItem.Name = "taşıToolStripMenuItem";
            this.taşıToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.taşıToolStripMenuItem.Text = "Taşı";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Başla/Bitir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "İf/Else";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "İf";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "For";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "While";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 288);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Output";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 340);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 46);
            this.button7.TabIndex = 7;
            this.button7.Text = "Input";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(116, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 396);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kodlarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taşıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
    }
}

