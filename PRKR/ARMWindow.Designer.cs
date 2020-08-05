namespace R
{
    partial class ARMWindow
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.listBoxKruskal = new System.Windows.Forms.ListBox();
            this.listBoxPrim = new System.Windows.Forms.ListBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKruskalSel = new System.Windows.Forms.Label();
            this.labelPrimSel = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelVertexPrim = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panelMain.Controls.Add(this.listBoxKruskal);
            this.panelMain.Controls.Add(this.listBoxPrim);
            this.panelMain.Controls.Add(this.buttonCompare);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.labelKruskalSel);
            this.panelMain.Controls.Add(this.labelPrimSel);
            this.panelMain.Controls.Add(this.buttonOK);
            this.panelMain.Controls.Add(this.comboBox);
            this.panelMain.Controls.Add(this.labelVertexPrim);
            this.panelMain.Location = new System.Drawing.Point(1012, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(251, 684);
            this.panelMain.TabIndex = 2;
            // 
            // listBoxKruskal
            // 
            this.listBoxKruskal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.listBoxKruskal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxKruskal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKruskal.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxKruskal.FormattingEnabled = true;
            this.listBoxKruskal.ItemHeight = 16;
            this.listBoxKruskal.Location = new System.Drawing.Point(13, 423);
            this.listBoxKruskal.Name = "listBoxKruskal";
            this.listBoxKruskal.Size = new System.Drawing.Size(227, 208);
            this.listBoxKruskal.TabIndex = 16;
            // 
            // listBoxPrim
            // 
            this.listBoxPrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.listBoxPrim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPrim.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrim.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxPrim.FormattingEnabled = true;
            this.listBoxPrim.ItemHeight = 16;
            this.listBoxPrim.Location = new System.Drawing.Point(13, 160);
            this.listBoxPrim.Name = "listBoxPrim";
            this.listBoxPrim.Size = new System.Drawing.Size(227, 208);
            this.listBoxPrim.TabIndex = 15;
            // 
            // buttonCompare
            // 
            this.buttonCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.buttonCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCompare.Enabled = false;
            this.buttonCompare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCompare.FlatAppearance.BorderSize = 0;
            this.buttonCompare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonCompare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.buttonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompare.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompare.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCompare.Location = new System.Drawing.Point(13, 642);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(225, 28);
            this.buttonCompare.TabIndex = 14;
            this.buttonCompare.Text = "COMPARAR ARM";
            this.buttonCompare.UseVisualStyleBackColor = false;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(117, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "KRUSKAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(117, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKruskalSel
            // 
            this.labelKruskalSel.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKruskalSel.ForeColor = System.Drawing.SystemColors.Window;
            this.labelKruskalSel.Location = new System.Drawing.Point(13, 381);
            this.labelKruskalSel.Name = "labelKruskalSel";
            this.labelKruskalSel.Size = new System.Drawing.Size(98, 29);
            this.labelKruskalSel.TabIndex = 10;
            this.labelKruskalSel.Text = "SELECCIÓN";
            this.labelKruskalSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrimSel
            // 
            this.labelPrimSel.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimSel.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPrimSel.Location = new System.Drawing.Point(13, 118);
            this.labelPrimSel.Name = "labelPrimSel";
            this.labelPrimSel.Size = new System.Drawing.Size(98, 29);
            this.labelPrimSel.TabIndex = 8;
            this.labelPrimSel.Text = "SELECCIÓN";
            this.labelPrimSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOK.Location = new System.Drawing.Point(13, 84);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(227, 28);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "GENERAR";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox.DropDownHeight = 320;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.IntegralHeight = false;
            this.comboBox.Location = new System.Drawing.Point(13, 45);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(227, 24);
            this.comboBox.TabIndex = 6;
            // 
            // labelVertexPrim
            // 
            this.labelVertexPrim.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVertexPrim.ForeColor = System.Drawing.SystemColors.Window;
            this.labelVertexPrim.Location = new System.Drawing.Point(13, 13);
            this.labelVertexPrim.Name = "labelVertexPrim";
            this.labelVertexPrim.Size = new System.Drawing.Size(227, 29);
            this.labelVertexPrim.TabIndex = 5;
            this.labelVertexPrim.Text = "VÉRTICE INCIAL PRIM";
            this.labelVertexPrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(996, 657);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // ARMWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ARMWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelVertexPrim;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelPrimSel;
        private System.Windows.Forms.Label labelKruskalSel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.ListBox listBoxKruskal;
        private System.Windows.Forms.ListBox listBoxPrim;
    }
}