namespace DrawingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnMini = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNewFile = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSetColor = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnRect = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnFill = new System.Windows.Forms.Button();
            this.BtnPipette = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.WidthPenPanel = new System.Windows.Forms.Panel();
            this.BtnLine3 = new System.Windows.Forms.Button();
            this.BtnLine2 = new System.Windows.Forms.Button();
            this.BtnLine1 = new System.Windows.Forms.Button();
            this.MainColor = new System.Windows.Forms.Panel();
            this.Palette = new System.Windows.Forms.PictureBox();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            this.PnlTop.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.WidthPenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Palette)).BeginInit();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.PnlTop.Controls.Add(this.BtnMini);
            this.PnlTop.Controls.Add(this.BtnSave);
            this.PnlTop.Controls.Add(this.BtnNewFile);
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
            // BtnSave
            // 
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Image = global::DrawingApp.Properties.Resources.diskette;
            this.BtnSave.Location = new System.Drawing.Point(59, 0);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(59, 31);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNewFile
            // 
            this.BtnNewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNewFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNewFile.FlatAppearance.BorderSize = 0;
            this.BtnNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewFile.ForeColor = System.Drawing.Color.Black;
            this.BtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewFile.Image")));
            this.BtnNewFile.Location = new System.Drawing.Point(0, 0);
            this.BtnNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNewFile.Name = "BtnNewFile";
            this.BtnNewFile.Size = new System.Drawing.Size(59, 31);
            this.BtnNewFile.TabIndex = 5;
            this.BtnNewFile.UseVisualStyleBackColor = false;
            this.BtnNewFile.Click += new System.EventHandler(this.BtnNewFile_Click);
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
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 25;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.MainPanel.Controls.Add(this.BtnSetColor, 23, 1);
            this.MainPanel.Controls.Add(this.BtnCircle, 8, 1);
            this.MainPanel.Controls.Add(this.BtnRect, 7, 1);
            this.MainPanel.Controls.Add(this.BtnLine, 6, 1);
            this.MainPanel.Controls.Add(this.BtnFill, 4, 1);
            this.MainPanel.Controls.Add(this.BtnPipette, 3, 1);
            this.MainPanel.Controls.Add(this.BtnClear, 2, 1);
            this.MainPanel.Controls.Add(this.BtnDraw, 1, 1);
            this.MainPanel.Controls.Add(this.WidthPenPanel, 10, 1);
            this.MainPanel.Controls.Add(this.MainColor, 12, 1);
            this.MainPanel.Controls.Add(this.Palette, 13, 1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 31);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.Size = new System.Drawing.Size(799, 68);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // BtnSetColor
            // 
            this.BtnSetColor.FlatAppearance.BorderSize = 0;
            this.BtnSetColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetColor.Image = ((System.Drawing.Image)(resources.GetObject("BtnSetColor.Image")));
            this.BtnSetColor.Location = new System.Drawing.Point(666, 14);
            this.BtnSetColor.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSetColor.Name = "BtnSetColor";
            this.MainPanel.SetRowSpan(this.BtnSetColor, 2);
            this.BtnSetColor.Size = new System.Drawing.Size(38, 44);
            this.BtnSetColor.TabIndex = 12;
            this.BtnSetColor.UseVisualStyleBackColor = true;
            this.BtnSetColor.Click += new System.EventHandler(this.BtnSetColor_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.FlatAppearance.BorderSize = 0;
            this.BtnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCircle.Image = ((System.Drawing.Image)(resources.GetObject("BtnCircle.Image")));
            this.BtnCircle.Location = new System.Drawing.Point(282, 14);
            this.BtnCircle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCircle.Name = "BtnCircle";
            this.MainPanel.SetRowSpan(this.BtnCircle, 2);
            this.BtnCircle.Size = new System.Drawing.Size(38, 44);
            this.BtnCircle.TabIndex = 7;
            this.BtnCircle.Tag = "7";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // BtnRect
            // 
            this.BtnRect.FlatAppearance.BorderSize = 0;
            this.BtnRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRect.Image = ((System.Drawing.Image)(resources.GetObject("BtnRect.Image")));
            this.BtnRect.Location = new System.Drawing.Point(240, 14);
            this.BtnRect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRect.Name = "BtnRect";
            this.MainPanel.SetRowSpan(this.BtnRect, 2);
            this.BtnRect.Size = new System.Drawing.Size(38, 44);
            this.BtnRect.TabIndex = 6;
            this.BtnRect.Tag = "6";
            this.BtnRect.UseVisualStyleBackColor = true;
            this.BtnRect.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.FlatAppearance.BorderSize = 0;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine.Image")));
            this.BtnLine.Location = new System.Drawing.Point(198, 14);
            this.BtnLine.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine.Name = "BtnLine";
            this.MainPanel.SetRowSpan(this.BtnLine, 2);
            this.BtnLine.Size = new System.Drawing.Size(38, 44);
            this.BtnLine.TabIndex = 5;
            this.BtnLine.Tag = "5";
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // BtnFill
            // 
            this.BtnFill.FlatAppearance.BorderSize = 0;
            this.BtnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFill.Image = ((System.Drawing.Image)(resources.GetObject("BtnFill.Image")));
            this.BtnFill.Location = new System.Drawing.Point(136, 14);
            this.BtnFill.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFill.Name = "BtnFill";
            this.MainPanel.SetRowSpan(this.BtnFill, 2);
            this.BtnFill.Size = new System.Drawing.Size(38, 44);
            this.BtnFill.TabIndex = 4;
            this.BtnFill.Tag = "4";
            this.BtnFill.UseVisualStyleBackColor = true;
            this.BtnFill.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // BtnPipette
            // 
            this.BtnPipette.FlatAppearance.BorderSize = 0;
            this.BtnPipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPipette.Image = ((System.Drawing.Image)(resources.GetObject("BtnPipette.Image")));
            this.BtnPipette.Location = new System.Drawing.Point(94, 14);
            this.BtnPipette.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPipette.Name = "BtnPipette";
            this.MainPanel.SetRowSpan(this.BtnPipette, 2);
            this.BtnPipette.Size = new System.Drawing.Size(38, 44);
            this.BtnPipette.TabIndex = 3;
            this.BtnPipette.Tag = "3";
            this.BtnPipette.UseVisualStyleBackColor = true;
            this.BtnPipette.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(52, 14);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.MainPanel.SetRowSpan(this.BtnClear, 2);
            this.BtnClear.Size = new System.Drawing.Size(38, 44);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Tag = "2";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.FlatAppearance.BorderSize = 0;
            this.BtnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraw.Image = ((System.Drawing.Image)(resources.GetObject("BtnDraw.Image")));
            this.BtnDraw.Location = new System.Drawing.Point(10, 14);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDraw.Name = "BtnDraw";
            this.MainPanel.SetRowSpan(this.BtnDraw, 2);
            this.BtnDraw.Size = new System.Drawing.Size(38, 44);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.Tag = "1";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // WidthPenPanel
            // 
            this.WidthPenPanel.Controls.Add(this.BtnLine3);
            this.WidthPenPanel.Controls.Add(this.BtnLine2);
            this.WidthPenPanel.Controls.Add(this.BtnLine1);
            this.WidthPenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidthPenPanel.Location = new System.Drawing.Point(342, 12);
            this.WidthPenPanel.Margin = new System.Windows.Forms.Padding(0);
            this.WidthPenPanel.Name = "WidthPenPanel";
            this.MainPanel.SetRowSpan(this.WidthPenPanel, 2);
            this.WidthPenPanel.Size = new System.Drawing.Size(60, 56);
            this.WidthPenPanel.TabIndex = 8;
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
            this.BtnLine3.Tag = "6";
            this.BtnLine3.UseVisualStyleBackColor = true;
            this.BtnLine3.Click += new System.EventHandler(this.BtnPenWidth_Click);
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
            this.BtnLine2.Tag = "4";
            this.BtnLine2.UseVisualStyleBackColor = true;
            this.BtnLine2.Click += new System.EventHandler(this.BtnPenWidth_Click);
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
            this.BtnLine1.Tag = "2";
            this.BtnLine1.UseVisualStyleBackColor = true;
            this.BtnLine1.Click += new System.EventHandler(this.BtnPenWidth_Click);
            // 
            // MainColor
            // 
            this.MainColor.BackColor = System.Drawing.Color.Black;
            this.MainColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainColor.Location = new System.Drawing.Point(425, 15);
            this.MainColor.Name = "MainColor";
            this.MainPanel.SetRowSpan(this.MainColor, 2);
            this.MainColor.Size = new System.Drawing.Size(36, 42);
            this.MainColor.TabIndex = 10;
            // 
            // Palette
            // 
            this.MainPanel.SetColumnSpan(this.Palette, 10);
            this.Palette.Cursor = System.Windows.Forms.Cursors.Default;
            this.Palette.Image = ((System.Drawing.Image)(resources.GetObject("Palette.Image")));
            this.Palette.Location = new System.Drawing.Point(464, 12);
            this.Palette.Margin = new System.Windows.Forms.Padding(0);
            this.Palette.Name = "Palette";
            this.MainPanel.SetRowSpan(this.Palette, 2);
            this.Palette.Size = new System.Drawing.Size(190, 56);
            this.Palette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Palette.TabIndex = 11;
            this.Palette.TabStop = false;
            this.Palette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Palette_MouseClick);
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
            this.DrawPanel.Click += new System.EventHandler(this.DrawPanel_Click);
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTop.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.WidthPenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Palette)).EndInit();
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnNewFile;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox DrawPanel;
        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.Button BtnPipette;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Button BtnRect;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Panel WidthPenPanel;
        private System.Windows.Forms.Button BtnLine3;
        private System.Windows.Forms.Button BtnLine2;
        private System.Windows.Forms.Button BtnLine1;
        private System.Windows.Forms.Panel MainColor;
        private System.Windows.Forms.PictureBox Palette;
        private System.Windows.Forms.Button BtnMini;
        private System.Windows.Forms.Button BtnSetColor;
    }
}

