namespace DrawingApp
{
    partial class BtnSave
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtnSave));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMinimalize = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.BtSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnPipette = new System.Windows.Forms.Button();
            this.BtnFill = new System.Windows.Forms.Button();
            this.PnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.PnlTop.Controls.Add(this.BtSave);
            this.PnlTop.Controls.Add(this.BtnFile);
            this.PnlTop.Controls.Add(this.BtnMinimalize);
            this.PnlTop.Controls.Add(this.BtnExit);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1065, 38);
            this.PnlTop.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(986, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(79, 38);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMinimalize
            // 
            this.BtnMinimalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMinimalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimalize.FlatAppearance.BorderSize = 0;
            this.BtnMinimalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnMinimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimalize.ForeColor = System.Drawing.Color.Black;
            this.BtnMinimalize.Location = new System.Drawing.Point(907, 0);
            this.BtnMinimalize.Name = "BtnMinimalize";
            this.BtnMinimalize.Size = new System.Drawing.Size(79, 38);
            this.BtnMinimalize.TabIndex = 4;
            this.BtnMinimalize.Text = "-";
            this.BtnMinimalize.UseVisualStyleBackColor = false;
            // 
            // BtnFile
            // 
            this.BtnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFile.FlatAppearance.BorderSize = 0;
            this.BtnFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFile.ForeColor = System.Drawing.Color.Black;
            this.BtnFile.Location = new System.Drawing.Point(0, 0);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(79, 38);
            this.BtnFile.TabIndex = 5;
            this.BtnFile.Text = "File";
            this.BtnFile.UseVisualStyleBackColor = false;
            // 
            // BtSave
            // 
            this.BtSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtSave.FlatAppearance.BorderSize = 0;
            this.BtSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSave.ForeColor = System.Drawing.Color.Black;
            this.BtSave.Image = global::DrawingApp.Properties.Resources.diskette;
            this.BtSave.Location = new System.Drawing.Point(79, 0);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(79, 38);
            this.BtSave.TabIndex = 6;
            this.BtSave.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 25;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.108107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.702702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.306305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.BtnFill, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnPipette, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnClear, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnDraw, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 84);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.DrawPanel);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 122);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.PnlMain.Size = new System.Drawing.Size(1065, 492);
            this.PnlMain.TabIndex = 3;
            // 
            // DrawPanel
            // 
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(5, 5);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(1055, 482);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.TabStop = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.FlatAppearance.BorderSize = 0;
            this.BtnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraw.Image = ((System.Drawing.Image)(resources.GetObject("BtnDraw.Image")));
            this.BtnDraw.Location = new System.Drawing.Point(13, 18);
            this.BtnDraw.Name = "BtnDraw";
            this.tableLayoutPanel1.SetRowSpan(this.BtnDraw, 2);
            this.BtnDraw.Size = new System.Drawing.Size(54, 54);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(78, 18);
            this.BtnClear.Name = "BtnClear";
            this.tableLayoutPanel1.SetRowSpan(this.BtnClear, 2);
            this.BtnClear.Size = new System.Drawing.Size(54, 54);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnPipette
            // 
            this.BtnPipette.FlatAppearance.BorderSize = 0;
            this.BtnPipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPipette.Image = ((System.Drawing.Image)(resources.GetObject("BtnPipette.Image")));
            this.BtnPipette.Location = new System.Drawing.Point(143, 18);
            this.BtnPipette.Name = "BtnPipette";
            this.tableLayoutPanel1.SetRowSpan(this.BtnPipette, 2);
            this.BtnPipette.Size = new System.Drawing.Size(54, 54);
            this.BtnPipette.TabIndex = 3;
            this.BtnPipette.UseVisualStyleBackColor = true;
            // 
            // BtnFill
            // 
            this.BtnFill.FlatAppearance.BorderSize = 0;
            this.BtnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFill.Image = ((System.Drawing.Image)(resources.GetObject("BtnFill.Image")));
            this.BtnFill.Location = new System.Drawing.Point(208, 18);
            this.BtnFill.Name = "BtnFill";
            this.tableLayoutPanel1.SetRowSpan(this.BtnFill, 2);
            this.BtnFill.Size = new System.Drawing.Size(54, 54);
            this.BtnFill.TabIndex = 4;
            this.BtnFill.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 614);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BtnSave";
            this.Text = "Form1";
            this.PnlTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimalize;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox DrawPanel;
        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.Button BtnPipette;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDraw;
    }
}

