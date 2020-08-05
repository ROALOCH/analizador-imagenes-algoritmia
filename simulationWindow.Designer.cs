namespace iP_Etapa2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationWindow));
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonManualBait = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxManualBait = new System.Windows.Forms.ComboBox();
            this.buttonManualAgents = new System.Windows.Forms.Button();
            this.comboBoxManualAgents = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonManual = new System.Windows.Forms.RadioButton();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelBait = new System.Windows.Forms.Label();
            this.labelAgents = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelManual = new System.Windows.Forms.Panel();
            this.panelAuto = new System.Windows.Forms.Panel();
            this.numericUpDownAutoAgents = new System.Windows.Forms.NumericUpDown();
            this.buttonAutoAgents = new System.Windows.Forms.Button();
            this.comboBoxAutoBait = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAutoBait = new System.Windows.Forms.Button();
            this.labelAte = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.radioButtonAnimateManual = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimateAuto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.panelManual.SuspendLayout();
            this.panelAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAutoAgents)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(1021, 657);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "COLOCAR AGENTES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonManualBait
            // 
            this.buttonManualBait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonManualBait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManualBait.FlatAppearance.BorderSize = 0;
            this.buttonManualBait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManualBait.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonManualBait.Location = new System.Drawing.Point(171, 29);
            this.buttonManualBait.Name = "buttonManualBait";
            this.buttonManualBait.Size = new System.Drawing.Size(39, 25);
            this.buttonManualBait.TabIndex = 2;
            this.buttonManualBait.Text = "OK";
            this.buttonManualBait.UseVisualStyleBackColor = false;
            this.buttonManualBait.Click += new System.EventHandler(this.ButtonManualBait_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "COLOCAR SEÑUELO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxManualBait
            // 
            this.comboBoxManualBait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxManualBait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManualBait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxManualBait.FormattingEnabled = true;
            this.comboBoxManualBait.Location = new System.Drawing.Point(3, 29);
            this.comboBoxManualBait.Name = "comboBoxManualBait";
            this.comboBoxManualBait.Size = new System.Drawing.Size(162, 25);
            this.comboBoxManualBait.TabIndex = 0;
            // 
            // buttonManualAgents
            // 
            this.buttonManualAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonManualAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManualAgents.Enabled = false;
            this.buttonManualAgents.FlatAppearance.BorderSize = 0;
            this.buttonManualAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManualAgents.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonManualAgents.Location = new System.Drawing.Point(171, 84);
            this.buttonManualAgents.Name = "buttonManualAgents";
            this.buttonManualAgents.Size = new System.Drawing.Size(39, 25);
            this.buttonManualAgents.TabIndex = 6;
            this.buttonManualAgents.Text = "OK";
            this.buttonManualAgents.UseVisualStyleBackColor = false;
            this.buttonManualAgents.Click += new System.EventHandler(this.ButtonManualAgents_Click);
            // 
            // comboBoxManualAgents
            // 
            this.comboBoxManualAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxManualAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManualAgents.Enabled = false;
            this.comboBoxManualAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxManualAgents.FormattingEnabled = true;
            this.comboBoxManualAgents.Location = new System.Drawing.Point(3, 84);
            this.comboBoxManualAgents.Name = "comboBoxManualAgents";
            this.comboBoxManualAgents.Size = new System.Drawing.Size(162, 25);
            this.comboBoxManualAgents.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Magenta;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(1039, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "CONFIGURACIÓN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonManual
            // 
            this.radioButtonManual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonManual.Checked = true;
            this.radioButtonManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonManual.FlatAppearance.BorderSize = 0;
            this.radioButtonManual.Location = new System.Drawing.Point(5, 5);
            this.radioButtonManual.Name = "radioButtonManual";
            this.radioButtonManual.Size = new System.Drawing.Size(100, 26);
            this.radioButtonManual.TabIndex = 8;
            this.radioButtonManual.TabStop = true;
            this.radioButtonManual.Text = "M";
            this.radioButtonManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonManual.UseVisualStyleBackColor = true;
            this.radioButtonManual.CheckedChanged += new System.EventHandler(this.RadioButtonManual_CheckedChanged);
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAuto.FlatAppearance.BorderSize = 0;
            this.radioButtonAuto.Location = new System.Drawing.Point(118, 5);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(100, 26);
            this.radioButtonAuto.TabIndex = 9;
            this.radioButtonAuto.Text = "A";
            this.radioButtonAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Magenta;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(1039, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "DETALLES";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(1039, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "SEÑUELO:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(1039, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "AGENTES:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBait
            // 
            this.labelBait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelBait.ForeColor = System.Drawing.SystemColors.Window;
            this.labelBait.Location = new System.Drawing.Point(1152, 228);
            this.labelBait.Name = "labelBait";
            this.labelBait.Size = new System.Drawing.Size(100, 26);
            this.labelBait.TabIndex = 12;
            this.labelBait.Text = "NO";
            this.labelBait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAgents
            // 
            this.labelAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelAgents.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAgents.Location = new System.Drawing.Point(1152, 254);
            this.labelAgents.Name = "labelAgents";
            this.labelAgents.Size = new System.Drawing.Size(100, 26);
            this.labelAgents.TabIndex = 13;
            this.labelAgents.Text = "0";
            this.labelAgents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.Window;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonStart.Location = new System.Drawing.Point(1039, 341);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(213, 25);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "iniciar simulación";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // panelManual
            // 
            this.panelManual.Controls.Add(this.buttonManualAgents);
            this.panelManual.Controls.Add(this.comboBoxManualBait);
            this.panelManual.Controls.Add(this.comboBoxManualAgents);
            this.panelManual.Controls.Add(this.label4);
            this.panelManual.Controls.Add(this.label3);
            this.panelManual.Controls.Add(this.buttonManualBait);
            this.panelManual.Location = new System.Drawing.Point(1039, 73);
            this.panelManual.Name = "panelManual";
            this.panelManual.Size = new System.Drawing.Size(213, 116);
            this.panelManual.TabIndex = 14;
            // 
            // panelAuto
            // 
            this.panelAuto.Controls.Add(this.numericUpDownAutoAgents);
            this.panelAuto.Controls.Add(this.buttonAutoAgents);
            this.panelAuto.Controls.Add(this.comboBoxAutoBait);
            this.panelAuto.Controls.Add(this.label1);
            this.panelAuto.Controls.Add(this.label2);
            this.panelAuto.Controls.Add(this.buttonAutoBait);
            this.panelAuto.Location = new System.Drawing.Point(1039, 73);
            this.panelAuto.Name = "panelAuto";
            this.panelAuto.Size = new System.Drawing.Size(213, 116);
            this.panelAuto.TabIndex = 15;
            // 
            // numericUpDownAutoAgents
            // 
            this.numericUpDownAutoAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownAutoAgents.Enabled = false;
            this.numericUpDownAutoAgents.Location = new System.Drawing.Point(3, 85);
            this.numericUpDownAutoAgents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAutoAgents.Name = "numericUpDownAutoAgents";
            this.numericUpDownAutoAgents.Size = new System.Drawing.Size(162, 23);
            this.numericUpDownAutoAgents.TabIndex = 7;
            this.numericUpDownAutoAgents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAutoAgents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAutoAgents
            // 
            this.buttonAutoAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAutoAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoAgents.Enabled = false;
            this.buttonAutoAgents.FlatAppearance.BorderSize = 0;
            this.buttonAutoAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoAgents.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAutoAgents.Location = new System.Drawing.Point(171, 84);
            this.buttonAutoAgents.Name = "buttonAutoAgents";
            this.buttonAutoAgents.Size = new System.Drawing.Size(39, 25);
            this.buttonAutoAgents.TabIndex = 6;
            this.buttonAutoAgents.Text = "OK";
            this.buttonAutoAgents.UseVisualStyleBackColor = false;
            this.buttonAutoAgents.Click += new System.EventHandler(this.ButtonAutoAgents_Click);
            // 
            // comboBoxAutoBait
            // 
            this.comboBoxAutoBait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAutoBait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutoBait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAutoBait.FormattingEnabled = true;
            this.comboBoxAutoBait.Location = new System.Drawing.Point(3, 29);
            this.comboBoxAutoBait.Name = "comboBoxAutoBait";
            this.comboBoxAutoBait.Size = new System.Drawing.Size(162, 25);
            this.comboBoxAutoBait.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "COLOCAR SEÑUELO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "COLOCAR AGENTES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAutoBait
            // 
            this.buttonAutoBait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAutoBait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoBait.FlatAppearance.BorderSize = 0;
            this.buttonAutoBait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoBait.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAutoBait.Location = new System.Drawing.Point(171, 29);
            this.buttonAutoBait.Name = "buttonAutoBait";
            this.buttonAutoBait.Size = new System.Drawing.Size(39, 25);
            this.buttonAutoBait.TabIndex = 2;
            this.buttonAutoBait.Text = "OK";
            this.buttonAutoBait.UseVisualStyleBackColor = false;
            this.buttonAutoBait.Click += new System.EventHandler(this.ButtonAutoBait_Click);
            // 
            // labelAte
            // 
            this.labelAte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelAte.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAte.Location = new System.Drawing.Point(1152, 280);
            this.labelAte.Name = "labelAte";
            this.labelAte.Size = new System.Drawing.Size(100, 26);
            this.labelAte.TabIndex = 17;
            this.labelAte.Text = "0";
            this.labelAte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(1042, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "ALCANZADOS:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Enabled = false;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonExit.Location = new System.Drawing.Point(1039, 372);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(213, 25);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "salir";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // radioButtonAnimateManual
            // 
            this.radioButtonAnimateManual.Checked = true;
            this.radioButtonAnimateManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAnimateManual.Enabled = false;
            this.radioButtonAnimateManual.FlatAppearance.BorderSize = 0;
            this.radioButtonAnimateManual.Location = new System.Drawing.Point(115, 5);
            this.radioButtonAnimateManual.Name = "radioButtonAnimateManual";
            this.radioButtonAnimateManual.Size = new System.Drawing.Size(100, 26);
            this.radioButtonAnimateManual.TabIndex = 20;
            this.radioButtonAnimateManual.TabStop = true;
            this.radioButtonAnimateManual.Text = "MANUAL";
            this.radioButtonAnimateManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAnimateManual.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnimateAuto
            // 
            this.radioButtonAnimateAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonAnimateAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAnimateAuto.Enabled = false;
            this.radioButtonAnimateAuto.FlatAppearance.BorderSize = 0;
            this.radioButtonAnimateAuto.Location = new System.Drawing.Point(2, 5);
            this.radioButtonAnimateAuto.Name = "radioButtonAnimateAuto";
            this.radioButtonAnimateAuto.Size = new System.Drawing.Size(100, 26);
            this.radioButtonAnimateAuto.TabIndex = 19;
            this.radioButtonAnimateAuto.Text = "AUTO";
            this.radioButtonAnimateAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAnimateAuto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonAuto);
            this.panel1.Controls.Add(this.radioButtonManual);
            this.panel1.Location = new System.Drawing.Point(1039, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 33);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonAnimateManual);
            this.panel2.Controls.Add(this.radioButtonAnimateAuto);
            this.panel2.Location = new System.Drawing.Point(1039, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 34);
            this.panel2.TabIndex = 22;
            // 
            // SimulationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelAte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelAgents);
            this.Controls.Add(this.labelBait);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.panelManual);
            this.Controls.Add(this.panelAuto);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SimulationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.panelManual.ResumeLayout(false);
            this.panelAuto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAutoAgents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button buttonManualAgents;
        private System.Windows.Forms.ComboBox comboBoxManualAgents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonManualBait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxManualBait;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonManual;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelBait;
        private System.Windows.Forms.Label labelAgents;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelManual;
        private System.Windows.Forms.Panel panelAuto;
        private System.Windows.Forms.Button buttonAutoAgents;
        private System.Windows.Forms.ComboBox comboBoxAutoBait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAutoBait;
        private System.Windows.Forms.NumericUpDown numericUpDownAutoAgents;
        private System.Windows.Forms.Label labelAte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonAnimateManual;
        private System.Windows.Forms.RadioButton radioButtonAnimateAuto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}