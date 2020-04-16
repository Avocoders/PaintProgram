namespace WindowsFormsApp7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choosePen = new System.Windows.Forms.Button();
            this.chooseEraser = new System.Windows.Forms.Button();
            this.chooseFill = new System.Windows.Forms.Button();
            this.choosePipette = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.circle = new System.Windows.Forms.Button();
            this.oval = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.IsoscelesTriangle = new System.Windows.Forms.Button();
            this.RightTriangle = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.ToolStripDropDownButton();
            this.createNew = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTheLastOne = new System.Windows.Forms.ToolStripButton();
            this.deleteAll = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lineThickness = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonYellow = new System.Windows.Forms.RadioButton();
            this.buttonPurple = new System.Windows.Forms.RadioButton();
            this.buttonGreen = new System.Windows.Forms.RadioButton();
            this.buttonGrey = new System.Windows.Forms.RadioButton();
            this.buttonWhite = new System.Windows.Forms.RadioButton();
            this.buttonOrange = new System.Windows.Forms.RadioButton();
            this.buttonBlue = new System.Windows.Forms.RadioButton();
            this.buttonRed = new System.Windows.Forms.RadioButton();
            this.buttonBlack = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRollUp = new System.Windows.Forms.Button();
            this.buttonExpend = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.straightLine = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.blackColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.redColor = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.blueColor = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.moreColor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1128, 370);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // choosePen
            // 
            this.choosePen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.choosePen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePen.Image = ((System.Drawing.Image)(resources.GetObject("choosePen.Image")));
            this.choosePen.Location = new System.Drawing.Point(25, 10);
            this.choosePen.Name = "choosePen";
            this.choosePen.Size = new System.Drawing.Size(46, 46);
            this.choosePen.TabIndex = 4;
            this.choosePen.UseVisualStyleBackColor = false;
            this.choosePen.Click += new System.EventHandler(this.choosePen_Click);
            // 
            // chooseEraser
            // 
            this.chooseEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.chooseEraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseEraser.Image = ((System.Drawing.Image)(resources.GetObject("chooseEraser.Image")));
            this.chooseEraser.Location = new System.Drawing.Point(86, 10);
            this.chooseEraser.Name = "chooseEraser";
            this.chooseEraser.Size = new System.Drawing.Size(46, 46);
            this.chooseEraser.TabIndex = 6;
            this.chooseEraser.UseVisualStyleBackColor = false;
            this.chooseEraser.Click += new System.EventHandler(this.chooseEraser_Click);
            // 
            // chooseFill
            // 
            this.chooseFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.chooseFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseFill.Image = ((System.Drawing.Image)(resources.GetObject("chooseFill.Image")));
            this.chooseFill.Location = new System.Drawing.Point(86, 68);
            this.chooseFill.Name = "chooseFill";
            this.chooseFill.Size = new System.Drawing.Size(46, 46);
            this.chooseFill.TabIndex = 7;
            this.chooseFill.UseVisualStyleBackColor = false;
            // 
            // choosePipette
            // 
            this.choosePipette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.choosePipette.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePipette.Image = ((System.Drawing.Image)(resources.GetObject("choosePipette.Image")));
            this.choosePipette.Location = new System.Drawing.Point(25, 68);
            this.choosePipette.Name = "choosePipette";
            this.choosePipette.Size = new System.Drawing.Size(46, 46);
            this.choosePipette.TabIndex = 8;
            this.choosePipette.UseVisualStyleBackColor = false;
            this.choosePipette.Click += new System.EventHandler(this.choosePipette_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(147, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 126);
            this.textBox1.TabIndex = 11;
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(230, 9);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(49, 48);
            this.circle.TabIndex = 13;
            this.circle.UseVisualStyleBackColor = false;
            // 
            // oval
            // 
            this.oval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.oval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oval.Image = ((System.Drawing.Image)(resources.GetObject("oval.Image")));
            this.oval.Location = new System.Drawing.Point(225, 71);
            this.oval.Name = "oval";
            this.oval.Size = new System.Drawing.Size(63, 42);
            this.oval.TabIndex = 14;
            this.oval.UseVisualStyleBackColor = false;
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square.Image = ((System.Drawing.Image)(resources.GetObject("square.Image")));
            this.square.Location = new System.Drawing.Point(160, 9);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(49, 47);
            this.square.TabIndex = 15;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(160, 70);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(59, 43);
            this.rectangle.TabIndex = 16;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.IsoscelesTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IsoscelesTriangle.Image = ((System.Drawing.Image)(resources.GetObject("IsoscelesTriangle.Image")));
            this.IsoscelesTriangle.Location = new System.Drawing.Point(299, 6);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(49, 53);
            this.IsoscelesTriangle.TabIndex = 17;
            this.IsoscelesTriangle.UseVisualStyleBackColor = false;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.RightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RightTriangle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RightTriangle.Image = ((System.Drawing.Image)(resources.GetObject("RightTriangle.Image")));
            this.RightTriangle.Location = new System.Drawing.Point(362, 4);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(39, 57);
            this.RightTriangle.TabIndex = 18;
            this.RightTriangle.UseVisualStyleBackColor = false;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // file
            // 
            this.file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNew,
            this.open,
            this.save});
            this.file.Image = ((System.Drawing.Image)(resources.GetObject("file.Image")));
            this.file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(49, 22);
            this.file.Text = "Файл";
            // 
            // createNew
            // 
            this.createNew.Image = ((System.Drawing.Image)(resources.GetObject("createNew.Image")));
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(132, 22);
            this.createNew.Text = "Создать";
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(132, 22);
            this.open.Text = "Открыть";
            // 
            // save
            // 
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(132, 22);
            this.save.Text = "Сохранить";
            // 
            // deleteTheLastOne
            // 
            this.deleteTheLastOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTheLastOne.Image = ((System.Drawing.Image)(resources.GetObject("deleteTheLastOne.Image")));
            this.deleteTheLastOne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTheLastOne.Name = "deleteTheLastOne";
            this.deleteTheLastOne.Size = new System.Drawing.Size(23, 22);
            this.deleteTheLastOne.Text = "toolStripButton1";
            this.deleteTheLastOne.Click += new System.EventHandler(this.deleteTheLastOne_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteAll.Image = ((System.Drawing.Image)(resources.GetObject("deleteAll.Image")));
            this.deleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(23, 22);
            this.deleteAll.Text = "toolStripButton2";
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.deleteTheLastOne,
            this.deleteAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 747);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1128, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lineThickness
            // 
            this.lineThickness.BackColor = System.Drawing.Color.White;
            this.lineThickness.Location = new System.Drawing.Point(544, 10);
            this.lineThickness.Maximum = 6;
            this.lineThickness.Minimum = 1;
            this.lineThickness.Name = "lineThickness";
            this.lineThickness.Size = new System.Drawing.Size(204, 45);
            this.lineThickness.SmallChange = 0;
            this.lineThickness.TabIndex = 22;
            this.lineThickness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.lineThickness.Value = 1;
            this.lineThickness.Scroll += new System.EventHandler(this.lineThickness_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonYellow);
            this.tabPage1.Controls.Add(this.buttonPurple);
            this.tabPage1.Controls.Add(this.buttonGreen);
            this.tabPage1.Controls.Add(this.buttonGrey);
            this.tabPage1.Controls.Add(this.buttonWhite);
            this.tabPage1.Controls.Add(this.buttonOrange);
            this.tabPage1.Controls.Add(this.buttonBlue);
            this.tabPage1.Controls.Add(this.buttonRed);
            this.tabPage1.Controls.Add(this.buttonBlack);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 82);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Line Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonYellow
            // 
            this.buttonYellow.AutoSize = true;
            this.buttonYellow.Location = new System.Drawing.Point(189, 54);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(56, 17);
            this.buttonYellow.TabIndex = 8;
            this.buttonYellow.Text = "Yellow";
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.CheckedChanged += new System.EventHandler(this.buttonYellow_CheckedChanged);
            // 
            // buttonPurple
            // 
            this.buttonPurple.AutoSize = true;
            this.buttonPurple.Location = new System.Drawing.Point(189, 31);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(55, 17);
            this.buttonPurple.TabIndex = 7;
            this.buttonPurple.Text = "Purple";
            this.buttonPurple.UseVisualStyleBackColor = true;
            this.buttonPurple.CheckedChanged += new System.EventHandler(this.buttonPurple_CheckedChanged);
            // 
            // buttonGreen
            // 
            this.buttonGreen.AutoSize = true;
            this.buttonGreen.Location = new System.Drawing.Point(189, 7);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(54, 17);
            this.buttonGreen.TabIndex = 6;
            this.buttonGreen.Text = "Green";
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.CheckedChanged += new System.EventHandler(this.buttonGreen_CheckedChanged);
            // 
            // buttonGrey
            // 
            this.buttonGrey.AutoSize = true;
            this.buttonGrey.Location = new System.Drawing.Point(98, 54);
            this.buttonGrey.Name = "buttonGrey";
            this.buttonGrey.Size = new System.Drawing.Size(47, 17);
            this.buttonGrey.TabIndex = 5;
            this.buttonGrey.Text = "Grey";
            this.buttonGrey.UseVisualStyleBackColor = true;
            this.buttonGrey.CheckedChanged += new System.EventHandler(this.buttonGrey_CheckedChanged);
            // 
            // buttonWhite
            // 
            this.buttonWhite.AutoSize = true;
            this.buttonWhite.Location = new System.Drawing.Point(98, 31);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(53, 17);
            this.buttonWhite.TabIndex = 4;
            this.buttonWhite.Text = "White";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.CheckedChanged += new System.EventHandler(this.buttonWhite_CheckedChanged);
            // 
            // buttonOrange
            // 
            this.buttonOrange.AutoSize = true;
            this.buttonOrange.Location = new System.Drawing.Point(98, 6);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(60, 17);
            this.buttonOrange.TabIndex = 3;
            this.buttonOrange.Text = "Orange";
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.CheckedChanged += new System.EventHandler(this.buttonOrange_CheckedChanged);
            // 
            // buttonBlue
            // 
            this.buttonBlue.AutoSize = true;
            this.buttonBlue.Location = new System.Drawing.Point(7, 54);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(46, 17);
            this.buttonBlue.TabIndex = 2;
            this.buttonBlue.Text = "Blue";
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.CheckedChanged += new System.EventHandler(this.buttonBlue_CheckedChanged);
            // 
            // buttonRed
            // 
            this.buttonRed.AutoSize = true;
            this.buttonRed.Location = new System.Drawing.Point(7, 31);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(45, 17);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.Text = "Red";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.CheckedChanged += new System.EventHandler(this.buttonRed_CheckedChanged);
            // 
            // buttonBlack
            // 
            this.buttonBlack.AutoSize = true;
            this.buttonBlack.Checked = true;
            this.buttonBlack.Location = new System.Drawing.Point(7, 7);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(52, 17);
            this.buttonBlack.TabIndex = 0;
            this.buttonBlack.TabStop = true;
            this.buttonBlack.Text = "Black";
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.CheckedChanged += new System.EventHandler(this.buttonBlack_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 639);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 108);
            this.tabControl1.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1082, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(46, 43);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRollUp
            // 
            this.buttonRollUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRollUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.buttonRollUp.FlatAppearance.BorderSize = 0;
            this.buttonRollUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRollUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonRollUp.Image")));
            this.buttonRollUp.Location = new System.Drawing.Point(999, 0);
            this.buttonRollUp.Name = "buttonRollUp";
            this.buttonRollUp.Size = new System.Drawing.Size(46, 43);
            this.buttonRollUp.TabIndex = 24;
            this.buttonRollUp.UseVisualStyleBackColor = false;
            this.buttonRollUp.Click += new System.EventHandler(this.buttonRollUp_Click);
            // 
            // buttonExpend
            // 
            this.buttonExpend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExpend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.buttonExpend.FlatAppearance.BorderSize = 0;
            this.buttonExpend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpend.Image = ((System.Drawing.Image)(resources.GetObject("buttonExpend.Image")));
            this.buttonExpend.Location = new System.Drawing.Point(1041, 0);
            this.buttonExpend.Name = "buttonExpend";
            this.buttonExpend.Size = new System.Drawing.Size(46, 43);
            this.buttonExpend.TabIndex = 25;
            this.buttonExpend.UseVisualStyleBackColor = false;
            this.buttonExpend.Click += new System.EventHandler(this.buttonExpend_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(54)))));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(328, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(426, 38);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = "Геометрия";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.straightLine);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.blackColor);
            this.panel2.Controls.Add(this.chooseEraser);
            this.panel2.Controls.Add(this.choosePipette);
            this.panel2.Controls.Add(this.choosePen);
            this.panel2.Controls.Add(this.lineThickness);
            this.panel2.Controls.Add(this.chooseFill);
            this.panel2.Controls.Add(this.redColor);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.blueColor);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.moreColor);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.IsoscelesTriangle);
            this.panel2.Controls.Add(this.RightTriangle);
            this.panel2.Controls.Add(this.rectangle);
            this.panel2.Controls.Add(this.oval);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Controls.Add(this.square);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 126);
            this.panel2.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(299, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 45);
            this.button5.TabIndex = 31;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(419, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 49);
            this.textBox3.TabIndex = 32;
            // 
            // straightLine
            // 
            this.straightLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.straightLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.straightLine.Image = ((System.Drawing.Image)(resources.GetObject("straightLine.Image")));
            this.straightLine.Location = new System.Drawing.Point(419, 13);
            this.straightLine.Name = "straightLine";
            this.straightLine.Size = new System.Drawing.Size(48, 48);
            this.straightLine.TabIndex = 30;
            this.straightLine.UseVisualStyleBackColor = false;
            this.straightLine.Click += new System.EventHandler(this.straightLine_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(803, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 25);
            this.button6.TabIndex = 34;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(829, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 24);
            this.button7.TabIndex = 35;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // blackColor
            // 
            this.blackColor.FlatAppearance.BorderSize = 0;
            this.blackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackColor.Image = ((System.Drawing.Image)(resources.GetObject("blackColor.Image")));
            this.blackColor.Location = new System.Drawing.Point(803, 70);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(27, 20);
            this.blackColor.TabIndex = 40;
            this.blackColor.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(362, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 50);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // redColor
            // 
            this.redColor.FlatAppearance.BorderSize = 0;
            this.redColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redColor.Image = ((System.Drawing.Image)(resources.GetObject("redColor.Image")));
            this.redColor.Location = new System.Drawing.Point(801, 22);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(32, 19);
            this.redColor.TabIndex = 39;
            this.redColor.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(801, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 22);
            this.button8.TabIndex = 36;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // blueColor
            // 
            this.blueColor.FlatAppearance.BorderSize = 0;
            this.blueColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueColor.Image = ((System.Drawing.Image)(resources.GetObject("blueColor.Image")));
            this.blueColor.Location = new System.Drawing.Point(829, 46);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(32, 22);
            this.blueColor.TabIndex = 37;
            this.blueColor.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(829, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 19);
            this.button10.TabIndex = 38;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // moreColor
            // 
            this.moreColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moreColor.FlatAppearance.BorderSize = 0;
            this.moreColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreColor.Image = ((System.Drawing.Image)(resources.GetObject("moreColor.Image")));
            this.moreColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moreColor.Location = new System.Drawing.Point(893, 1);
            this.moreColor.Name = "moreColor";
            this.moreColor.Size = new System.Drawing.Size(235, 128);
            this.moreColor.TabIndex = 0;
            this.moreColor.UseVisualStyleBackColor = true;
            this.moreColor.Click += new System.EventHandler(this.moreColor_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(829, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 24);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1128, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonExpend);
            this.Controls.Add(this.buttonRollUp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TheBestPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button choosePen;
        private System.Windows.Forms.Button chooseEraser;
        private System.Windows.Forms.Button chooseFill;
        private System.Windows.Forms.Button choosePipette;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button oval;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button IsoscelesTriangle;
        private System.Windows.Forms.Button RightTriangle;
        private System.Windows.Forms.ToolStripDropDownButton file;
        private System.Windows.Forms.ToolStripMenuItem createNew;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripButton deleteTheLastOne;
        private System.Windows.Forms.ToolStripButton deleteAll;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TrackBar lineThickness;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton buttonYellow;
        private System.Windows.Forms.RadioButton buttonPurple;
        private System.Windows.Forms.RadioButton buttonGreen;
        private System.Windows.Forms.RadioButton buttonGrey;
        private System.Windows.Forms.RadioButton buttonWhite;
        private System.Windows.Forms.RadioButton buttonOrange;
        private System.Windows.Forms.RadioButton buttonBlue;
        private System.Windows.Forms.RadioButton buttonRed;
        private System.Windows.Forms.RadioButton buttonBlack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRollUp;
        private System.Windows.Forms.Button buttonExpend;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button moreColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button straightLine;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button blueColor;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button redColor;
        private System.Windows.Forms.Button blackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

