namespace HUNT
{
    partial class ConfigWindow
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
            this.panel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxHealth = new System.Windows.Forms.GroupBox();
            this.radioButtonHealthNo = new System.Windows.Forms.RadioButton();
            this.radioButtonHealthYes = new System.Windows.Forms.RadioButton();
            this.groupBoxRouting = new System.Windows.Forms.GroupBox();
            this.radioButtonRouteNo = new System.Windows.Forms.RadioButton();
            this.radioButtonRouteYes = new System.Windows.Forms.RadioButton();
            this.groupBoxRelations = new System.Windows.Forms.GroupBox();
            this.radioButtonRelationNo = new System.Windows.Forms.RadioButton();
            this.radioButtonRelationYes = new System.Windows.Forms.RadioButton();
            this.groupBoxRadar = new System.Windows.Forms.GroupBox();
            this.labelRadarSize = new System.Windows.Forms.Label();
            this.trackBarRadar = new System.Windows.Forms.TrackBar();
            this.radioButtonRadarNo = new System.Windows.Forms.RadioButton();
            this.radioButtonRadarYes = new System.Windows.Forms.RadioButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.groupBoxHealth.SuspendLayout();
            this.groupBoxRouting.SuspendLayout();
            this.groupBoxRelations.SuspendLayout();
            this.groupBoxRadar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel.Controls.Add(this.buttonCancel);
            this.panel.Controls.Add(this.buttonStart);
            this.panel.Controls.Add(this.groupBoxHealth);
            this.panel.Controls.Add(this.groupBoxRouting);
            this.panel.Controls.Add(this.groupBoxRelations);
            this.panel.Controls.Add(this.groupBoxRadar);
            this.panel.Controls.Add(this.labelTitle);
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(759, 536);
            this.panel.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Location = new System.Drawing.Point(389, 473);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(173, 48);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonStart.Location = new System.Drawing.Point(209, 473);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(174, 48);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "iniciar";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxHealth
            // 
            this.groupBoxHealth.CausesValidation = false;
            this.groupBoxHealth.Controls.Add(this.radioButtonHealthNo);
            this.groupBoxHealth.Controls.Add(this.radioButtonHealthYes);
            this.groupBoxHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxHealth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHealth.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxHealth.Location = new System.Drawing.Point(209, 391);
            this.groupBoxHealth.Name = "groupBoxHealth";
            this.groupBoxHealth.Size = new System.Drawing.Size(353, 65);
            this.groupBoxHealth.TabIndex = 7;
            this.groupBoxHealth.TabStop = false;
            this.groupBoxHealth.Text = "Barra de Salud";
            // 
            // radioButtonHealthNo
            // 
            this.radioButtonHealthNo.CausesValidation = false;
            this.radioButtonHealthNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonHealthNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHealthNo.Location = new System.Drawing.Point(180, 26);
            this.radioButtonHealthNo.Name = "radioButtonHealthNo";
            this.radioButtonHealthNo.Size = new System.Drawing.Size(167, 25);
            this.radioButtonHealthNo.TabIndex = 5;
            this.radioButtonHealthNo.Text = "OCULTAR";
            this.radioButtonHealthNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonHealthNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonHealthYes
            // 
            this.radioButtonHealthYes.CausesValidation = false;
            this.radioButtonHealthYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonHealthYes.Checked = true;
            this.radioButtonHealthYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonHealthYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButtonHealthYes.FlatAppearance.BorderSize = 5;
            this.radioButtonHealthYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonHealthYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonHealthYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radioButtonHealthYes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHealthYes.Location = new System.Drawing.Point(6, 26);
            this.radioButtonHealthYes.Name = "radioButtonHealthYes";
            this.radioButtonHealthYes.Size = new System.Drawing.Size(168, 25);
            this.radioButtonHealthYes.TabIndex = 4;
            this.radioButtonHealthYes.TabStop = true;
            this.radioButtonHealthYes.Text = "MOSTRAR";
            this.radioButtonHealthYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonHealthYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxRouting
            // 
            this.groupBoxRouting.CausesValidation = false;
            this.groupBoxRouting.Controls.Add(this.radioButtonRouteNo);
            this.groupBoxRouting.Controls.Add(this.radioButtonRouteYes);
            this.groupBoxRouting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRouting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRouting.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxRouting.Location = new System.Drawing.Point(209, 310);
            this.groupBoxRouting.Name = "groupBoxRouting";
            this.groupBoxRouting.Size = new System.Drawing.Size(353, 65);
            this.groupBoxRouting.TabIndex = 6;
            this.groupBoxRouting.TabStop = false;
            this.groupBoxRouting.Text = "Visualización de Ruta";
            // 
            // radioButtonRouteNo
            // 
            this.radioButtonRouteNo.CausesValidation = false;
            this.radioButtonRouteNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRouteNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRouteNo.Location = new System.Drawing.Point(180, 26);
            this.radioButtonRouteNo.Name = "radioButtonRouteNo";
            this.radioButtonRouteNo.Size = new System.Drawing.Size(167, 25);
            this.radioButtonRouteNo.TabIndex = 5;
            this.radioButtonRouteNo.Text = "OCULTAR";
            this.radioButtonRouteNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRouteNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonRouteYes
            // 
            this.radioButtonRouteYes.CausesValidation = false;
            this.radioButtonRouteYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRouteYes.Checked = true;
            this.radioButtonRouteYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRouteYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButtonRouteYes.FlatAppearance.BorderSize = 5;
            this.radioButtonRouteYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonRouteYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonRouteYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radioButtonRouteYes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRouteYes.Location = new System.Drawing.Point(6, 26);
            this.radioButtonRouteYes.Name = "radioButtonRouteYes";
            this.radioButtonRouteYes.Size = new System.Drawing.Size(168, 25);
            this.radioButtonRouteYes.TabIndex = 4;
            this.radioButtonRouteYes.TabStop = true;
            this.radioButtonRouteYes.Text = "MOSTRAR";
            this.radioButtonRouteYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRouteYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxRelations
            // 
            this.groupBoxRelations.Controls.Add(this.radioButtonRelationNo);
            this.groupBoxRelations.Controls.Add(this.radioButtonRelationYes);
            this.groupBoxRelations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRelations.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRelations.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxRelations.Location = new System.Drawing.Point(209, 229);
            this.groupBoxRelations.Name = "groupBoxRelations";
            this.groupBoxRelations.Size = new System.Drawing.Size(353, 65);
            this.groupBoxRelations.TabIndex = 2;
            this.groupBoxRelations.TabStop = false;
            this.groupBoxRelations.Text = "Relación Presa-Depredador";
            // 
            // radioButtonRelationNo
            // 
            this.radioButtonRelationNo.CausesValidation = false;
            this.radioButtonRelationNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRelationNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRelationNo.Location = new System.Drawing.Point(180, 26);
            this.radioButtonRelationNo.Name = "radioButtonRelationNo";
            this.radioButtonRelationNo.Size = new System.Drawing.Size(167, 25);
            this.radioButtonRelationNo.TabIndex = 5;
            this.radioButtonRelationNo.Text = "OCULTAR";
            this.radioButtonRelationNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRelationNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonRelationYes
            // 
            this.radioButtonRelationYes.CausesValidation = false;
            this.radioButtonRelationYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRelationYes.Checked = true;
            this.radioButtonRelationYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRelationYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButtonRelationYes.FlatAppearance.BorderSize = 5;
            this.radioButtonRelationYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonRelationYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonRelationYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radioButtonRelationYes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRelationYes.Location = new System.Drawing.Point(6, 26);
            this.radioButtonRelationYes.Name = "radioButtonRelationYes";
            this.radioButtonRelationYes.Size = new System.Drawing.Size(168, 25);
            this.radioButtonRelationYes.TabIndex = 4;
            this.radioButtonRelationYes.TabStop = true;
            this.radioButtonRelationYes.Text = "MOSTRAR";
            this.radioButtonRelationYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRelationYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxRadar
            // 
            this.groupBoxRadar.CausesValidation = false;
            this.groupBoxRadar.Controls.Add(this.labelRadarSize);
            this.groupBoxRadar.Controls.Add(this.trackBarRadar);
            this.groupBoxRadar.Controls.Add(this.radioButtonRadarNo);
            this.groupBoxRadar.Controls.Add(this.radioButtonRadarYes);
            this.groupBoxRadar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRadar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRadar.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxRadar.Location = new System.Drawing.Point(209, 68);
            this.groupBoxRadar.Name = "groupBoxRadar";
            this.groupBoxRadar.Size = new System.Drawing.Size(353, 145);
            this.groupBoxRadar.TabIndex = 1;
            this.groupBoxRadar.TabStop = false;
            this.groupBoxRadar.Text = "Radar Depredador";
            // 
            // labelRadarSize
            // 
            this.labelRadarSize.AutoSize = true;
            this.labelRadarSize.CausesValidation = false;
            this.labelRadarSize.Location = new System.Drawing.Point(100, 111);
            this.labelRadarSize.Name = "labelRadarSize";
            this.labelRadarSize.Size = new System.Drawing.Size(152, 19);
            this.labelRadarSize.TabIndex = 3;
            this.labelRadarSize.Text = "RADIO: 100 PIXELES";
            // 
            // trackBarRadar
            // 
            this.trackBarRadar.CausesValidation = false;
            this.trackBarRadar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarRadar.LargeChange = 50;
            this.trackBarRadar.Location = new System.Drawing.Point(43, 63);
            this.trackBarRadar.Maximum = 500;
            this.trackBarRadar.Minimum = 100;
            this.trackBarRadar.Name = "trackBarRadar";
            this.trackBarRadar.Size = new System.Drawing.Size(265, 45);
            this.trackBarRadar.SmallChange = 50;
            this.trackBarRadar.TabIndex = 2;
            this.trackBarRadar.TickFrequency = 50;
            this.trackBarRadar.Value = 100;
            this.trackBarRadar.Scroll += new System.EventHandler(this.trackBarRadar_Scroll);
            // 
            // radioButtonRadarNo
            // 
            this.radioButtonRadarNo.CausesValidation = false;
            this.radioButtonRadarNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRadarNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRadarNo.Location = new System.Drawing.Point(180, 30);
            this.radioButtonRadarNo.Name = "radioButtonRadarNo";
            this.radioButtonRadarNo.Size = new System.Drawing.Size(167, 25);
            this.radioButtonRadarNo.TabIndex = 1;
            this.radioButtonRadarNo.Text = "OCULTAR";
            this.radioButtonRadarNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRadarNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadarYes
            // 
            this.radioButtonRadarYes.CausesValidation = false;
            this.radioButtonRadarYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRadarYes.Checked = true;
            this.radioButtonRadarYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRadarYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButtonRadarYes.FlatAppearance.BorderSize = 5;
            this.radioButtonRadarYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonRadarYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.radioButtonRadarYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radioButtonRadarYes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRadarYes.Location = new System.Drawing.Point(6, 30);
            this.radioButtonRadarYes.Name = "radioButtonRadarYes";
            this.radioButtonRadarYes.Size = new System.Drawing.Size(168, 25);
            this.radioButtonRadarYes.TabIndex = 0;
            this.radioButtonRadarYes.TabStop = true;
            this.radioButtonRadarYes.Text = "MOSTRAR";
            this.radioButtonRadarYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRadarYes.UseVisualStyleBackColor = true;
            this.radioButtonRadarYes.CheckedChanged += new System.EventHandler(this.radioButtonRadarYes_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lemon/Milk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTitle.Location = new System.Drawing.Point(204, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(358, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "CONFIGURACIÓN DE VISUALES";
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBoxHealth.ResumeLayout(false);
            this.groupBoxRouting.ResumeLayout(false);
            this.groupBoxRelations.ResumeLayout(false);
            this.groupBoxRadar.ResumeLayout(false);
            this.groupBoxRadar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxRadar;
        private System.Windows.Forms.GroupBox groupBoxRelations;
        private System.Windows.Forms.RadioButton radioButtonRadarNo;
        private System.Windows.Forms.RadioButton radioButtonRadarYes;
        private System.Windows.Forms.TrackBar trackBarRadar;
        private System.Windows.Forms.Label labelRadarSize;
        private System.Windows.Forms.RadioButton radioButtonRelationNo;
        private System.Windows.Forms.RadioButton radioButtonRelationYes;
        private System.Windows.Forms.GroupBox groupBoxRouting;
        private System.Windows.Forms.RadioButton radioButtonRouteNo;
        private System.Windows.Forms.RadioButton radioButtonRouteYes;
        private System.Windows.Forms.GroupBox groupBoxHealth;
        private System.Windows.Forms.RadioButton radioButtonHealthNo;
        private System.Windows.Forms.RadioButton radioButtonHealthYes;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonStart;
    }
}