namespace OtelMüsteriSistem
{
    partial class Yemekhane
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
            this.flowLayoutYemekhane = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutYemekhane
            // 
            this.flowLayoutYemekhane.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutYemekhane.Name = "flowLayoutYemekhane";
            this.flowLayoutYemekhane.Size = new System.Drawing.Size(777, 426);
            this.flowLayoutYemekhane.TabIndex = 2;
            // 
            // Yemekhane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutYemekhane);
            this.Name = "Yemekhane";
            this.Text = "Yemekhane";
            this.Load += new System.EventHandler(this.Yemekhane_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutYemekhane;
    }
}