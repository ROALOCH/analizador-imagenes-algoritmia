namespace iP_Etapa2
{
    partial class Compare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compare));
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelProcessed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLabels = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.panelLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 200);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxProcessed
            // 
            this.pictureBoxProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProcessed.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxProcessed.Location = new System.Drawing.Point(432, 200);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProcessed.TabIndex = 1;
            this.pictureBoxProcessed.TabStop = false;
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGraph.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxGraph.Location = new System.Drawing.Point(852, 200);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGraph.TabIndex = 2;
            this.pictureBoxGraph.TabStop = false;
            // 
            // labelOriginal
            // 
            this.labelOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelOriginal.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginal.ForeColor = System.Drawing.SystemColors.Window;
            this.labelOriginal.Location = new System.Drawing.Point(19, 0);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(400, 100);
            this.labelOriginal.TabIndex = 3;
            this.labelOriginal.Text = "original";
            this.labelOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessed
            // 
            this.labelProcessed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelProcessed.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessed.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessed.Location = new System.Drawing.Point(439, 0);
            this.labelProcessed.Name = "labelProcessed";
            this.labelProcessed.Size = new System.Drawing.Size(400, 100);
            this.labelProcessed.TabIndex = 4;
            this.labelProcessed.Text = "procesada";
            this.labelProcessed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(859, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 100);
            this.label1.TabIndex = 5;
            this.label1.Text = "grafo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLabels
            // 
            this.panelLabels.BackColor = System.Drawing.Color.Magenta;
            this.panelLabels.Controls.Add(this.labelProcessed);
            this.panelLabels.Controls.Add(this.label1);
            this.panelLabels.Controls.Add(this.labelOriginal);
            this.panelLabels.Location = new System.Drawing.Point(-7, 82);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(1280, 100);
            this.panelLabels.TabIndex = 6;
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.pictureBoxProcessed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.panelLabels);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Compare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.panelLabels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelProcessed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLabels;
    }
}