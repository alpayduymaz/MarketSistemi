namespace MarketSistemi
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
            this.ÜrünlerButton = new System.Windows.Forms.Button();
            this.ÇalışanlarButton = new System.Windows.Forms.Button();
            this.MarketveTedarikciButton = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ÜrünlerButton
            // 
            this.ÜrünlerButton.Location = new System.Drawing.Point(114, 141);
            this.ÜrünlerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ÜrünlerButton.Name = "ÜrünlerButton";
            this.ÜrünlerButton.Size = new System.Drawing.Size(149, 58);
            this.ÜrünlerButton.TabIndex = 0;
            this.ÜrünlerButton.Text = "Ürünler";
            this.ÜrünlerButton.UseVisualStyleBackColor = true;
            this.ÜrünlerButton.Click += new System.EventHandler(this.ÜrünlerButton_Click);
            // 
            // ÇalışanlarButton
            // 
            this.ÇalışanlarButton.Location = new System.Drawing.Point(577, 141);
            this.ÇalışanlarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ÇalışanlarButton.Name = "ÇalışanlarButton";
            this.ÇalışanlarButton.Size = new System.Drawing.Size(161, 58);
            this.ÇalışanlarButton.TabIndex = 1;
            this.ÇalışanlarButton.Text = "Çalışanlar";
            this.ÇalışanlarButton.UseVisualStyleBackColor = true;
            this.ÇalışanlarButton.Click += new System.EventHandler(this.ÇalışanlarButton_Click);
            // 
            // MarketveTedarikciButton
            // 
            this.MarketveTedarikciButton.Location = new System.Drawing.Point(332, 141);
            this.MarketveTedarikciButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarketveTedarikciButton.Name = "MarketveTedarikciButton";
            this.MarketveTedarikciButton.Size = new System.Drawing.Size(155, 58);
            this.MarketveTedarikciButton.TabIndex = 2;
            this.MarketveTedarikciButton.Text = "Marketler ve Tedarikçiler";
            this.MarketveTedarikciButton.UseVisualStyleBackColor = true;
            this.MarketveTedarikciButton.Click += new System.EventHandler(this.MarketveTedarikciButton_Click);
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(577, 294);
            this.Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(161, 35);
            this.Cikis.TabIndex = 3;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 366);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.MarketveTedarikciButton);
            this.Controls.Add(this.ÇalışanlarButton);
            this.Controls.Add(this.ÜrünlerButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ÜrünlerButton;
        private System.Windows.Forms.Button ÇalışanlarButton;
        private System.Windows.Forms.Button MarketveTedarikciButton;
        private System.Windows.Forms.Button Cikis;
    }
}

