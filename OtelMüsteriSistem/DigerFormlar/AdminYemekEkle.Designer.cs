namespace OtelMüsteriSistem
{
    partial class AdminYemekEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminYemekEkle));
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtYemekOgunu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtYemekCesit3 = new System.Windows.Forms.TextBox();
            this.txtYemekCesit2 = new System.Windows.Forms.TextBox();
            this.txtYemekCesit1 = new System.Windows.Forms.TextBox();
            this.btnYemekEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(24, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "Yemek Öğünü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Çeşit 2:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(93, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 25);
            this.label19.TabIndex = 62;
            this.label19.Text = "Çeşit 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(93, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Çeşit 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(111, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Tarih:";
            // 
            // TxtYemekOgunu
            // 
            this.TxtYemekOgunu.BackColor = System.Drawing.SystemColors.Info;
            this.TxtYemekOgunu.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYemekOgunu.Location = new System.Drawing.Point(201, 39);
            this.TxtYemekOgunu.Name = "TxtYemekOgunu";
            this.TxtYemekOgunu.Size = new System.Drawing.Size(277, 28);
            this.TxtYemekOgunu.TabIndex = 67;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTarih);
            this.groupBox2.Controls.Add(this.txtYemekCesit3);
            this.groupBox2.Controls.Add(this.txtYemekCesit2);
            this.groupBox2.Controls.Add(this.txtYemekCesit1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtYemekOgunu);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 220);
            this.groupBox2.TabIndex = 145;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yemek Bilgileri";
            // 
            // TxtTarih
            // 
            this.TxtTarih.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTarih.Location = new System.Drawing.Point(200, 73);
            this.TxtTarih.Mask = "00/00/0000";
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(278, 22);
            this.TxtTarih.TabIndex = 72;
            this.TxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtYemekCesit3
            // 
            this.txtYemekCesit3.BackColor = System.Drawing.SystemColors.Info;
            this.txtYemekCesit3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYemekCesit3.Location = new System.Drawing.Point(201, 175);
            this.txtYemekCesit3.Name = "txtYemekCesit3";
            this.txtYemekCesit3.Size = new System.Drawing.Size(277, 28);
            this.txtYemekCesit3.TabIndex = 71;
            // 
            // txtYemekCesit2
            // 
            this.txtYemekCesit2.BackColor = System.Drawing.SystemColors.Info;
            this.txtYemekCesit2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYemekCesit2.Location = new System.Drawing.Point(200, 141);
            this.txtYemekCesit2.Name = "txtYemekCesit2";
            this.txtYemekCesit2.Size = new System.Drawing.Size(277, 28);
            this.txtYemekCesit2.TabIndex = 70;
            // 
            // txtYemekCesit1
            // 
            this.txtYemekCesit1.BackColor = System.Drawing.SystemColors.Info;
            this.txtYemekCesit1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYemekCesit1.Location = new System.Drawing.Point(201, 107);
            this.txtYemekCesit1.Name = "txtYemekCesit1";
            this.txtYemekCesit1.Size = new System.Drawing.Size(277, 28);
            this.txtYemekCesit1.TabIndex = 69;
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekEkle.Location = new System.Drawing.Point(24, 248);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(466, 51);
            this.btnYemekEkle.TabIndex = 147;
            this.btnYemekEkle.Text = "YEMEK EKLE";
            this.btnYemekEkle.UseVisualStyleBackColor = true;
            this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // AdminYemekEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(840, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnYemekEkle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminYemekEkle";
            this.Text = "Yemek Ekle (Admin)";
            this.Load += new System.EventHandler(this.AdminYemekEkle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtYemekOgunu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYemekCesit3;
        private System.Windows.Forms.TextBox txtYemekCesit2;
        private System.Windows.Forms.TextBox txtYemekCesit1;
        private System.Windows.Forms.Button btnYemekEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox TxtTarih;
    }
}