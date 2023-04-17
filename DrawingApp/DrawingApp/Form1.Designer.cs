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
            this.BtnMini = new System.Windows.Forms.Button();
            this.BtSave = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSetColor = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnRect = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnFill = new System.Windows.Forms.Button();
            this.BtnPipette = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLine3 = new System.Windows.Forms.Button();
            this.BtnLine2 = new System.Windows.Forms.Button();
            this.BtnLine1 = new System.Windows.Forms.Button();
            this.MainColor = new System.Windows.Forms.Panel();
            this.Palette = new System.Windows.Forms.PictureBox();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            this.PnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Palette)).BeginInit();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.PnlTop.Controls.Add(this.BtnMini);
            this.PnlTop.Controls.Add(this.BtSave);
            this.PnlTop.Controls.Add(this.BtnFile);
            this.PnlTop.Controls.Add(this.BtnMax);
            this.PnlTop.Controls.Add(this.BtnExit);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(799, 31);
            this.PnlTop.TabIndex = 1;
            // 
            // BtnMini
            // 
            this.BtnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMini.FlatAppearance.BorderSize = 0;
            this.BtnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMini.ForeColor = System.Drawing.Color.Black;
            this.BtnMini.Location = new System.Drawing.Point(622, 0);
            this.BtnMini.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMini.Name = "BtnMini";
            this.BtnMini.Size = new System.Drawing.Size(59, 31);
            this.BtnMini.TabIndex = 7;
            this.BtnMini.Text = "-";
            this.BtnMini.UseVisualStyleBackColor = false;
            this.BtnMini.Click += new System.EventHandler(this.BtnMini_Click);
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
            this.BtSave.Location = new System.Drawing.Point(59, 0);
            this.BtSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(59, 31);
            this.BtSave.TabIndex = 6;
            this.BtSave.UseVisualStyleBackColor = false;
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
            this.BtnFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(59, 31);
            this.BtnFile.TabIndex = 5;
            this.BtnFile.Text = "File";
            this.BtnFile.UseVisualStyleBackColor = false;
            // 
            // BtnMax
            // 
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.ForeColor = System.Drawing.Color.Black;
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.Location = new System.Drawing.Point(681, 0);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(59, 31);
            this.BtnMax.TabIndex = 4;
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(740, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(59, 31);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 25;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Controls.Add(this.BtnSetColor, 23, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCircle, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnRect, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnLine, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnFill, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnPipette, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnClear, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnDraw, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainColor, 12, 1);
            this.tableLayoutPanel1.Controls.Add(this.Palette, 13, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 68);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // BtnSetColor
            // 
            this.BtnSetColor.FlatAppearance.BorderSize = 0;
            this.BtnSetColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetColor.Image = ((System.Drawing.Image)(resources.GetObject("BtnSetColor.Image")));
            this.BtnSetColor.Location = new System.Drawing.Point(666, 14);
            this.BtnSetColor.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSetColor.Name = "BtnSetColor";
            this.tableLayoutPanel1.SetRowSpan(this.BtnSetColor, 2);
            this.BtnSetColor.Size = new System.Drawing.Size(38, 44);
            this.BtnSetColor.TabIndex = 12;
            this.BtnSetColor.UseVisualStyleBackColor = true;
            // 
            // BtnCircle
            // 
            this.BtnCircle.FlatAppearance.BorderSize = 0;
            this.BtnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCircle.Image = ((System.Drawing.Image)(resources.GetObject("BtnCircle.Image")));
            this.BtnCircle.Location = new System.Drawing.Point(282, 14);
            this.BtnCircle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCircle.Name = "BtnCircle";
            this.tableLayoutPanel1.SetRowSpan(this.BtnCircle, 2);
            this.BtnCircle.Size = new System.Drawing.Size(38, 44);
            this.BtnCircle.TabIndex = 7;
            this.BtnCircle.UseVisualStyleBackColor = true;
            // 
            // BtnRect
            // 
            this.BtnRect.FlatAppearance.BorderSize = 0;
            this.BtnRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRect.Image = ((System.Drawing.Image)(resources.GetObject("BtnRect.Image")));
            this.BtnRect.Location = new System.Drawing.Point(240, 14);
            this.BtnRect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRect.Name = "BtnRect";
            this.tableLayoutPanel1.SetRowSpan(this.BtnRect, 2);
            this.BtnRect.Size = new System.Drawing.Size(38, 44);
            this.BtnRect.TabIndex = 6;
            this.BtnRect.UseVisualStyleBackColor = true;
            // 
            // BtnLine
            // 
            this.BtnLine.FlatAppearance.BorderSize = 0;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine.Image")));
            this.BtnLine.Location = new System.Drawing.Point(198, 14);
            this.BtnLine.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine.Name = "BtnLine";
            this.tableLayoutPanel1.SetRowSpan(this.BtnLine, 2);
            this.BtnLine.Size = new System.Drawing.Size(38, 44);
            this.BtnLine.TabIndex = 5;
            this.BtnLine.UseVisualStyleBackColor = true;
            // 
            // BtnFill
            // 
            this.BtnFill.FlatAppearance.BorderSize = 0;
            this.BtnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFill.Image = ((System.Drawing.Image)(resources.GetObject("BtnFill.Image")));
            this.BtnFill.Location = new System.Drawing.Point(136, 14);
            this.BtnFill.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFill.Name = "BtnFill";
            this.tableLayoutPanel1.SetRowSpan(this.BtnFill, 2);
            this.BtnFill.Size = new System.Drawing.Size(38, 44);
            this.BtnFill.TabIndex = 4;
            this.BtnFill.UseVisualStyleBackColor = true;
            // 
            // BtnPipette
            // 
            this.BtnPipette.FlatAppearance.BorderSize = 0;
            this.BtnPipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPipette.Image = ((System.Drawing.Image)(resources.GetObject("BtnPipette.Image")));
            this.BtnPipette.Location = new System.Drawing.Point(94, 14);
            this.BtnPipette.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPipette.Name = "BtnPipette";
            this.tableLayoutPanel1.SetRowSpan(this.BtnPipette, 2);
            this.BtnPipette.Size = new System.Drawing.Size(38, 44);
            this.BtnPipette.TabIndex = 3;
            this.BtnPipette.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(52, 14);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.tableLayoutPanel1.SetRowSpan(this.BtnClear, 2);
            this.BtnClear.Size = new System.Drawing.Size(38, 44);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnDraw
            // 
            this.BtnDraw.FlatAppearance.BorderSize = 0;
            this.BtnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraw.Image = ((System.Drawing.Image)(resources.GetObject("BtnDraw.Image")));
            this.BtnDraw.Location = new System.Drawing.Point(10, 14);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDraw.Name = "BtnDraw";
            this.tableLayoutPanel1.SetRowSpan(this.BtnDraw, 2);
            this.BtnDraw.Size = new System.Drawing.Size(38, 44);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLine3);
            this.panel1.Controls.Add(this.BtnLine2);
            this.panel1.Controls.Add(this.BtnLine1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(342, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(60, 48);
            this.panel1.TabIndex = 8;
            // 
            // BtnLine3
            // 
            this.BtnLine3.FlatAppearance.BorderSize = 0;
            this.BtnLine3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine3.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine3.Image")));
            this.BtnLine3.Location = new System.Drawing.Point(2, 31);
            this.BtnLine3.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine3.Name = "BtnLine3";
            this.BtnLine3.Size = new System.Drawing.Size(58, 15);
            this.BtnLine3.TabIndex = 9;
            this.BtnLine3.UseVisualStyleBackColor = true;
            // 
            // BtnLine2
            // 
            this.BtnLine2.FlatAppearance.BorderSize = 0;
            this.BtnLine2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine2.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine2.Image")));
            this.BtnLine2.Location = new System.Drawing.Point(2, 17);
            this.BtnLine2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine2.Name = "BtnLine2";
            this.BtnLine2.Size = new System.Drawing.Size(58, 15);
            this.BtnLine2.TabIndex = 8;
            this.BtnLine2.UseVisualStyleBackColor = true;
            // 
            // BtnLine1
            // 
            this.BtnLine1.FlatAppearance.BorderSize = 0;
            this.BtnLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine1.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine1.Image")));
            this.BtnLine1.Location = new System.Drawing.Point(1, 0);
            this.BtnLine1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine1.Name = "BtnLine1";
            this.BtnLine1.Size = new System.Drawing.Size(58, 15);
            this.BtnLine1.TabIndex = 7;
            this.BtnLine1.UseVisualStyleBackColor = true;
            // 
            // MainColor
            // 
            this.MainColor.BackColor = System.Drawing.Color.Black;
            this.MainColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainColor.Location = new System.Drawing.Point(425, 15);
            this.MainColor.Name = "MainColor";
            this.tableLayoutPanel1.SetRowSpan(this.MainColor, 2);
            this.MainColor.Size = new System.Drawing.Size(36, 42);
            this.MainColor.TabIndex = 10;
            // 
            // Palette
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Palette, 10);
            this.Palette.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Palette.Image = ((System.Drawing.Image)(resources.GetObject("Palette.Image")));
            this.Palette.Location = new System.Drawing.Point(464, 12);
            this.Palette.Margin = new System.Windows.Forms.Padding(0);
            this.Palette.Name = "Palette";
            this.tableLayoutPanel1.SetRowSpan(this.Palette, 2);
            this.Palette.Size = new System.Drawing.Size(190, 48);
            this.Palette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Palette.TabIndex = 11;
            this.Palette.TabStop = false;
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.DrawPanel);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 99);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Padding = new System.Windows.Forms.Padding(4);
            this.PnlMain.Size = new System.Drawing.Size(799, 400);
            this.PnlMain.TabIndex = 3;
            // 
            // DrawPanel
            // 
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(4, 4);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(791, 392);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.TabStop = false;
            // 
            // BtnSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BtnSave";
            this.Text = "Form1";
            this.PnlTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Palette)).EndInit();
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox DrawPanel;
        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.Button BtnPipette;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Button BtnRect;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLine3;
        private System.Windows.Forms.Button BtnLine2;
        private System.Windows.Forms.Button BtnLine1;
        private System.Windows.Forms.Panel MainColor;
        private System.Windows.Forms.PictureBox Palette;
        private System.Windows.Forms.Button BtnMini;
        private System.Windows.Forms.Button BtnSetColor;
    }
}

