namespace R
{
    partial class GraphSearch
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonSelectGraph = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxDFS = new System.Windows.Forms.ComboBox();
            this.labelDFS = new System.Windows.Forms.Label();
            this.comboBoxObjective = new System.Windows.Forms.ComboBox();
            this.labelObjective = new System.Windows.Forms.Label();
            this.radioButtonK = new System.Windows.Forms.RadioButton();
            this.radioButtonP = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(996, 657);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panelMain.Controls.Add(this.buttonSelectGraph);
            this.panelMain.Controls.Add(this.buttonStart);
            this.panelMain.Controls.Add(this.comboBoxDFS);
            this.panelMain.Controls.Add(this.labelDFS);
            this.panelMain.Controls.Add(this.comboBoxObjective);
            this.panelMain.Controls.Add(this.labelObjective);
            this.panelMain.Controls.Add(this.radioButtonK);
            this.panelMain.Controls.Add(this.radioButtonP);
            this.panelMain.Location = new System.Drawing.Point(1013, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(251, 684);
            this.panelMain.TabIndex = 6;
            // 
            // buttonSelectGraph
            // 
            this.buttonSelectGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.buttonSelectGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectGraph.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSelectGraph.FlatAppearance.BorderSize = 0;
            this.buttonSelectGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonSelectGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.buttonSelectGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectGraph.Font = new System.Drawing.Font("Lemon/Milk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectGraph.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSelectGraph.Location = new System.Drawing.Point(18, 228);
            this.buttonSelectGraph.Name = "buttonSelectGraph";
            this.buttonSelectGraph.Size = new System.Drawing.Size(221, 28);
            this.buttonSelectGraph.TabIndex = 25;
            this.buttonSelectGraph.Text = "S  E  L  E  C  C  I  O  N  A  R";
            this.buttonSelectGraph.UseVisualStyleBackColor = false;
            this.buttonSelectGraph.Click += new System.EventHandler(this.buttonSelectGraph_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Lemon/Milk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonStart.Location = new System.Drawing.Point(17, 424);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(221, 28);
            this.buttonStart.TabIndex = 24;
            this.buttonStart.Text = "I N I C I A R";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxDFS
            // 
            this.comboBoxDFS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDFS.Enabled = false;
            this.comboBoxDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDFS.FormattingEnabled = true;
            this.comboBoxDFS.Location = new System.Drawing.Point(17, 381);
            this.comboBoxDFS.Name = "comboBoxDFS";
            this.comboBoxDFS.Size = new System.Drawing.Size(222, 24);
            this.comboBoxDFS.TabIndex = 20;
            // 
            // labelDFS
            // 
            this.labelDFS.Enabled = false;
            this.labelDFS.Font = new System.Drawing.Font("Lemon/Milk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDFS.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDFS.Location = new System.Drawing.Point(17, 349);
            this.labelDFS.Name = "labelDFS";
            this.labelDFS.Size = new System.Drawing.Size(222, 29);
            this.labelDFS.TabIndex = 19;
            this.labelDFS.Text = "D F S";
            this.labelDFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxObjective
            // 
            this.comboBoxObjective.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObjective.Enabled = false;
            this.comboBoxObjective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxObjective.FormattingEnabled = true;
            this.comboBoxObjective.Location = new System.Drawing.Point(17, 312);
            this.comboBoxObjective.Name = "comboBoxObjective";
            this.comboBoxObjective.Size = new System.Drawing.Size(222, 24);
            this.comboBoxObjective.TabIndex = 18;
            // 
            // labelObjective
            // 
            this.labelObjective.Enabled = false;
            this.labelObjective.Font = new System.Drawing.Font("Lemon/Milk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjective.ForeColor = System.Drawing.SystemColors.Window;
            this.labelObjective.Location = new System.Drawing.Point(14, 280);
            this.labelObjective.Name = "labelObjective";
            this.labelObjective.Size = new System.Drawing.Size(225, 29);
            this.labelObjective.TabIndex = 17;
            this.labelObjective.Text = "O B J E T I V O";
            this.labelObjective.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonK
            // 
            this.radioButtonK.Font = new System.Drawing.Font("Lemon/Milk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonK.ForeColor = System.Drawing.Color.Orange;
            this.radioButtonK.Location = new System.Drawing.Point(133, 197);
            this.radioButtonK.Name = "radioButtonK";
            this.radioButtonK.Size = new System.Drawing.Size(106, 25);
            this.radioButtonK.TabIndex = 16;
            this.radioButtonK.Text = "K R U S K A L";
            this.radioButtonK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonK.UseVisualStyleBackColor = true;
            // 
            // radioButtonP
            // 
            this.radioButtonP.Checked = true;
            this.radioButtonP.Font = new System.Drawing.Font("Lemon/Milk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonP.ForeColor = System.Drawing.Color.Magenta;
            this.radioButtonP.Location = new System.Drawing.Point(18, 197);
            this.radioButtonP.Name = "radioButtonP";
            this.radioButtonP.Size = new System.Drawing.Size(106, 25);
            this.radioButtonP.TabIndex = 15;
            this.radioButtonP.TabStop = true;
            this.radioButtonP.Text = "P    R    I    M";
            this.radioButtonP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonP.UseVisualStyleBackColor = true;
            this.radioButtonP.CheckedChanged += new System.EventHandler(this.radioButtonP_CheckedChanged);
            // 
            // GraphSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GraphSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.RadioButton radioButtonP;
        private System.Windows.Forms.RadioButton radioButtonK;
        private System.Windows.Forms.Label labelObjective;
        private System.Windows.Forms.ComboBox comboBoxDFS;
        private System.Windows.Forms.Label labelDFS;
        private System.Windows.Forms.ComboBox comboBoxObjective;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSelectGraph;
    }
}