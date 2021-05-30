namespace OtelMüsteriSistem
{
    partial class AdminDuyuruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDuyuruEkle));
            this.btnDuyuruEkle = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDuyuruIcerik = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDuyuruBaslik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDuyuruEkle
            // 
            this.btnDuyuruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyuruEkle.Location = new System.Drawing.Point(23, 294);
            this.btnDuyuruEkle.Name = "btnDuyuruEkle";
            this.btnDuyuruEkle.Size = new System.Drawing.Size(466, 47);
            this.btnDuyuruEkle.TabIndex = 147;
            this.btnDuyuruEkle.Text = "DUYURU EKLE";
            this.btnDuyuruEkle.UseVisualStyleBackColor = true;
            this.btnDuyuruEkle.Click += new System.EventHandler(this.btnDuyuruEkle_Click);
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(495, 12);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(334, 329);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 146;
            this.image.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDuyuruIcerik);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtDuyuruBaslik);
            this.groupBox2.Location = new System.Drawing.Point(23, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 276);
            this.groupBox2.TabIndex = 145;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Bilgileri";
            // 
            // txtDuyuruIcerik
            // 
            this.txtDuyuruIcerik.BackColor = System.Drawing.SystemColors.Info;
            this.txtDuyuruIcerik.Location = new System.Drawing.Point(167, 89);
            this.txtDuyuruIcerik.Name = "txtDuyuruIcerik";
            this.txtDuyuruIcerik.Size = new System.Drawing.Size(277, 156);
            this.txtDuyuruIcerik.TabIndex = 69;
            this.txtDuyuruIcerik.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "Duyuru Başlığı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Duyuru İçeriği:";
            // 
            // TxtDuyuruBaslik
            // 
            this.TxtDuyuruBaslik.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDuyuruBaslik.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDuyuruBaslik.Location = new System.Drawing.Point(170, 45);
            this.TxtDuyuruBaslik.Name = "TxtDuyuruBaslik";
            this.TxtDuyuruBaslik.Size = new System.Drawing.Size(274, 28);
            this.TxtDuyuruBaslik.TabIndex = 67;
            // 
            // AdminDuyuruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(849, 371);
            this.Controls.Add(this.btnDuyuruEkle);
            this.Controls.Add(this.image);
            this.Controls.Add(this.groupBox2);
            this.Name = "AdminDuyuruEkle";
            this.Text = "Duyuru Ekle (Admin)";
            this.Load += new System.EventHandler(this.AdminDuyuruEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDuyuruEkle;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDuyuruBaslik;
        private System.Windows.Forms.RichTextBox txtDuyuruIcerik;
    }
}