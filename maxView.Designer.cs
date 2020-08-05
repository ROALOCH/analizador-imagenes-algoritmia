namespace iP
{
    partial class maxView
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
            this.pictureBoxMaxView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMaxView
            // 
            this.pictureBoxMaxView.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxMaxView.Name = "pictureBoxMaxView";
            this.pictureBoxMaxView.Size = new System.Drawing.Size(1880, 1016);
            this.pictureBoxMaxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaxView.TabIndex = 0;
            this.pictureBoxMaxView.TabStop = false;
            // 
            // maxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBoxMaxView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "maxView";
            this.Text = "Imagen Procesada (Maximizada)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMaxView;
    }
}