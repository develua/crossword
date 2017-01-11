namespace Crossword
{
    partial class crosswordForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crosswordForm));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrint = new System.Windows.Forms.ToolStripSplitButton();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGeneration = new System.Windows.Forms.ToolStripButton();
            this.toolStripHideWord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripСheck = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelImageScroll = new System.Windows.Forms.Panel();
            this.questionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUnderline = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.numericSizeFont = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFonts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBg = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.panelImageScroll.SuspendLayout();
            this.panelParameters.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeFont)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AutoSize = false;
            this.toolStripMenu.BackColor = System.Drawing.Color.White;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripPrint,
            this.toolStripSeparator1,
            this.toolStripGeneration,
            this.toolStripHideWord,
            this.toolStripSeparator2,
            this.toolStripPlay,
            this.toolStripСheck});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(884, 40);
            this.toolStripMenu.TabIndex = 0;
            // 
            // toolStripNew
            // 
            this.toolStripNew.AutoSize = false;
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(38, 38);
            this.toolStripNew.Text = "Создать";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.AutoSize = false;
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(38, 38);
            this.toolStripOpen.Text = "Открыть";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.AutoSize = false;
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(38, 38);
            this.toolStripSave.Text = "Сохранить";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.AutoSize = false;
            this.toolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem});
            this.toolStripPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrint.Image")));
            this.toolStripPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrint.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(48, 38);
            this.toolStripPrint.ButtonClick += new System.EventHandler(this.toolStripPrint_ButtonClick);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripGeneration
            // 
            this.toolStripGeneration.AutoSize = false;
            this.toolStripGeneration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGeneration.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGeneration.Image")));
            this.toolStripGeneration.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGeneration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGeneration.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripGeneration.Name = "toolStripGeneration";
            this.toolStripGeneration.Size = new System.Drawing.Size(38, 38);
            this.toolStripGeneration.Text = "Генерация";
            this.toolStripGeneration.Click += new System.EventHandler(this.toolStripGeneration_Click);
            // 
            // toolStripHideWord
            // 
            this.toolStripHideWord.AutoSize = false;
            this.toolStripHideWord.CheckOnClick = true;
            this.toolStripHideWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHideWord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHideWord.Image")));
            this.toolStripHideWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripHideWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHideWord.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripHideWord.Name = "toolStripHideWord";
            this.toolStripHideWord.Size = new System.Drawing.Size(38, 38);
            this.toolStripHideWord.Text = "Скрыть слова";
            this.toolStripHideWord.Click += new System.EventHandler(this.toolStripHideWord_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripPlay
            // 
            this.toolStripPlay.AutoSize = false;
            this.toolStripPlay.BackColor = System.Drawing.Color.White;
            this.toolStripPlay.CheckOnClick = true;
            this.toolStripPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlay.Image")));
            this.toolStripPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlay.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripPlay.Name = "toolStripPlay";
            this.toolStripPlay.Size = new System.Drawing.Size(38, 38);
            this.toolStripPlay.Text = "Режим игры";
            this.toolStripPlay.Click += new System.EventHandler(this.toolStripPlay_Click);
            // 
            // toolStripСheck
            // 
            this.toolStripСheck.AutoSize = false;
            this.toolStripСheck.CheckOnClick = true;
            this.toolStripСheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripСheck.Enabled = false;
            this.toolStripСheck.Image = ((System.Drawing.Image)(resources.GetObject("toolStripСheck.Image")));
            this.toolStripСheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripСheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripСheck.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripСheck.Name = "toolStripСheck";
            this.toolStripСheck.Size = new System.Drawing.Size(38, 38);
            this.toolStripСheck.Text = "Проверить";
            this.toolStripСheck.Click += new System.EventHandler(this.toolStripСheck_Click);
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.BackColor = System.Drawing.Color.Black;
            this.pictureBoxField.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxField.Image")));
            this.pictureBoxField.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(1200, 900);
            this.pictureBoxField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxField.TabIndex = 1;
            this.pictureBoxField.TabStop = false;
            this.pictureBoxField.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBoxField_PreviewKeyDown);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel.Controls.Add(this.panelImageScroll, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelParameters, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(884, 621);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // panelImageScroll
            // 
            this.panelImageScroll.AutoScroll = true;
            this.panelImageScroll.Controls.Add(this.questionsPanel);
            this.panelImageScroll.Controls.Add(this.pictureBoxField);
            this.panelImageScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageScroll.Location = new System.Drawing.Point(3, 3);
            this.panelImageScroll.Name = "panelImageScroll";
            this.panelImageScroll.Size = new System.Drawing.Size(628, 615);
            this.panelImageScroll.TabIndex = 2;
            // 
            // questionsPanel
            // 
            this.questionsPanel.AutoSize = true;
            this.questionsPanel.BackColor = System.Drawing.Color.White;
            this.questionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.questionsPanel.Location = new System.Drawing.Point(0, 903);
            this.questionsPanel.MinimumSize = new System.Drawing.Size(0, 150);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(1203, 150);
            this.questionsPanel.TabIndex = 2;
            // 
            // panelParameters
            // 
            this.panelParameters.BackColor = System.Drawing.Color.White;
            this.panelParameters.Controls.Add(this.groupBox3);
            this.panelParameters.Controls.Add(this.groupBox2);
            this.panelParameters.Controls.Add(this.groupBox1);
            this.panelParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParameters.Location = new System.Drawing.Point(637, 3);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(244, 615);
            this.panelParameters.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUnderline);
            this.groupBox3.Controls.Add(this.buttonItalic);
            this.groupBox3.Controls.Add(this.buttonBold);
            this.groupBox3.Controls.Add(this.buttonColor);
            this.groupBox3.Controls.Add(this.numericSizeFont);
            this.groupBox3.Controls.Add(this.comboBoxFonts);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(23, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 189);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки шрифта";
            // 
            // buttonUnderline
            // 
            this.buttonUnderline.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUnderline.Location = new System.Drawing.Point(122, 144);
            this.buttonUnderline.Name = "buttonUnderline";
            this.buttonUnderline.Size = new System.Drawing.Size(30, 30);
            this.buttonUnderline.TabIndex = 9;
            this.buttonUnderline.Text = "U";
            this.buttonUnderline.UseVisualStyleBackColor = false;
            this.buttonUnderline.Click += new System.EventHandler(this.fontStyle_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.BackColor = System.Drawing.SystemColors.Control;
            this.buttonItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItalic.Location = new System.Drawing.Point(77, 144);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(30, 30);
            this.buttonItalic.TabIndex = 8;
            this.buttonItalic.Text = "I";
            this.buttonItalic.UseVisualStyleBackColor = false;
            this.buttonItalic.Click += new System.EventHandler(this.fontStyle_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBold.Location = new System.Drawing.Point(32, 144);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(30, 30);
            this.buttonBold.TabIndex = 7;
            this.buttonBold.Text = "B";
            this.buttonBold.UseVisualStyleBackColor = false;
            this.buttonBold.Click += new System.EventHandler(this.fontStyle_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Black;
            this.buttonColor.Location = new System.Drawing.Point(107, 105);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(66, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // numericSizeFont
            // 
            this.numericSizeFont.Location = new System.Drawing.Point(107, 71);
            this.numericSizeFont.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericSizeFont.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericSizeFont.Name = "numericSizeFont";
            this.numericSizeFont.Size = new System.Drawing.Size(66, 22);
            this.numericSizeFont.TabIndex = 5;
            this.numericSizeFont.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericSizeFont.ValueChanged += new System.EventHandler(this.numericSizeFont_ValueChanged);
            // 
            // comboBoxFonts
            // 
            this.comboBoxFonts.DropDownHeight = 150;
            this.comboBoxFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFonts.DropDownWidth = 200;
            this.comboBoxFonts.FormattingEnabled = true;
            this.comboBoxFonts.IntegralHeight = false;
            this.comboBoxFonts.Location = new System.Drawing.Point(26, 31);
            this.comboBoxFonts.Name = "comboBoxFonts";
            this.comboBoxFonts.Size = new System.Drawing.Size(147, 24);
            this.comboBoxFonts.TabIndex = 4;
            this.comboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.comboBoxFonts_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цвет";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxBg);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(23, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фоновый рисунок";
            // 
            // pictureBoxBg
            // 
            this.pictureBoxBg.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxBg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBg.Image")));
            this.pictureBoxBg.Location = new System.Drawing.Point(32, 31);
            this.pictureBoxBg.Name = "pictureBoxBg";
            this.pictureBoxBg.Size = new System.Drawing.Size(135, 90);
            this.pictureBoxBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBg.TabIndex = 5;
            this.pictureBoxBg.TabStop = false;
            this.pictureBoxBg.Click += new System.EventHandler(this.pictureBoxBg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericHeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericWidth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер кроссворда";
            // 
            // numericHeight
            // 
            this.numericHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericHeight.Location = new System.Drawing.Point(137, 29);
            this.numericHeight.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(46, 22);
            this.numericHeight.TabIndex = 1;
            this.numericHeight.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericHeight.ValueChanged += new System.EventHandler(this.numericHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "По горизонтали";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "По вертикали";
            // 
            // numericWidth
            // 
            this.numericWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericWidth.Location = new System.Drawing.Point(137, 59);
            this.numericWidth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(46, 22);
            this.numericWidth.TabIndex = 0;
            this.numericWidth.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.Filter = "JPG |*.jpg|JPEG |*.jpeg|PNG|*.png|BMP|*.bmp|GIF|*.gif";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "BIN|*.bin";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "BIN|*.bin";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // crosswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(810, 650);
            this.Name = "crosswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конструктор кроссвордов";
            this.ResizeEnd += new System.EventHandler(this.crosswordForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.crosswordForm_Resize);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelImageScroll.ResumeLayout(false);
            this.panelImageScroll.PerformLayout();
            this.panelParameters.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeFont)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.PictureBox pictureBoxField;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelImageScroll;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripGeneration;
        private System.Windows.Forms.ToolStripButton toolStripPlay;
        private System.Windows.Forms.FlowLayoutPanel questionsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSplitButton toolStripPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxBg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxFonts;
        private System.Windows.Forms.Button buttonUnderline;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.NumericUpDown numericSizeFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton toolStripСheck;
        private System.Windows.Forms.ToolStripButton toolStripHideWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

