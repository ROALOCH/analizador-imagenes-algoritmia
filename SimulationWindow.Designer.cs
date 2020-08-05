namespace HUNT
{
    partial class SimulationWindow
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
            this.panel = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxManual = new System.Windows.Forms.GroupBox();
            this.labelPredatorM = new System.Windows.Forms.Label();
            this.buttonPredatorM = new System.Windows.Forms.Button();
            this.comboBoxPredatorM = new System.Windows.Forms.ComboBox();
            this.labelPrayM = new System.Windows.Forms.Label();
            this.buttonPrayM = new System.Windows.Forms.Button();
            this.comboBoxPrayM = new System.Windows.Forms.ComboBox();
            this.radioButtonManual = new System.Windows.Forms.RadioButton();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.labelConfig = new System.Windows.Forms.Label();
            this.buttonSetObjective = new System.Windows.Forms.Button();
            this.comboBoxObjective = new System.Windows.Forms.ComboBox();
            this.labelObjective = new System.Windows.Forms.Label();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.labelPredatorA = new System.Windows.Forms.Label();
            this.labelPrayA = new System.Windows.Forms.Label();
            this.numericUpDownPredator = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPray = new System.Windows.Forms.NumericUpDown();
            this.buttonSetPredatorA = new System.Windows.Forms.Button();
            this.buttonSetPrayA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBoxManual.SuspendLayout();
            this.groupBoxAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPray)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(896, 657);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel.Controls.Add(this.buttonStart);
            this.panel.Controls.Add(this.radioButtonManual);
            this.panel.Controls.Add(this.radioButtonAuto);
            this.panel.Controls.Add(this.labelConfig);
            this.panel.Controls.Add(this.buttonSetObjective);
            this.panel.Controls.Add(this.comboBoxObjective);
            this.panel.Controls.Add(this.labelObjective);
            this.panel.Controls.Add(this.groupBoxManual);
            this.panel.Controls.Add(this.groupBoxAuto);
            this.panel.Location = new System.Drawing.Point(972, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(295, 686);
            this.panel.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonStart.Location = new System.Drawing.Point(13, 507);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(267, 48);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "iniciar";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxManual
            // 
            this.groupBoxManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBoxManual.Controls.Add(this.labelPredatorM);
            this.groupBoxManual.Controls.Add(this.buttonPredatorM);
            this.groupBoxManual.Controls.Add(this.comboBoxPredatorM);
            this.groupBoxManual.Controls.Add(this.labelPrayM);
            this.groupBoxManual.Controls.Add(this.buttonPrayM);
            this.groupBoxManual.Controls.Add(this.comboBoxPrayM);
            this.groupBoxManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxManual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxManual.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxManual.Location = new System.Drawing.Point(13, 306);
            this.groupBoxManual.Name = "groupBoxManual";
            this.groupBoxManual.Size = new System.Drawing.Size(267, 173);
            this.groupBoxManual.TabIndex = 3;
            this.groupBoxManual.TabStop = false;
            this.groupBoxManual.Text = "manual";
            this.groupBoxManual.Visible = false;
            // 
            // labelPredatorM
            // 
            this.labelPredatorM.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPredatorM.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelPredatorM.Location = new System.Drawing.Point(10, 93);
            this.labelPredatorM.Name = "labelPredatorM";
            this.labelPredatorM.Size = new System.Drawing.Size(251, 27);
            this.labelPredatorM.TabIndex = 11;
            this.labelPredatorM.Text = "DEPREDADOR";
            this.labelPredatorM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPredatorM
            // 
            this.buttonPredatorM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPredatorM.FlatAppearance.BorderSize = 0;
            this.buttonPredatorM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPredatorM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonPredatorM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPredatorM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPredatorM.Location = new System.Drawing.Point(223, 126);
            this.buttonPredatorM.Name = "buttonPredatorM";
            this.buttonPredatorM.Size = new System.Drawing.Size(38, 25);
            this.buttonPredatorM.TabIndex = 9;
            this.buttonPredatorM.Text = "OK";
            this.buttonPredatorM.UseVisualStyleBackColor = true;
            this.buttonPredatorM.Click += new System.EventHandler(this.buttonPredatorM_Click);
            // 
            // comboBoxPredatorM
            // 
            this.comboBoxPredatorM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPredatorM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPredatorM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPredatorM.FormattingEnabled = true;
            this.comboBoxPredatorM.Location = new System.Drawing.Point(10, 127);
            this.comboBoxPredatorM.Name = "comboBoxPredatorM";
            this.comboBoxPredatorM.Size = new System.Drawing.Size(206, 25);
            this.comboBoxPredatorM.TabIndex = 10;
            // 
            // labelPrayM
            // 
            this.labelPrayM.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrayM.ForeColor = System.Drawing.Color.Red;
            this.labelPrayM.Location = new System.Drawing.Point(10, 18);
            this.labelPrayM.Name = "labelPrayM";
            this.labelPrayM.Size = new System.Drawing.Size(251, 27);
            this.labelPrayM.TabIndex = 8;
            this.labelPrayM.Text = "PRESA";
            this.labelPrayM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPrayM
            // 
            this.buttonPrayM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrayM.FlatAppearance.BorderSize = 0;
            this.buttonPrayM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPrayM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonPrayM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrayM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrayM.Location = new System.Drawing.Point(223, 51);
            this.buttonPrayM.Name = "buttonPrayM";
            this.buttonPrayM.Size = new System.Drawing.Size(38, 25);
            this.buttonPrayM.TabIndex = 7;
            this.buttonPrayM.Text = "OK";
            this.buttonPrayM.UseVisualStyleBackColor = true;
            this.buttonPrayM.Click += new System.EventHandler(this.buttonPrayM_Click);
            // 
            // comboBoxPrayM
            // 
            this.comboBoxPrayM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPrayM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrayM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPrayM.FormattingEnabled = true;
            this.comboBoxPrayM.Location = new System.Drawing.Point(10, 52);
            this.comboBoxPrayM.Name = "comboBoxPrayM";
            this.comboBoxPrayM.Size = new System.Drawing.Size(206, 25);
            this.comboBoxPrayM.TabIndex = 7;
            // 
            // radioButtonManual
            // 
            this.radioButtonManual.AutoSize = true;
            this.radioButtonManual.Checked = true;
            this.radioButtonManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonManual.Enabled = false;
            this.radioButtonManual.Location = new System.Drawing.Point(148, 270);
            this.radioButtonManual.Name = "radioButtonManual";
            this.radioButtonManual.Size = new System.Drawing.Size(37, 20);
            this.radioButtonManual.TabIndex = 6;
            this.radioButtonManual.TabStop = true;
            this.radioButtonManual.Text = "M";
            this.radioButtonManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonManual.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAuto.Enabled = false;
            this.radioButtonAuto.Location = new System.Drawing.Point(109, 270);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(33, 20);
            this.radioButtonAuto.TabIndex = 5;
            this.radioButtonAuto.Text = "A";
            this.radioButtonAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            this.radioButtonAuto.CheckedChanged += new System.EventHandler(this.radioButtonAuto_CheckedChanged);
            // 
            // labelConfig
            // 
            this.labelConfig.Enabled = false;
            this.labelConfig.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfig.ForeColor = System.Drawing.Color.White;
            this.labelConfig.Location = new System.Drawing.Point(13, 226);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(267, 32);
            this.labelConfig.TabIndex = 4;
            this.labelConfig.Text = "CONFIGURACIÓN";
            this.labelConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetObjective
            // 
            this.buttonSetObjective.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetObjective.FlatAppearance.BorderSize = 0;
            this.buttonSetObjective.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSetObjective.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonSetObjective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetObjective.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetObjective.Location = new System.Drawing.Point(236, 168);
            this.buttonSetObjective.Name = "buttonSetObjective";
            this.buttonSetObjective.Size = new System.Drawing.Size(44, 23);
            this.buttonSetObjective.TabIndex = 2;
            this.buttonSetObjective.Text = "OK";
            this.buttonSetObjective.UseVisualStyleBackColor = true;
            this.buttonSetObjective.Click += new System.EventHandler(this.buttonSetObjective_Click);
            // 
            // comboBoxObjective
            // 
            this.comboBoxObjective.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxObjective.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObjective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxObjective.FormattingEnabled = true;
            this.comboBoxObjective.Location = new System.Drawing.Point(13, 168);
            this.comboBoxObjective.Name = "comboBoxObjective";
            this.comboBoxObjective.Size = new System.Drawing.Size(216, 24);
            this.comboBoxObjective.TabIndex = 1;
            // 
            // labelObjective
            // 
            this.labelObjective.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjective.ForeColor = System.Drawing.Color.Gold;
            this.labelObjective.Location = new System.Drawing.Point(13, 122);
            this.labelObjective.Name = "labelObjective";
            this.labelObjective.Size = new System.Drawing.Size(267, 32);
            this.labelObjective.TabIndex = 0;
            this.labelObjective.Text = "VÉRTICE OBJETIVO";
            this.labelObjective.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBoxAuto.Controls.Add(this.labelPredatorA);
            this.groupBoxAuto.Controls.Add(this.labelPrayA);
            this.groupBoxAuto.Controls.Add(this.numericUpDownPredator);
            this.groupBoxAuto.Controls.Add(this.numericUpDownPray);
            this.groupBoxAuto.Controls.Add(this.buttonSetPredatorA);
            this.groupBoxAuto.Controls.Add(this.buttonSetPrayA);
            this.groupBoxAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAuto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuto.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxAuto.Location = new System.Drawing.Point(13, 306);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(267, 173);
            this.groupBoxAuto.TabIndex = 12;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "automático";
            this.groupBoxAuto.Visible = false;
            // 
            // labelPredatorA
            // 
            this.labelPredatorA.Enabled = false;
            this.labelPredatorA.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPredatorA.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelPredatorA.Location = new System.Drawing.Point(10, 96);
            this.labelPredatorA.Name = "labelPredatorA";
            this.labelPredatorA.Size = new System.Drawing.Size(251, 27);
            this.labelPredatorA.TabIndex = 13;
            this.labelPredatorA.Text = "DEPREDADOR";
            this.labelPredatorA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrayA
            // 
            this.labelPrayA.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrayA.ForeColor = System.Drawing.Color.Red;
            this.labelPrayA.Location = new System.Drawing.Point(10, 21);
            this.labelPrayA.Name = "labelPrayA";
            this.labelPrayA.Size = new System.Drawing.Size(251, 27);
            this.labelPrayA.TabIndex = 12;
            this.labelPrayA.Text = "PRESA";
            this.labelPrayA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownPredator
            // 
            this.numericUpDownPredator.Enabled = false;
            this.numericUpDownPredator.Location = new System.Drawing.Point(11, 128);
            this.numericUpDownPredator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPredator.Name = "numericUpDownPredator";
            this.numericUpDownPredator.Size = new System.Drawing.Size(206, 22);
            this.numericUpDownPredator.TabIndex = 13;
            this.numericUpDownPredator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPredator.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPray
            // 
            this.numericUpDownPray.Location = new System.Drawing.Point(11, 54);
            this.numericUpDownPray.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPray.Name = "numericUpDownPray";
            this.numericUpDownPray.Size = new System.Drawing.Size(206, 22);
            this.numericUpDownPray.TabIndex = 12;
            this.numericUpDownPray.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPray.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSetPredatorA
            // 
            this.buttonSetPredatorA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetPredatorA.Enabled = false;
            this.buttonSetPredatorA.FlatAppearance.BorderSize = 0;
            this.buttonSetPredatorA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSetPredatorA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonSetPredatorA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetPredatorA.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetPredatorA.Location = new System.Drawing.Point(223, 126);
            this.buttonSetPredatorA.Name = "buttonSetPredatorA";
            this.buttonSetPredatorA.Size = new System.Drawing.Size(38, 25);
            this.buttonSetPredatorA.TabIndex = 9;
            this.buttonSetPredatorA.Text = "OK";
            this.buttonSetPredatorA.UseVisualStyleBackColor = true;
            this.buttonSetPredatorA.Click += new System.EventHandler(this.buttonSetPredatorA_Click);
            // 
            // buttonSetPrayA
            // 
            this.buttonSetPrayA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetPrayA.FlatAppearance.BorderSize = 0;
            this.buttonSetPrayA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSetPrayA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonSetPrayA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetPrayA.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetPrayA.Location = new System.Drawing.Point(223, 51);
            this.buttonSetPrayA.Name = "buttonSetPrayA";
            this.buttonSetPrayA.Size = new System.Drawing.Size(38, 25);
            this.buttonSetPrayA.TabIndex = 7;
            this.buttonSetPrayA.Text = "OK";
            this.buttonSetPrayA.UseVisualStyleBackColor = true;
            this.buttonSetPrayA.Click += new System.EventHandler(this.buttonSetPrayA_Click);
            // 
            // SimulationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SimulationWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBoxManual.ResumeLayout(false);
            this.groupBoxAuto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelObjective;
        private System.Windows.Forms.Button buttonSetObjective;
        private System.Windows.Forms.ComboBox comboBoxObjective;
        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.RadioButton radioButtonManual;
        private System.Windows.Forms.Label labelPrayM;
        private System.Windows.Forms.Button buttonPrayM;
        private System.Windows.Forms.ComboBox comboBoxPrayM;
        private System.Windows.Forms.Label labelPredatorM;
        private System.Windows.Forms.Button buttonPredatorM;
        private System.Windows.Forms.ComboBox comboBoxPredatorM;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.Button buttonSetPredatorA;
        private System.Windows.Forms.Button buttonSetPrayA;
        private System.Windows.Forms.NumericUpDown numericUpDownPredator;
        private System.Windows.Forms.NumericUpDown numericUpDownPray;
        private System.Windows.Forms.Label labelPredatorA;
        private System.Windows.Forms.Label labelPrayA;
        private System.Windows.Forms.Button buttonStart;
    }
}