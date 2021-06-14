
namespace HesapMakinesi
{
    partial class HesapMakinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapMakinesi));
            this.BtnSıfır = new System.Windows.Forms.Button();
            this.BtnVirgul = new System.Windows.Forms.Button();
            this.Btnartı = new System.Windows.Forms.Button();
            this.BtnBir = new System.Windows.Forms.Button();
            this.Btniki = new System.Windows.Forms.Button();
            this.BtnUc = new System.Windows.Forms.Button();
            this.BtnDort = new System.Windows.Forms.Button();
            this.BtnBes = new System.Windows.Forms.Button();
            this.BtnAltı = new System.Windows.Forms.Button();
            this.BtnYedi = new System.Windows.Forms.Button();
            this.BtnSekiz = new System.Windows.Forms.Button();
            this.BtnDokuz = new System.Windows.Forms.Button();
            this.TxtYazdır = new System.Windows.Forms.TextBox();
            this.BtnEsitle = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnEksi = new System.Windows.Forms.Button();
            this.BtnCarpı = new System.Windows.Forms.Button();
            this.BtnBol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSıfır
            // 
            this.BtnSıfır.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSıfır.Location = new System.Drawing.Point(12, 564);
            this.BtnSıfır.Name = "BtnSıfır";
            this.BtnSıfır.Size = new System.Drawing.Size(329, 115);
            this.BtnSıfır.TabIndex = 0;
            this.BtnSıfır.Text = "0";
            this.BtnSıfır.UseVisualStyleBackColor = true;
            this.BtnSıfır.Click += new System.EventHandler(this.BtnSıfır_Click);
            // 
            // BtnVirgul
            // 
            this.BtnVirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVirgul.Location = new System.Drawing.Point(362, 564);
            this.BtnVirgul.Name = "BtnVirgul";
            this.BtnVirgul.Size = new System.Drawing.Size(153, 115);
            this.BtnVirgul.TabIndex = 1;
            this.BtnVirgul.Text = ",";
            this.BtnVirgul.UseVisualStyleBackColor = true;
            // 
            // Btnartı
            // 
            this.Btnartı.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnartı.Location = new System.Drawing.Point(521, 127);
            this.Btnartı.Name = "Btnartı";
            this.Btnartı.Size = new System.Drawing.Size(153, 115);
            this.Btnartı.TabIndex = 2;
            this.Btnartı.Text = "+";
            this.Btnartı.UseVisualStyleBackColor = true;
            this.Btnartı.Click += new System.EventHandler(this.Btnartı_Click);
            // 
            // BtnBir
            // 
            this.BtnBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBir.Location = new System.Drawing.Point(12, 421);
            this.BtnBir.Name = "BtnBir";
            this.BtnBir.Size = new System.Drawing.Size(153, 115);
            this.BtnBir.TabIndex = 3;
            this.BtnBir.Text = "1";
            this.BtnBir.UseVisualStyleBackColor = true;
            this.BtnBir.Click += new System.EventHandler(this.BtnBir_Click);
            // 
            // Btniki
            // 
            this.Btniki.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btniki.Location = new System.Drawing.Point(188, 421);
            this.Btniki.Name = "Btniki";
            this.Btniki.Size = new System.Drawing.Size(153, 115);
            this.Btniki.TabIndex = 4;
            this.Btniki.Text = "2";
            this.Btniki.UseVisualStyleBackColor = true;
            this.Btniki.Click += new System.EventHandler(this.Btniki_Click);
            // 
            // BtnUc
            // 
            this.BtnUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUc.Location = new System.Drawing.Point(362, 421);
            this.BtnUc.Name = "BtnUc";
            this.BtnUc.Size = new System.Drawing.Size(153, 115);
            this.BtnUc.TabIndex = 5;
            this.BtnUc.Text = "3";
            this.BtnUc.UseVisualStyleBackColor = true;
            this.BtnUc.Click += new System.EventHandler(this.BtnUc_Click);
            // 
            // BtnDort
            // 
            this.BtnDort.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDort.Location = new System.Drawing.Point(12, 273);
            this.BtnDort.Name = "BtnDort";
            this.BtnDort.Size = new System.Drawing.Size(153, 115);
            this.BtnDort.TabIndex = 6;
            this.BtnDort.Text = "4";
            this.BtnDort.UseVisualStyleBackColor = true;
            this.BtnDort.Click += new System.EventHandler(this.BtnDort_Click);
            // 
            // BtnBes
            // 
            this.BtnBes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBes.Location = new System.Drawing.Point(188, 273);
            this.BtnBes.Name = "BtnBes";
            this.BtnBes.Size = new System.Drawing.Size(153, 115);
            this.BtnBes.TabIndex = 7;
            this.BtnBes.Text = "5";
            this.BtnBes.UseVisualStyleBackColor = true;
            this.BtnBes.Click += new System.EventHandler(this.BtnBes_Click);
            // 
            // BtnAltı
            // 
            this.BtnAltı.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAltı.Location = new System.Drawing.Point(362, 273);
            this.BtnAltı.Name = "BtnAltı";
            this.BtnAltı.Size = new System.Drawing.Size(153, 115);
            this.BtnAltı.TabIndex = 8;
            this.BtnAltı.Text = "6";
            this.BtnAltı.UseVisualStyleBackColor = true;
            this.BtnAltı.Click += new System.EventHandler(this.BtnAltı_Click);
            // 
            // BtnYedi
            // 
            this.BtnYedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYedi.Location = new System.Drawing.Point(12, 127);
            this.BtnYedi.Name = "BtnYedi";
            this.BtnYedi.Size = new System.Drawing.Size(153, 115);
            this.BtnYedi.TabIndex = 9;
            this.BtnYedi.Text = "7";
            this.BtnYedi.UseVisualStyleBackColor = true;
            this.BtnYedi.Click += new System.EventHandler(this.BtnYedi_Click);
            // 
            // BtnSekiz
            // 
            this.BtnSekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSekiz.Location = new System.Drawing.Point(188, 127);
            this.BtnSekiz.Name = "BtnSekiz";
            this.BtnSekiz.Size = new System.Drawing.Size(153, 115);
            this.BtnSekiz.TabIndex = 10;
            this.BtnSekiz.Text = "8";
            this.BtnSekiz.UseVisualStyleBackColor = true;
            this.BtnSekiz.Click += new System.EventHandler(this.BtnSekiz_Click);
            // 
            // BtnDokuz
            // 
            this.BtnDokuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDokuz.Location = new System.Drawing.Point(362, 127);
            this.BtnDokuz.Name = "BtnDokuz";
            this.BtnDokuz.Size = new System.Drawing.Size(153, 115);
            this.BtnDokuz.TabIndex = 11;
            this.BtnDokuz.Text = "9";
            this.BtnDokuz.UseVisualStyleBackColor = true;
            this.BtnDokuz.Click += new System.EventHandler(this.BtnDokuz_Click);
            // 
            // TxtYazdır
            // 
            this.TxtYazdır.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtYazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazdır.Location = new System.Drawing.Point(12, 5);
            this.TxtYazdır.Name = "TxtYazdır";
            this.TxtYazdır.Size = new System.Drawing.Size(779, 116);
            this.TxtYazdır.TabIndex = 12;
            // 
            // BtnEsitle
            // 
            this.BtnEsitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEsitle.Location = new System.Drawing.Point(692, 421);
            this.BtnEsitle.Name = "BtnEsitle";
            this.BtnEsitle.Size = new System.Drawing.Size(99, 257);
            this.BtnEsitle.TabIndex = 13;
            this.BtnEsitle.Text = "=";
            this.BtnEsitle.UseVisualStyleBackColor = true;
            this.BtnEsitle.Click += new System.EventHandler(this.BtnEsitle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(692, 127);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(99, 257);
            this.BtnTemizle.TabIndex = 14;
            this.BtnTemizle.Text = "C";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnEksi
            // 
            this.BtnEksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEksi.Location = new System.Drawing.Point(521, 273);
            this.BtnEksi.Name = "BtnEksi";
            this.BtnEksi.Size = new System.Drawing.Size(153, 115);
            this.BtnEksi.TabIndex = 15;
            this.BtnEksi.Text = "-";
            this.BtnEksi.UseVisualStyleBackColor = true;
            this.BtnEksi.Click += new System.EventHandler(this.BtnEksi_Click);
            // 
            // BtnCarpı
            // 
            this.BtnCarpı.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCarpı.Location = new System.Drawing.Point(521, 421);
            this.BtnCarpı.Name = "BtnCarpı";
            this.BtnCarpı.Size = new System.Drawing.Size(153, 115);
            this.BtnCarpı.TabIndex = 16;
            this.BtnCarpı.Text = "*";
            this.BtnCarpı.UseVisualStyleBackColor = true;
            this.BtnCarpı.Click += new System.EventHandler(this.BtnCarpı_Click);
            // 
            // BtnBol
            // 
            this.BtnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBol.Location = new System.Drawing.Point(521, 563);
            this.BtnBol.Name = "BtnBol";
            this.BtnBol.Size = new System.Drawing.Size(153, 115);
            this.BtnBol.TabIndex = 17;
            this.BtnBol.Text = "/";
            this.BtnBol.UseVisualStyleBackColor = true;
            this.BtnBol.Click += new System.EventHandler(this.BtnBol_Click);
            // 
            // HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 682);
            this.Controls.Add(this.BtnBol);
            this.Controls.Add(this.BtnCarpı);
            this.Controls.Add(this.BtnEksi);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnEsitle);
            this.Controls.Add(this.TxtYazdır);
            this.Controls.Add(this.BtnDokuz);
            this.Controls.Add(this.BtnSekiz);
            this.Controls.Add(this.BtnYedi);
            this.Controls.Add(this.BtnAltı);
            this.Controls.Add(this.BtnBes);
            this.Controls.Add(this.BtnDort);
            this.Controls.Add(this.BtnUc);
            this.Controls.Add(this.Btniki);
            this.Controls.Add(this.BtnBir);
            this.Controls.Add(this.Btnartı);
            this.Controls.Add(this.BtnVirgul);
            this.Controls.Add(this.BtnSıfır);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HesapMakinesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSıfır;
        private System.Windows.Forms.Button BtnVirgul;
        private System.Windows.Forms.Button Btnartı;
        private System.Windows.Forms.Button BtnBir;
        private System.Windows.Forms.Button Btniki;
        private System.Windows.Forms.Button BtnUc;
        private System.Windows.Forms.Button BtnDort;
        private System.Windows.Forms.Button BtnBes;
        private System.Windows.Forms.Button BtnAltı;
        private System.Windows.Forms.Button BtnYedi;
        private System.Windows.Forms.Button BtnSekiz;
        private System.Windows.Forms.Button BtnDokuz;
        private System.Windows.Forms.TextBox TxtYazdır;
        private System.Windows.Forms.Button BtnEsitle;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnEksi;
        private System.Windows.Forms.Button BtnCarpı;
        private System.Windows.Forms.Button BtnBol;
    }
}

