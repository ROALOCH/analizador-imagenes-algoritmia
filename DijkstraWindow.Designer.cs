namespace iP_Etapa5
{
    partial class DijkstraWindow
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelInitialV = new System.Windows.Forms.Label();
            this.comboBoxInitialV = new System.Windows.Forms.ComboBox();
            this.comboBoxPath = new System.Windows.Forms.ComboBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonAnimate = new System.Windows.Forms.Button();
            this.buttonSetInitial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1000, 657);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelInitialV
            // 
            this.labelInitialV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelInitialV.Font = new System.Drawing.Font("Lemon/Milk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitialV.ForeColor = System.Drawing.Color.Magenta;
            this.labelInitialV.Location = new System.Drawing.Point(1021, 12);
            this.labelInitialV.Name = "labelInitialV";
            this.labelInitialV.Size = new System.Drawing.Size(231, 34);
            this.labelInitialV.TabIndex = 1;
            this.labelInitialV.Text = "VÉRTICE INICIAL";
            this.labelInitialV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxInitialV
            // 
            this.comboBoxInitialV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxInitialV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInitialV.FormattingEnabled = true;
            this.comboBoxInitialV.Location = new System.Drawing.Point(1021, 50);
            this.comboBoxInitialV.Name = "comboBoxInitialV";
            this.comboBoxInitialV.Size = new System.Drawing.Size(231, 24);
            this.comboBoxInitialV.TabIndex = 2;
            // 
            // comboBoxPath
            // 
            this.comboBoxPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPath.Enabled = false;
            this.comboBoxPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPath.FormattingEnabled = true;
            this.comboBoxPath.Location = new System.Drawing.Point(1021, 165);
            this.comboBoxPath.Name = "comboBoxPath";
            this.comboBoxPath.Size = new System.Drawing.Size(231, 24);
            this.comboBoxPath.TabIndex = 4;
            this.comboBoxPath.SelectedIndexChanged += new System.EventHandler(this.comboBoxPath_SelectedIndexChanged);
            // 
            // labelPath
            // 
            this.labelPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelPath.Enabled = false;
            this.labelPath.Font = new System.Drawing.Font("Lemon/Milk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.ForeColor = System.Drawing.Color.Orange;
            this.labelPath.Location = new System.Drawing.Point(1021, 127);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(231, 34);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "CAMINO MÍNIMO";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAnimate
            // 
            this.buttonAnimate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonAnimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimate.Enabled = false;
            this.buttonAnimate.FlatAppearance.BorderSize = 0;
            this.buttonAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnimate.Font = new System.Drawing.Font("Lemon/Milk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnimate.Location = new System.Drawing.Point(1021, 195);
            this.buttonAnimate.Name = "buttonAnimate";
            this.buttonAnimate.Size = new System.Drawing.Size(231, 29);
            this.buttonAnimate.TabIndex = 5;
            this.buttonAnimate.Text = "A  N  I  M  A  R";
            this.buttonAnimate.UseVisualStyleBackColor = false;
            this.buttonAnimate.Click += new System.EventHandler(this.buttonAnimate_Click);
            // 
            // buttonSetInitial
            // 
            this.buttonSetInitial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonSetInitial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetInitial.FlatAppearance.BorderSize = 0;
            this.buttonSetInitial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetInitial.Font = new System.Drawing.Font("Lemon/Milk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetInitial.Location = new System.Drawing.Point(1021, 80);
            this.buttonSetInitial.Name = "buttonSetInitial";
            this.buttonSetInitial.Size = new System.Drawing.Size(231, 29);
            this.buttonSetInitial.TabIndex = 6;
            this.buttonSetInitial.Text = "E  N  V  I  A  R";
            this.buttonSetInitial.UseVisualStyleBackColor = false;
            this.buttonSetInitial.Click += new System.EventHandler(this.buttonSetInitial_Click);
            // 
            // DijkstraWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSetInitial);
            this.Controls.Add(this.buttonAnimate);
            this.Controls.Add(this.comboBoxPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.comboBoxInitialV);
            this.Controls.Add(this.labelInitialV);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DijkstraWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelInitialV;
        private System.Windows.Forms.ComboBox comboBoxInitialV;
        private System.Windows.Forms.ComboBox comboBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonAnimate;
        private System.Windows.Forms.Button buttonSetInitial;
    }
}