namespace iP_Etapa2
{
    partial class mainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelControl.Controls.Add(this.buttonExit);
            this.panelControl.Controls.Add(this.buttonSave);
            this.panelControl.Controls.Add(this.buttonGraph);
            this.panelControl.Controls.Add(this.buttonDetails);
            this.panelControl.Controls.Add(this.buttonCompare);
            this.panelControl.Controls.Add(this.buttonMaximize);
            this.panelControl.Controls.Add(this.buttonProcess);
            this.panelControl.Controls.Add(this.buttonAdd);
            this.panelControl.Controls.Add(this.pictureBoxLogo);
            this.panelControl.Location = new System.Drawing.Point(1012, -1);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(255, 689);
            this.panelControl.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(11, 625);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(230, 45);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "salir";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(11, 574);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(230, 45);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "guardar";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGraph.Enabled = false;
            this.buttonGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraph.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGraph.Location = new System.Drawing.Point(11, 523);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(230, 45);
            this.buttonGraph.TabIndex = 6;
            this.buttonGraph.Text = "grafo";
            this.buttonGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGraph.UseVisualStyleBackColor = false;
            this.buttonGraph.Click += new System.EventHandler(this.ButtonGraph_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDetails.Enabled = false;
            this.buttonDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDetails.Location = new System.Drawing.Point(11, 472);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(230, 45);
            this.buttonDetails.TabIndex = 5;
            this.buttonDetails.Text = "detalles";
            this.buttonDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDetails.UseVisualStyleBackColor = false;
            this.buttonDetails.Click += new System.EventHandler(this.ButtonDetails_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCompare.Enabled = false;
            this.buttonCompare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCompare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonCompare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompare.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompare.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCompare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompare.Location = new System.Drawing.Point(11, 421);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(230, 45);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "comparar";
            this.buttonCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCompare.UseVisualStyleBackColor = false;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximize.Enabled = false;
            this.buttonMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximize.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaximize.Location = new System.Drawing.Point(11, 370);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(230, 45);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.Text = "maximizar";
            this.buttonMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProcess.Enabled = false;
            this.buttonProcess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcess.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcess.Location = new System.Drawing.Point(11, 319);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(230, 45);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "procesar";
            this.buttonProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonProcess.UseVisualStyleBackColor = false;
            this.buttonProcess.Click += new System.EventHandler(this.ButtonProcess_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(11, 268);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(230, 45);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "agregar";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Enabled = false;
            this.pictureBoxLogo.Image = global::iP_Etapa2.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 16);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(230, 230);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogo_Click);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxDisplay.Image = global::iP_Etapa2.Properties.Resources.noFileMini;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(994, 657);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iR";
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonProcess;
    }
}

