namespace OtelMüsteriSistem
{
    partial class Duyurular
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
            this.flowLayoutDuyurular = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutDuyurular
            // 
            this.flowLayoutDuyurular.Location = new System.Drawing.Point(12, 7);
            this.flowLayoutDuyurular.Name = "flowLayoutDuyurular";
            this.flowLayoutDuyurular.Size = new System.Drawing.Size(777, 426);
            this.flowLayoutDuyurular.TabIndex = 1;
            // 
            // Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(801, 445);
            this.Controls.Add(this.flowLayoutDuyurular);
            this.Name = "Duyurular";
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.Duyurular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutDuyurular;
    }
}