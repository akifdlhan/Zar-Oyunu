namespace zaroyunu
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
            this.prb_player = new System.Windows.Forms.GroupBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_1zar = new System.Windows.Forms.Label();
            this.lbl_2zar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_toplamP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_computer = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_toplampuan1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_2zar2 = new System.Windows.Forms.Label();
            this.lbl_1zar1 = new System.Windows.Forms.Label();
            this.btn_start2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.prb_player.SuspendLayout();
            this.grb_computer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // prb_player
            // 
            this.prb_player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prb_player.Controls.Add(this.label1);
            this.prb_player.Controls.Add(this.lbl_toplamP);
            this.prb_player.Controls.Add(this.label3);
            this.prb_player.Controls.Add(this.label2);
            this.prb_player.Controls.Add(this.lbl_2zar);
            this.prb_player.Controls.Add(this.lbl_1zar);
            this.prb_player.Controls.Add(this.btn_Start);
            this.prb_player.Location = new System.Drawing.Point(12, 12);
            this.prb_player.Name = "prb_player";
            this.prb_player.Size = new System.Drawing.Size(231, 152);
            this.prb_player.TabIndex = 0;
            this.prb_player.TabStop = false;
            this.prb_player.Text = "PLAYER";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Yellow;
            this.btn_Start.Location = new System.Drawing.Point(68, 105);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(87, 41);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_1zar
            // 
            this.lbl_1zar.AutoSize = true;
            this.lbl_1zar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_1zar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_1zar.Location = new System.Drawing.Point(7, 20);
            this.lbl_1zar.Name = "lbl_1zar";
            this.lbl_1zar.Size = new System.Drawing.Size(49, 16);
            this.lbl_1zar.TabIndex = 1;
            this.lbl_1zar.Text = "1.ZAR";
            // 
            // lbl_2zar
            // 
            this.lbl_2zar.AutoSize = true;
            this.lbl_2zar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_2zar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_2zar.Location = new System.Drawing.Point(126, 20);
            this.lbl_2zar.Name = "lbl_2zar";
            this.lbl_2zar.Size = new System.Drawing.Size(49, 16);
            this.lbl_2zar.TabIndex = 2;
            this.lbl_2zar.Text = "2.ZAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(62, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(181, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // lbl_toplamP
            // 
            this.lbl_toplamP.AutoSize = true;
            this.lbl_toplamP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_toplamP.Location = new System.Drawing.Point(7, 60);
            this.lbl_toplamP.Name = "lbl_toplamP";
            this.lbl_toplamP.Size = new System.Drawing.Size(114, 16);
            this.lbl_toplamP.TabIndex = 5;
            this.lbl_toplamP.Text = "TOPLAM PUAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // grb_computer
            // 
            this.grb_computer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grb_computer.Controls.Add(this.label4);
            this.grb_computer.Controls.Add(this.lbl_toplampuan1);
            this.grb_computer.Controls.Add(this.label6);
            this.grb_computer.Controls.Add(this.label7);
            this.grb_computer.Controls.Add(this.lbl_2zar2);
            this.grb_computer.Controls.Add(this.lbl_1zar1);
            this.grb_computer.Controls.Add(this.btn_start2);
            this.grb_computer.Location = new System.Drawing.Point(12, 186);
            this.grb_computer.Name = "grb_computer";
            this.grb_computer.Size = new System.Drawing.Size(231, 152);
            this.grb_computer.TabIndex = 7;
            this.grb_computer.TabStop = false;
            this.grb_computer.Text = "COMPUTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(140, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // lbl_toplampuan1
            // 
            this.lbl_toplampuan1.AutoSize = true;
            this.lbl_toplampuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplampuan1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_toplampuan1.Location = new System.Drawing.Point(7, 60);
            this.lbl_toplampuan1.Name = "lbl_toplampuan1";
            this.lbl_toplampuan1.Size = new System.Drawing.Size(114, 16);
            this.lbl_toplampuan1.TabIndex = 5;
            this.lbl_toplampuan1.Text = "TOPLAM PUAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(181, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(62, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "0";
            // 
            // lbl_2zar2
            // 
            this.lbl_2zar2.AutoSize = true;
            this.lbl_2zar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_2zar2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_2zar2.Location = new System.Drawing.Point(126, 20);
            this.lbl_2zar2.Name = "lbl_2zar2";
            this.lbl_2zar2.Size = new System.Drawing.Size(49, 16);
            this.lbl_2zar2.TabIndex = 2;
            this.lbl_2zar2.Text = "2.ZAR";
            // 
            // lbl_1zar1
            // 
            this.lbl_1zar1.AutoSize = true;
            this.lbl_1zar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_1zar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_1zar1.Location = new System.Drawing.Point(7, 20);
            this.lbl_1zar1.Name = "lbl_1zar1";
            this.lbl_1zar1.Size = new System.Drawing.Size(49, 16);
            this.lbl_1zar1.TabIndex = 1;
            this.lbl_1zar1.Text = "1.ZAR";
            // 
            // btn_start2
            // 
            this.btn_start2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_start2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_start2.Location = new System.Drawing.Point(68, 105);
            this.btn_start2.Name = "btn_start2";
            this.btn_start2.Size = new System.Drawing.Size(87, 41);
            this.btn_start2.TabIndex = 0;
            this.btn_start2.Text = "START";
            this.btn_start2.UseVisualStyleBackColor = false;
            this.btn_start2.Click += new System.EventHandler(this.btn_start2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(317, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(502, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(680, 360);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grb_computer);
            this.Controls.Add(this.prb_player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.prb_player.ResumeLayout(false);
            this.prb_player.PerformLayout();
            this.grb_computer.ResumeLayout(false);
            this.grb_computer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox prb_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_toplamP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_2zar;
        private System.Windows.Forms.Label lbl_1zar;
        private System.Windows.Forms.Button btn_Start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grb_computer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_toplampuan1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_2zar2;
        private System.Windows.Forms.Label lbl_1zar1;
        private System.Windows.Forms.Button btn_start2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

