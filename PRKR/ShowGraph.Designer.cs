namespace R
{
    partial class ShowGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowGraph));
            this.panelMain = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelVertexConnection = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelVertexConnections = new System.Windows.Forms.Label();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panelMain.Controls.Add(this.listBox);
            this.panelMain.Controls.Add(this.labelVertexConnection);
            this.panelMain.Controls.Add(this.comboBox);
            this.panelMain.Controls.Add(this.labelVertexConnections);
            this.panelMain.Location = new System.Drawing.Point(1015, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(251, 684);
            this.panelMain.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(13, 125);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(225, 544);
            this.listBox.TabIndex = 4;
            // 
            // labelVertexConnection
            // 
            this.labelVertexConnection.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVertexConnection.Location = new System.Drawing.Point(13, 86);
            this.labelVertexConnection.Name = "labelVertexConnection";
            this.labelVertexConnection.Size = new System.Drawing.Size(225, 29);
            this.labelVertexConnection.TabIndex = 3;
            this.labelVertexConnection.Text = "CONECTA CON";
            this.labelVertexConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox.DropDownHeight = 320;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.IntegralHeight = false;
            this.comboBox.Location = new System.Drawing.Point(13, 44);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(225, 24);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // labelVertexConnections
            // 
            this.labelVertexConnections.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVertexConnections.Location = new System.Drawing.Point(13, 12);
            this.labelVertexConnections.Name = "labelVertexConnections";
            this.labelVertexConnections.Size = new System.Drawing.Size(225, 29);
            this.labelVertexConnections.TabIndex = 1;
            this.labelVertexConnections.Text = "SELECCIONA UN VÉRTICE";
            this.labelVertexConnections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(996, 657);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDisplay.TabIndex = 3;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // ShowGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ShowGraph";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Label labelVertexConnections;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelVertexConnection;
        private System.Windows.Forms.ListBox listBox;
    }
}