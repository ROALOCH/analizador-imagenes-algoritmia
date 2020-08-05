namespace R
{
    partial class CompareARM
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
            this.labelPrim = new System.Windows.Forms.Label();
            this.labelKruskal = new System.Windows.Forms.Label();
            this.pictureBoxPrim = new System.Windows.Forms.PictureBox();
            this.pictureBoxKruskal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKruskal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrim
            // 
            this.labelPrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelPrim.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrim.ForeColor = System.Drawing.Color.Magenta;
            this.labelPrim.Location = new System.Drawing.Point(12, 9);
            this.labelPrim.Name = "labelPrim";
            this.labelPrim.Size = new System.Drawing.Size(609, 35);
            this.labelPrim.TabIndex = 0;
            this.labelPrim.Text = "ARM PRIM";
            this.labelPrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKruskal
            // 
            this.labelKruskal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelKruskal.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKruskal.ForeColor = System.Drawing.Color.Orange;
            this.labelKruskal.Location = new System.Drawing.Point(643, 9);
            this.labelKruskal.Name = "labelKruskal";
            this.labelKruskal.Size = new System.Drawing.Size(609, 35);
            this.labelKruskal.TabIndex = 1;
            this.labelKruskal.Text = "ARM KRUSKAL";
            this.labelKruskal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPrim
            // 
            this.pictureBoxPrim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPrim.Location = new System.Drawing.Point(12, 47);
            this.pictureBoxPrim.Name = "pictureBoxPrim";
            this.pictureBoxPrim.Size = new System.Drawing.Size(609, 622);
            this.pictureBoxPrim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrim.TabIndex = 2;
            this.pictureBoxPrim.TabStop = false;
            // 
            // pictureBoxKruskal
            // 
            this.pictureBoxKruskal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxKruskal.Location = new System.Drawing.Point(643, 47);
            this.pictureBoxKruskal.Name = "pictureBoxKruskal";
            this.pictureBoxKruskal.Size = new System.Drawing.Size(609, 622);
            this.pictureBoxKruskal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKruskal.TabIndex = 3;
            this.pictureBoxKruskal.TabStop = false;
            // 
            // CompareARM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBoxKruskal);
            this.Controls.Add(this.pictureBoxPrim);
            this.Controls.Add(this.labelKruskal);
            this.Controls.Add(this.labelPrim);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CompareARM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKruskal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPrim;
        private System.Windows.Forms.Label labelKruskal;
        private System.Windows.Forms.PictureBox pictureBoxPrim;
        private System.Windows.Forms.PictureBox pictureBoxKruskal;
    }
}