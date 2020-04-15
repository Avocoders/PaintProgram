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
            this.insert = new System.Windows.Forms.Button();
            this.choosePen = new System.Windows.Forms.Button();
            this.chooseEraser = new System.Windows.Forms.Button();
            this.chooseFill = new System.Windows.Forms.Button();
            this.choosePipette = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.brushes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 391);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.insert.FlatAppearance.BorderSize = 5;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert.Location = new System.Drawing.Point(0, 28);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(101, 96);
            this.insert.TabIndex = 3;
            this.insert.Text = "Вставить";
            this.insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insert.UseVisualStyleBackColor = false;
            // 
            // choosePen
            // 
            this.choosePen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.choosePen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePen.Image = ((System.Drawing.Image)(resources.GetObject("choosePen.Image")));
            this.choosePen.Location = new System.Drawing.Point(107, 28);
            this.choosePen.Name = "choosePen";
            this.choosePen.Size = new System.Drawing.Size(46, 46);
            this.choosePen.TabIndex = 4;
            this.choosePen.UseVisualStyleBackColor = false;
            this.choosePen.Click += new System.EventHandler(this.choosePen_Click);
            // 
            // chooseEraser
            // 
            this.chooseEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chooseEraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseEraser.Image = ((System.Drawing.Image)(resources.GetObject("chooseEraser.Image")));
            this.chooseEraser.Location = new System.Drawing.Point(107, 78);
            this.chooseEraser.Name = "chooseEraser";
            this.chooseEraser.Size = new System.Drawing.Size(46, 46);
            this.chooseEraser.TabIndex = 6;
            this.chooseEraser.UseVisualStyleBackColor = false;
            this.chooseEraser.Click += new System.EventHandler(this.chooseEraser_Click);
            // 
            // chooseFill
            // 
            this.chooseFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chooseFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseFill.Image = ((System.Drawing.Image)(resources.GetObject("chooseFill.Image")));
            this.chooseFill.Location = new System.Drawing.Point(159, 28);
            this.chooseFill.Name = "chooseFill";
            this.chooseFill.Size = new System.Drawing.Size(46, 46);
            this.chooseFill.TabIndex = 7;
            this.chooseFill.UseVisualStyleBackColor = false;
            // 
            // choosePipette
            // 
            this.choosePipette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.choosePipette.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePipette.Image = ((System.Drawing.Image)(resources.GetObject("choosePipette.Image")));
            this.choosePipette.Location = new System.Drawing.Point(159, 78);
            this.choosePipette.Name = "choosePipette";
            this.choosePipette.Size = new System.Drawing.Size(46, 46);
            this.choosePipette.TabIndex = 8;
            this.choosePipette.UseVisualStyleBackColor = false;
            this.choosePipette.Click += new System.EventHandler(this.choosePipette_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(211, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 71);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // brushes
            // 
            this.brushes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.brushes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brushes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brushes.Location = new System.Drawing.Point(211, 97);
            this.brushes.Name = "brushes";
            this.brushes.Size = new System.Drawing.Size(65, 27);
            this.brushes.TabIndex = 10;
            this.brushes.Text = "Кисти";
            this.brushes.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(282, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 96);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(333, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Фигуры";
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(282, 28);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(49, 29);
            this.circle.TabIndex = 13;
            this.circle.UseVisualStyleBackColor = false;
            // 
            // oval
            // 
            this.oval.BackColor = System.Drawing.Color.White;
            this.oval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oval.Image = ((System.Drawing.Image)(resources.GetObject("oval.Image")));
            this.oval.Location = new System.Drawing.Point(337, 28);
            this.oval.Name = "oval";
            this.oval.Size = new System.Drawing.Size(49, 29);
            this.oval.TabIndex = 14;
            this.oval.UseVisualStyleBackColor = false;
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.White;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square.Image = ((System.Drawing.Image)(resources.GetObject("square.Image")));
            this.square.Location = new System.Drawing.Point(282, 63);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(49, 29);
            this.square.TabIndex = 15;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(337, 63);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(49, 29);
            this.rectangle.TabIndex = 16;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.BackColor = System.Drawing.Color.White;
            this.IsoscelesTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IsoscelesTriangle.Image = ((System.Drawing.Image)(resources.GetObject("IsoscelesTriangle.Image")));
            this.IsoscelesTriangle.Location = new System.Drawing.Point(392, 28);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(49, 29);
            this.IsoscelesTriangle.TabIndex = 17;
            this.IsoscelesTriangle.UseVisualStyleBackColor = false;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.BackColor = System.Drawing.Color.White;
            this.RightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RightTriangle.Image = ((System.Drawing.Image)(resources.GetObject("RightTriangle.Image")));
            this.RightTriangle.Location = new System.Drawing.Point(392, 63);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(49, 29);
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
            this.createNew.Size = new System.Drawing.Size(133, 22);
            this.createNew.Text = "Создать";
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(133, 22);
            this.open.Text = "Открыть";
            // 
            // save
            // 
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 22);
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
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.deleteTheLastOne,
            this.deleteAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1123, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(680, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 96);
            this.panel1.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(1019, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 96);
            this.button4.TabIndex = 21;
            this.button4.Text = " Цвет";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lineThickness
            // 
            this.lineThickness.BackColor = System.Drawing.SystemColors.Control;
            this.lineThickness.Location = new System.Drawing.Point(554, 80);
            this.lineThickness.Maximum = 6;
            this.lineThickness.Minimum = 1;
            this.lineThickness.Name = "lineThickness";
            this.lineThickness.Size = new System.Drawing.Size(120, 45);
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
            this.tabPage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseClick);
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
            this.buttonOrange.Location = new System.Drawing.Point(98, 7);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 527);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 108);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 685);
            this.Controls.Add(this.lineThickness);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RightTriangle);
            this.Controls.Add(this.IsoscelesTriangle);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.square);
            this.Controls.Add(this.oval);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.brushes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.choosePipette);
            this.Controls.Add(this.chooseFill);
            this.Controls.Add(this.chooseEraser);
            this.Controls.Add(this.choosePen);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TheBestPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button choosePen;
        private System.Windows.Forms.Button chooseEraser;
        private System.Windows.Forms.Button chooseFill;
        private System.Windows.Forms.Button choosePipette;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button brushes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
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
    }
}

