namespace iP
{
    partial class resultsWindow
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
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.labelTShape = new System.Windows.Forms.Label();
            this.labelTCircle = new System.Windows.Forms.Label();
            this.labelTOvals = new System.Windows.Forms.Label();
            this.labelInfoShapes = new System.Windows.Forms.Label();
            this.labelInfoCircle = new System.Windows.Forms.Label();
            this.labelInfoOvals = new System.Windows.Forms.Label();
            this.groupBoxInfoImage = new System.Windows.Forms.GroupBox();
            this.groupBoxInfoCircle = new System.Windows.Forms.GroupBox();
            this.labelRadiusC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCenterC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.listBoxGrid = new System.Windows.Forms.ListBox();
            this.buttonShowGrid = new System.Windows.Forms.Button();
            this.buttonHideList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.groupBoxInfoImage.SuspendLayout();
            this.groupBoxInfoCircle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxResult.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(913, 653);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // labelTShape
            // 
            this.labelTShape.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTShape.Location = new System.Drawing.Point(16, 27);
            this.labelTShape.Name = "labelTShape";
            this.labelTShape.Size = new System.Drawing.Size(212, 40);
            this.labelTShape.TabIndex = 2;
            this.labelTShape.Text = "Figuras Detectadas:";
            this.labelTShape.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTCircle
            // 
            this.labelTCircle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTCircle.Location = new System.Drawing.Point(16, 67);
            this.labelTCircle.Name = "labelTCircle";
            this.labelTCircle.Size = new System.Drawing.Size(212, 40);
            this.labelTCircle.TabIndex = 3;
            this.labelTCircle.Text = "Circulos Detectados:";
            this.labelTCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTOvals
            // 
            this.labelTOvals.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOvals.Location = new System.Drawing.Point(16, 107);
            this.labelTOvals.Name = "labelTOvals";
            this.labelTOvals.Size = new System.Drawing.Size(212, 40);
            this.labelTOvals.TabIndex = 4;
            this.labelTOvals.Text = "Ovalos Eliminados:";
            this.labelTOvals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoShapes
            // 
            this.labelInfoShapes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInfoShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfoShapes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoShapes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfoShapes.Location = new System.Drawing.Point(234, 32);
            this.labelInfoShapes.Name = "labelInfoShapes";
            this.labelInfoShapes.Size = new System.Drawing.Size(47, 30);
            this.labelInfoShapes.TabIndex = 5;
            this.labelInfoShapes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfoCircle
            // 
            this.labelInfoCircle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInfoCircle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfoCircle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoCircle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfoCircle.Location = new System.Drawing.Point(234, 72);
            this.labelInfoCircle.Name = "labelInfoCircle";
            this.labelInfoCircle.Size = new System.Drawing.Size(47, 30);
            this.labelInfoCircle.TabIndex = 6;
            this.labelInfoCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfoOvals
            // 
            this.labelInfoOvals.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInfoOvals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfoOvals.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoOvals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfoOvals.Location = new System.Drawing.Point(234, 112);
            this.labelInfoOvals.Name = "labelInfoOvals";
            this.labelInfoOvals.Size = new System.Drawing.Size(47, 30);
            this.labelInfoOvals.TabIndex = 7;
            this.labelInfoOvals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxInfoImage
            // 
            this.groupBoxInfoImage.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxInfoImage.Controls.Add(this.labelTShape);
            this.groupBoxInfoImage.Controls.Add(this.labelInfoOvals);
            this.groupBoxInfoImage.Controls.Add(this.labelInfoCircle);
            this.groupBoxInfoImage.Controls.Add(this.labelInfoShapes);
            this.groupBoxInfoImage.Controls.Add(this.labelTCircle);
            this.groupBoxInfoImage.Controls.Add(this.labelTOvals);
            this.groupBoxInfoImage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoImage.Location = new System.Drawing.Point(935, 14);
            this.groupBoxInfoImage.Name = "groupBoxInfoImage";
            this.groupBoxInfoImage.Size = new System.Drawing.Size(307, 161);
            this.groupBoxInfoImage.TabIndex = 8;
            this.groupBoxInfoImage.TabStop = false;
            this.groupBoxInfoImage.Text = "Informacion de Imagen";
            // 
            // groupBoxInfoCircle
            // 
            this.groupBoxInfoCircle.Controls.Add(this.labelRadiusC);
            this.groupBoxInfoCircle.Controls.Add(this.label3);
            this.groupBoxInfoCircle.Controls.Add(this.labelCenterC);
            this.groupBoxInfoCircle.Controls.Add(this.label1);
            this.groupBoxInfoCircle.Controls.Add(this.buttonShow);
            this.groupBoxInfoCircle.Controls.Add(this.comboBoxList);
            this.groupBoxInfoCircle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCircle.Location = new System.Drawing.Point(935, 181);
            this.groupBoxInfoCircle.Name = "groupBoxInfoCircle";
            this.groupBoxInfoCircle.Size = new System.Drawing.Size(307, 172);
            this.groupBoxInfoCircle.TabIndex = 9;
            this.groupBoxInfoCircle.TabStop = false;
            this.groupBoxInfoCircle.Text = "Informacion de Circulo";
            // 
            // labelRadiusC
            // 
            this.labelRadiusC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRadiusC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRadiusC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadiusC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRadiusC.Location = new System.Drawing.Point(130, 122);
            this.labelRadiusC.Name = "labelRadiusC";
            this.labelRadiusC.Size = new System.Drawing.Size(151, 30);
            this.labelRadiusC.TabIndex = 10;
            this.labelRadiusC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Radio:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCenterC
            // 
            this.labelCenterC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCenterC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCenterC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenterC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCenterC.Location = new System.Drawing.Point(130, 82);
            this.labelCenterC.Name = "labelCenterC";
            this.labelCenterC.Size = new System.Drawing.Size(151, 30);
            this.labelCenterC.TabIndex = 8;
            this.labelCenterC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Centroide:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonShow
            // 
            this.buttonShow.Enabled = false;
            this.buttonShow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(234, 30);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(47, 29);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Ver";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // comboBoxList
            // 
            this.comboBoxList.Enabled = false;
            this.comboBoxList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(16, 30);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(212, 29);
            this.comboBoxList.TabIndex = 0;
            this.comboBoxList.SelectedIndexChanged += new System.EventHandler(this.ComboBoxList_SelectedIndexChanged);
            // 
            // listBoxGrid
            // 
            this.listBoxGrid.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGrid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxGrid.FormattingEnabled = true;
            this.listBoxGrid.ItemHeight = 17;
            this.listBoxGrid.Location = new System.Drawing.Point(935, 395);
            this.listBoxGrid.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxGrid.Name = "listBoxGrid";
            this.listBoxGrid.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxGrid.Size = new System.Drawing.Size(307, 272);
            this.listBoxGrid.TabIndex = 10;
            this.listBoxGrid.Visible = false;
            // 
            // buttonShowGrid
            // 
            this.buttonShowGrid.Enabled = false;
            this.buttonShowGrid.Location = new System.Drawing.Point(935, 358);
            this.buttonShowGrid.Name = "buttonShowGrid";
            this.buttonShowGrid.Size = new System.Drawing.Size(307, 30);
            this.buttonShowGrid.TabIndex = 11;
            this.buttonShowGrid.Text = "Mostrar Lista";
            this.buttonShowGrid.UseVisualStyleBackColor = true;
            this.buttonShowGrid.Click += new System.EventHandler(this.ButtonShowGrid_Click);
            // 
            // buttonHideList
            // 
            this.buttonHideList.Enabled = false;
            this.buttonHideList.Location = new System.Drawing.Point(935, 358);
            this.buttonHideList.Name = "buttonHideList";
            this.buttonHideList.Size = new System.Drawing.Size(307, 30);
            this.buttonHideList.TabIndex = 12;
            this.buttonHideList.Text = "Ocultar Lista";
            this.buttonHideList.UseVisualStyleBackColor = true;
            this.buttonHideList.Visible = false;
            this.buttonHideList.Click += new System.EventHandler(this.ButtonHideList_Click);
            // 
            // resultsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonHideList);
            this.Controls.Add(this.buttonShowGrid);
            this.Controls.Add(this.listBoxGrid);
            this.Controls.Add(this.groupBoxInfoCircle);
            this.Controls.Add(this.groupBoxInfoImage);
            this.Controls.Add(this.pictureBoxResult);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "resultsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados de Procesamiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.groupBoxInfoImage.ResumeLayout(false);
            this.groupBoxInfoCircle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label labelTShape;
        private System.Windows.Forms.Label labelTCircle;
        private System.Windows.Forms.Label labelTOvals;
        private System.Windows.Forms.Label labelInfoShapes;
        private System.Windows.Forms.Label labelInfoCircle;
        private System.Windows.Forms.Label labelInfoOvals;
        private System.Windows.Forms.GroupBox groupBoxInfoImage;
        private System.Windows.Forms.GroupBox groupBoxInfoCircle;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.Label labelRadiusC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCenterC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxGrid;
        private System.Windows.Forms.Button buttonShowGrid;
        private System.Windows.Forms.Button buttonHideList;
    }
}