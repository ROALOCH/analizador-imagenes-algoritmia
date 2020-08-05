namespace iP
{
    partial class compareWindow
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
            this.groupBoxOriginal = new System.Windows.Forms.GroupBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.groupBoxDone = new System.Windows.Forms.GroupBox();
            this.pictureBoxDone = new System.Windows.Forms.PictureBox();
            this.groupBoxOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.groupBoxDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDone)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOriginal
            // 
            this.groupBoxOriginal.Controls.Add(this.pictureBoxOriginal);
            this.groupBoxOriginal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOriginal.Location = new System.Drawing.Point(12, 13);
            this.groupBoxOriginal.Name = "groupBoxOriginal";
            this.groupBoxOriginal.Size = new System.Drawing.Size(614, 656);
            this.groupBoxOriginal.TabIndex = 0;
            this.groupBoxOriginal.TabStop = false;
            this.groupBoxOriginal.Text = "Imagen Original";
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(6, 32);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(602, 618);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // groupBoxDone
            // 
            this.groupBoxDone.Controls.Add(this.pictureBoxDone);
            this.groupBoxDone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDone.Location = new System.Drawing.Point(638, 13);
            this.groupBoxDone.Name = "groupBoxDone";
            this.groupBoxDone.Size = new System.Drawing.Size(614, 656);
            this.groupBoxDone.TabIndex = 1;
            this.groupBoxDone.TabStop = false;
            this.groupBoxDone.Text = "Imagen Procesada";
            // 
            // pictureBoxDone
            // 
            this.pictureBoxDone.Location = new System.Drawing.Point(6, 32);
            this.pictureBoxDone.Name = "pictureBoxDone";
            this.pictureBoxDone.Size = new System.Drawing.Size(602, 618);
            this.pictureBoxDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDone.TabIndex = 1;
            this.pictureBoxDone.TabStop = false;
            // 
            // compareWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBoxDone);
            this.Controls.Add(this.groupBoxOriginal);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "compareWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparación de Resultados";
            this.groupBoxOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.groupBoxDone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOriginal;
        private System.Windows.Forms.GroupBox groupBoxDone;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxDone;
    }
}