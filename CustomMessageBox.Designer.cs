namespace iP_Etapa2
{
    partial class CustomMessageBox
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.baitLimitNumeric = new System.Windows.Forms.NumericUpDown();
            this.labelMessageNumeric = new System.Windows.Forms.Label();
            this.buttonSendNumeric = new System.Windows.Forms.Button();
            this.panelNumeric = new System.Windows.Forms.Panel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baitLimitNumeric)).BeginInit();
            this.panelNumeric.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Magenta;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTitle.Location = new System.Drawing.Point(-3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(322, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "titulo";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baitLimitNumeric
            // 
            this.baitLimitNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baitLimitNumeric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baitLimitNumeric.Location = new System.Drawing.Point(7, 79);
            this.baitLimitNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.baitLimitNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baitLimitNumeric.Name = "baitLimitNumeric";
            this.baitLimitNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baitLimitNumeric.Size = new System.Drawing.Size(238, 23);
            this.baitLimitNumeric.TabIndex = 1;
            this.baitLimitNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.baitLimitNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMessageNumeric
            // 
            this.labelMessageNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelMessageNumeric.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageNumeric.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMessageNumeric.Location = new System.Drawing.Point(7, 9);
            this.labelMessageNumeric.Name = "labelMessageNumeric";
            this.labelMessageNumeric.Size = new System.Drawing.Size(293, 66);
            this.labelMessageNumeric.TabIndex = 2;
            this.labelMessageNumeric.Text = "mensaje";
            this.labelMessageNumeric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSendNumeric
            // 
            this.buttonSendNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSendNumeric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendNumeric.FlatAppearance.BorderSize = 0;
            this.buttonSendNumeric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendNumeric.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSendNumeric.Location = new System.Drawing.Point(251, 79);
            this.buttonSendNumeric.Name = "buttonSendNumeric";
            this.buttonSendNumeric.Size = new System.Drawing.Size(49, 23);
            this.buttonSendNumeric.TabIndex = 3;
            this.buttonSendNumeric.Text = "texto";
            this.buttonSendNumeric.UseVisualStyleBackColor = false;
            this.buttonSendNumeric.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panelNumeric
            // 
            this.panelNumeric.Controls.Add(this.labelMessageNumeric);
            this.panelNumeric.Controls.Add(this.buttonSendNumeric);
            this.panelNumeric.Controls.Add(this.baitLimitNumeric);
            this.panelNumeric.Location = new System.Drawing.Point(5, 34);
            this.panelNumeric.Name = "panelNumeric";
            this.panelNumeric.Size = new System.Drawing.Size(305, 124);
            this.panelNumeric.TabIndex = 4;
            // 
            // panelMessage
            // 
            this.panelMessage.Controls.Add(this.labelMessage);
            this.panelMessage.Controls.Add(this.buttonOK);
            this.panelMessage.Location = new System.Drawing.Point(5, 35);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(305, 120);
            this.panelMessage.TabIndex = 5;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.labelMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMessage.Location = new System.Drawing.Point(6, 1);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(293, 86);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "mensaje";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOK.Location = new System.Drawing.Point(111, 90);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "texto";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(317, 160);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panelNumeric);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            ((System.ComponentModel.ISupportInitialize)(this.baitLimitNumeric)).EndInit();
            this.panelNumeric.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown baitLimitNumeric;
        private System.Windows.Forms.Label labelMessageNumeric;
        private System.Windows.Forms.Button buttonSendNumeric;
        private System.Windows.Forms.Panel panelNumeric;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonOK;
    }
}