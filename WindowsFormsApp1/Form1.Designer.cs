namespace WindowsFormsApp1
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
            this.foto1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.foto2 = new System.Windows.Forms.PictureBox();
            this.foto3 = new System.Windows.Forms.PictureBox();
            this.foto4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.foto6 = new System.Windows.Forms.PictureBox();
            this.foto5 = new System.Windows.Forms.PictureBox();
            this.foto7 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto7)).BeginInit();
            this.SuspendLayout();
            // 
            // foto1
            // 
            this.foto1.Image = ((System.Drawing.Image)(resources.GetObject("foto1.Image")));
            this.foto1.Location = new System.Drawing.Point(191, 133);
            this.foto1.Margin = new System.Windows.Forms.Padding(9);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(170, 122);
            this.foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto1.TabIndex = 9;
            this.foto1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(1272, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Giriş yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // foto2
            // 
            this.foto2.Image = ((System.Drawing.Image)(resources.GetObject("foto2.Image")));
            this.foto2.Location = new System.Drawing.Point(383, 133);
            this.foto2.Margin = new System.Windows.Forms.Padding(9);
            this.foto2.Name = "foto2";
            this.foto2.Size = new System.Drawing.Size(170, 122);
            this.foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto2.TabIndex = 10;
            this.foto2.TabStop = false;
            // 
            // foto3
            // 
            this.foto3.Image = ((System.Drawing.Image)(resources.GetObject("foto3.Image")));
            this.foto3.Location = new System.Drawing.Point(572, 133);
            this.foto3.Margin = new System.Windows.Forms.Padding(9);
            this.foto3.Name = "foto3";
            this.foto3.Size = new System.Drawing.Size(170, 122);
            this.foto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto3.TabIndex = 11;
            this.foto3.TabStop = false;
            // 
            // foto4
            // 
            this.foto4.Image = ((System.Drawing.Image)(resources.GetObject("foto4.Image")));
            this.foto4.Location = new System.Drawing.Point(766, 133);
            this.foto4.Margin = new System.Windows.Forms.Padding(9);
            this.foto4.Name = "foto4";
            this.foto4.Size = new System.Drawing.Size(170, 122);
            this.foto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto4.TabIndex = 12;
            this.foto4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 80);
            this.button1.TabIndex = 13;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown_1);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 80);
            this.button2.TabIndex = 14;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // foto6
            // 
            this.foto6.Image = ((System.Drawing.Image)(resources.GetObject("foto6.Image")));
            this.foto6.Location = new System.Drawing.Point(1142, 133);
            this.foto6.Margin = new System.Windows.Forms.Padding(9);
            this.foto6.Name = "foto6";
            this.foto6.Size = new System.Drawing.Size(170, 122);
            this.foto6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto6.TabIndex = 15;
            this.foto6.TabStop = false;
            this.foto6.Visible = false;
            // 
            // foto5
            // 
            this.foto5.Image = ((System.Drawing.Image)(resources.GetObject("foto5.Image")));
            this.foto5.Location = new System.Drawing.Point(954, 133);
            this.foto5.Margin = new System.Windows.Forms.Padding(9);
            this.foto5.Name = "foto5";
            this.foto5.Size = new System.Drawing.Size(170, 122);
            this.foto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto5.TabIndex = 16;
            this.foto5.TabStop = false;
            this.foto5.Visible = false;
            // 
            // foto7
            // 
            this.foto7.Image = ((System.Drawing.Image)(resources.GetObject("foto7.Image")));
            this.foto7.Location = new System.Drawing.Point(1330, 133);
            this.foto7.Margin = new System.Windows.Forms.Padding(9);
            this.foto7.Name = "foto7";
            this.foto7.Size = new System.Drawing.Size(170, 122);
            this.foto7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto7.TabIndex = 17;
            this.foto7.TabStop = false;
            this.foto7.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1142, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 43);
            this.button4.TabIndex = 18;
            this.button4.Text = "Sepet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 944);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.foto7);
            this.Controls.Add(this.foto5);
            this.Controls.Add(this.foto6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.foto4);
            this.Controls.Add(this.foto3);
            this.Controls.Add(this.foto2);
            this.Controls.Add(this.foto1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "GirişYap/Üye ol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox foto2;
        private System.Windows.Forms.PictureBox foto3;
        private System.Windows.Forms.PictureBox foto4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox foto6;
        private System.Windows.Forms.PictureBox foto5;
        private System.Windows.Forms.PictureBox foto7;
        public System.Windows.Forms.PictureBox foto1;
        private System.Windows.Forms.Button button4;
    }
}

