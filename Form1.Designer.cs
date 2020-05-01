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
            this.circle = new System.Windows.Forms.Button();
            this.oval = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.IsoscelesTriangle = new System.Windows.Forms.Button();
            this.RightTriangle = new System.Windows.Forms.Button();
            this.lineThickness = new System.Windows.Forms.TrackBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRollUp = new System.Windows.Forms.Button();
            this.buttonExpend = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перемещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перемещениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.верхушкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабируемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меняетФигуруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.margin = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.заливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заливкаОднотоннаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безЗаливкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.blackColor = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.straightLine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.star = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.redColor = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.blueColor = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.moreColor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonDeleteLastOne = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1132, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // choosePen
            // 
            this.choosePen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.choosePen.FlatAppearance.BorderSize = 0;
            this.choosePen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosePen.Image = ((System.Drawing.Image)(resources.GetObject("choosePen.Image")));
            this.choosePen.Location = new System.Drawing.Point(16, 13);
            this.choosePen.Name = "choosePen";
            this.choosePen.Size = new System.Drawing.Size(46, 46);
            this.choosePen.TabIndex = 8;
            this.choosePen.UseVisualStyleBackColor = false;
            this.choosePen.Click += new System.EventHandler(this.choosePen_Click);
            // 
            // chooseEraser
            // 
            this.chooseEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.chooseEraser.FlatAppearance.BorderSize = 0;
            this.chooseEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseEraser.Image = ((System.Drawing.Image)(resources.GetObject("chooseEraser.Image")));
            this.chooseEraser.Location = new System.Drawing.Point(65, 12);
            this.chooseEraser.Name = "chooseEraser";
            this.chooseEraser.Size = new System.Drawing.Size(46, 46);
            this.chooseEraser.TabIndex = 9;
            this.chooseEraser.UseVisualStyleBackColor = false;
            this.chooseEraser.Click += new System.EventHandler(this.chooseEraser_Click);
            // 
            // chooseFill
            // 
            this.chooseFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.chooseFill.FlatAppearance.BorderSize = 0;
            this.chooseFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseFill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseFill.Image = ((System.Drawing.Image)(resources.GetObject("chooseFill.Image")));
            this.chooseFill.Location = new System.Drawing.Point(65, 69);
            this.chooseFill.Name = "chooseFill";
            this.chooseFill.Size = new System.Drawing.Size(46, 46);
            this.chooseFill.TabIndex = 11;
            this.chooseFill.UseVisualStyleBackColor = false;
            this.chooseFill.Click += new System.EventHandler(this.chooseFill_Click);
            // 
            // choosePipette
            // 
            this.choosePipette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.choosePipette.FlatAppearance.BorderSize = 0;
            this.choosePipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosePipette.Image = ((System.Drawing.Image)(resources.GetObject("choosePipette.Image")));
            this.choosePipette.Location = new System.Drawing.Point(16, 69);
            this.choosePipette.Name = "choosePipette";
            this.choosePipette.Size = new System.Drawing.Size(46, 46);
            this.choosePipette.TabIndex = 10;
            this.choosePipette.UseVisualStyleBackColor = false;
            this.choosePipette.Click += new System.EventHandler(this.choosePipette_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.circle.FlatAppearance.BorderSize = 0;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(23, 61);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(45, 52);
            this.circle.TabIndex = 17;
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // oval
            // 
            this.oval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.oval.FlatAppearance.BorderSize = 0;
            this.oval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oval.Image = ((System.Drawing.Image)(resources.GetObject("oval.Image")));
            this.oval.Location = new System.Drawing.Point(74, 61);
            this.oval.Name = "oval";
            this.oval.Size = new System.Drawing.Size(45, 52);
            this.oval.TabIndex = 18;
            this.oval.UseVisualStyleBackColor = false;
            this.oval.Click += new System.EventHandler(this.oval_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Image = ((System.Drawing.Image)(resources.GetObject("square.Image")));
            this.square.Location = new System.Drawing.Point(77, 3);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(44, 52);
            this.square.TabIndex = 13;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(127, 3);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(52, 51);
            this.rectangle.TabIndex = 14;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.IsoscelesTriangle.FlatAppearance.BorderSize = 0;
            this.IsoscelesTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsoscelesTriangle.Image = ((System.Drawing.Image)(resources.GetObject("IsoscelesTriangle.Image")));
            this.IsoscelesTriangle.Location = new System.Drawing.Point(185, 3);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(49, 51);
            this.IsoscelesTriangle.TabIndex = 15;
            this.IsoscelesTriangle.UseVisualStyleBackColor = false;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.RightTriangle.FlatAppearance.BorderSize = 0;
            this.RightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightTriangle.ForeColor = System.Drawing.Color.White;
            this.RightTriangle.Image = ((System.Drawing.Image)(resources.GetObject("RightTriangle.Image")));
            this.RightTriangle.Location = new System.Drawing.Point(240, 3);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(39, 51);
            this.RightTriangle.TabIndex = 16;
            this.RightTriangle.UseVisualStyleBackColor = false;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // lineThickness
            // 
            this.lineThickness.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineThickness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.lineThickness.LargeChange = 1;
            this.lineThickness.Location = new System.Drawing.Point(491, 75);
            this.lineThickness.Minimum = 1;
            this.lineThickness.Name = "lineThickness";
            this.lineThickness.Size = new System.Drawing.Size(255, 45);
            this.lineThickness.TabIndex = 23;
            this.lineThickness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.lineThickness.Value = 1;
            this.lineThickness.Scroll += new System.EventHandler(this.lineThickness_Scroll);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1059, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(46, 43);
            this.buttonClose.TabIndex = 5;
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
            this.buttonRollUp.Location = new System.Drawing.Point(976, 0);
            this.buttonRollUp.Name = "buttonRollUp";
            this.buttonRollUp.Size = new System.Drawing.Size(46, 43);
            this.buttonRollUp.TabIndex = 3;
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
            this.buttonExpend.Location = new System.Drawing.Point(1018, 0);
            this.buttonExpend.Name = "buttonExpend";
            this.buttonExpend.Size = new System.Drawing.Size(46, 43);
            this.buttonExpend.TabIndex = 4;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.margin);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.blackColor);
            this.panel2.Controls.Add(this.chooseEraser);
            this.panel2.Controls.Add(this.choosePipette);
            this.panel2.Controls.Add(this.choosePen);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lineThickness);
            this.panel2.Controls.Add(this.chooseFill);
            this.panel2.Controls.Add(this.redColor);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.blueColor);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.moreColor);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 126);
            this.panel2.TabIndex = 28;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
            this.toolStrip2.Location = new System.Drawing.Point(592, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(66, 54);
            this.toolStrip2.TabIndex = 44;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoSize = false;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.перемещениеToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(63, 54);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripMenuItem.Image")));
            this.topToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(214, 56);
            this.topToolStripMenuItem.Text = "Рисование";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // перемещениеToolStripMenuItem
            // 
            this.перемещениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перемещениеToolStripMenuItem1,
            this.верхушкаToolStripMenuItem,
            this.масштабируемToolStripMenuItem,
            this.меняетФигуруToolStripMenuItem});
            this.перемещениеToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.перемещениеToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.перемещениеToolStripMenuItem.Name = "перемещениеToolStripMenuItem";
            this.перемещениеToolStripMenuItem.Size = new System.Drawing.Size(214, 56);
            this.перемещениеToolStripMenuItem.Text = "Вектора";
            // 
            // перемещениеToolStripMenuItem1
            // 
            this.перемещениеToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.перемещениеToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("перемещениеToolStripMenuItem1.Image")));
            this.перемещениеToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.перемещениеToolStripMenuItem1.Name = "перемещениеToolStripMenuItem1";
            this.перемещениеToolStripMenuItem1.Size = new System.Drawing.Size(263, 56);
            this.перемещениеToolStripMenuItem1.Text = "Перемещение";
            this.перемещениеToolStripMenuItem1.Click += new System.EventHandler(this.перемещениеToolStripMenuItem1_Click);
            // 
            // верхушкаToolStripMenuItem
            // 
            this.верхушкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.верхушкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("верхушкаToolStripMenuItem.Image")));
            this.верхушкаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.верхушкаToolStripMenuItem.Name = "верхушкаToolStripMenuItem";
            this.верхушкаToolStripMenuItem.Size = new System.Drawing.Size(263, 56);
            this.верхушкаToolStripMenuItem.Text = "Верхушка";
            this.верхушкаToolStripMenuItem.Click += new System.EventHandler(this.верхушкаToolStripMenuItem_Click);
            // 
            // масштабируемToolStripMenuItem
            // 
            this.масштабируемToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.масштабируемToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("масштабируемToolStripMenuItem.Image")));
            this.масштабируемToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.масштабируемToolStripMenuItem.Name = "масштабируемToolStripMenuItem";
            this.масштабируемToolStripMenuItem.Size = new System.Drawing.Size(263, 56);
            this.масштабируемToolStripMenuItem.Text = "Масштабируем";
            this.масштабируемToolStripMenuItem.Click += new System.EventHandler(this.масштабируемToolStripMenuItem_Click);
            // 
            // меняетФигуруToolStripMenuItem
            // 
            this.меняетФигуруToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.меняетФигуруToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("меняетФигуруToolStripMenuItem.Image")));
            this.меняетФигуруToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.меняетФигуруToolStripMenuItem.Name = "меняетФигуруToolStripMenuItem";
            this.меняетФигуруToolStripMenuItem.Size = new System.Drawing.Size(263, 56);
            this.меняетФигуруToolStripMenuItem.Text = "Меняет фигуру";
            // 
            // margin
            // 
            this.margin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.margin.FlatAppearance.BorderSize = 0;
            this.margin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.margin.Image = ((System.Drawing.Image)(resources.GetObject("margin.Image")));
            this.margin.Location = new System.Drawing.Point(671, 9);
            this.margin.Name = "margin";
            this.margin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.margin.Size = new System.Drawing.Size(52, 53);
            this.margin.TabIndex = 43;
            this.margin.UseVisualStyleBackColor = false;
            this.margin.Click += new System.EventHandler(this.margin_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(515, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(64, 54);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "Заливка";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заливкаToolStripMenuItem,
            this.заливкаОднотоннаяToolStripMenuItem,
            this.безЗаливкиToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 54);
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // заливкаToolStripMenuItem
            // 
            this.заливкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.заливкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заливкаToolStripMenuItem.Image")));
            this.заливкаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.заливкаToolStripMenuItem.Name = "заливкаToolStripMenuItem";
            this.заливкаToolStripMenuItem.Size = new System.Drawing.Size(239, 56);
            this.заливкаToolStripMenuItem.Text = "Двухцветная";
            this.заливкаToolStripMenuItem.Click += new System.EventHandler(this.заливкаToolStripMenuItem_Click);
            // 
            // заливкаОднотоннаяToolStripMenuItem
            // 
            this.заливкаОднотоннаяToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.заливкаОднотоннаяToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заливкаОднотоннаяToolStripMenuItem.Image")));
            this.заливкаОднотоннаяToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.заливкаОднотоннаяToolStripMenuItem.Name = "заливкаОднотоннаяToolStripMenuItem";
            this.заливкаОднотоннаяToolStripMenuItem.Size = new System.Drawing.Size(239, 56);
            this.заливкаОднотоннаяToolStripMenuItem.Text = "Однотонная";
            this.заливкаОднотоннаяToolStripMenuItem.Click += new System.EventHandler(this.заливкаОднотоннаяToolStripMenuItem_Click);
            // 
            // безЗаливкиToolStripMenuItem
            // 
            this.безЗаливкиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.безЗаливкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("безЗаливкиToolStripMenuItem.Image")));
            this.безЗаливкиToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.безЗаливкиToolStripMenuItem.Name = "безЗаливкиToolStripMenuItem";
            this.безЗаливкиToolStripMenuItem.Size = new System.Drawing.Size(239, 56);
            this.безЗаливкиToolStripMenuItem.Text = "Без заливки";
            this.безЗаливкиToolStripMenuItem.Click += new System.EventHandler(this.безЗаливкиToolStripMenuItem_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(790, 84);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 27);
            this.button9.TabIndex = 26;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(784, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 59);
            this.button1.TabIndex = 24;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(888, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 25);
            this.button6.TabIndex = 30;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonOrange_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(916, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(22, 24);
            this.button7.TabIndex = 34;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonPurple_CheckedChanged);
            // 
            // blackColor
            // 
            this.blackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.blackColor.FlatAppearance.BorderSize = 0;
            this.blackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackColor.Image = ((System.Drawing.Image)(resources.GetObject("blackColor.Image")));
            this.blackColor.Location = new System.Drawing.Point(883, 9);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(27, 20);
            this.blackColor.TabIndex = 27;
            this.blackColor.UseVisualStyleBackColor = false;
            this.blackColor.Click += new System.EventHandler(this.buttonBlack_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.straightLine);
            this.flowLayoutPanel1.Controls.Add(this.square);
            this.flowLayoutPanel1.Controls.Add(this.rectangle);
            this.flowLayoutPanel1.Controls.Add(this.IsoscelesTriangle);
            this.flowLayoutPanel1.Controls.Add(this.RightTriangle);
            this.flowLayoutPanel1.Controls.Add(this.circle);
            this.flowLayoutPanel1.Controls.Add(this.oval);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.star);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.textBox3);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(126, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(336, 120);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // straightLine
            // 
            this.straightLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.straightLine.FlatAppearance.BorderSize = 0;
            this.straightLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.straightLine.Image = ((System.Drawing.Image)(resources.GetObject("straightLine.Image")));
            this.straightLine.Location = new System.Drawing.Point(23, 3);
            this.straightLine.Name = "straightLine";
            this.straightLine.Size = new System.Drawing.Size(48, 51);
            this.straightLine.TabIndex = 12;
            this.straightLine.Text = " ";
            this.straightLine.UseVisualStyleBackColor = false;
            this.straightLine.Click += new System.EventHandler(this.straightLine_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(125, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 50);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // star
            // 
            this.star.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.star.FlatAppearance.BorderSize = 0;
            this.star.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star.Image = ((System.Drawing.Image)(resources.GetObject("star.Image")));
            this.star.Location = new System.Drawing.Point(182, 61);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(48, 52);
            this.star.TabIndex = 20;
            this.star.UseVisualStyleBackColor = false;
            this.star.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(236, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 52);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(124)))));
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(290, 73);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 30);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown_1);
            // 
            // redColor
            // 
            this.redColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.redColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.redColor.FlatAppearance.BorderSize = 0;
            this.redColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redColor.Image = ((System.Drawing.Image)(resources.GetObject("redColor.Image")));
            this.redColor.Location = new System.Drawing.Point(888, 63);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(20, 28);
            this.redColor.TabIndex = 29;
            this.redColor.UseVisualStyleBackColor = false;
            this.redColor.Click += new System.EventHandler(this.buttonRed_CheckedChanged);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(888, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(20, 22);
            this.button8.TabIndex = 28;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonGreen_CheckedChanged);
            // 
            // blueColor
            // 
            this.blueColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.blueColor.FlatAppearance.BorderSize = 0;
            this.blueColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueColor.Image = ((System.Drawing.Image)(resources.GetObject("blueColor.Image")));
            this.blueColor.Location = new System.Drawing.Point(916, 37);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(22, 22);
            this.blueColor.TabIndex = 32;
            this.blueColor.UseVisualStyleBackColor = false;
            this.blueColor.Click += new System.EventHandler(this.buttonBlue_CheckedChanged);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(916, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(22, 26);
            this.button10.TabIndex = 31;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.buttonYellow_CheckedChanged);
            // 
            // moreColor
            // 
            this.moreColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moreColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.moreColor.FlatAppearance.BorderSize = 0;
            this.moreColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreColor.Image = ((System.Drawing.Image)(resources.GetObject("moreColor.Image")));
            this.moreColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moreColor.Location = new System.Drawing.Point(957, 9);
            this.moreColor.Name = "moreColor";
            this.moreColor.Size = new System.Drawing.Size(148, 117);
            this.moreColor.TabIndex = 35;
            this.moreColor.UseVisualStyleBackColor = false;
            this.moreColor.Click += new System.EventHandler(this.moreColor_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(916, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 24);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonGrey_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(821, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 43);
            this.button4.TabIndex = 25;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteAll.FlatAppearance.BorderSize = 0;
            this.buttonDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteAll.Image")));
            this.buttonDeleteAll.Location = new System.Drawing.Point(0, 737);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(59, 36);
            this.buttonDeleteAll.TabIndex = 36;
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // buttonDeleteLastOne
            // 
            this.buttonDeleteLastOne.FlatAppearance.BorderSize = 0;
            this.buttonDeleteLastOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteLastOne.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteLastOne.Image")));
            this.buttonDeleteLastOne.Location = new System.Drawing.Point(12, 73);
            this.buttonDeleteLastOne.Name = "buttonDeleteLastOne";
            this.buttonDeleteLastOne.Size = new System.Drawing.Size(42, 36);
            this.buttonDeleteLastOne.TabIndex = 6;
            this.buttonDeleteLastOne.UseVisualStyleBackColor = true;
            this.buttonDeleteLastOne.Click += new System.EventHandler(this.deleteTheLastOne_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.Location = new System.Drawing.Point(49, 73);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(42, 36);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(502, 737);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(39, 35);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.Location = new System.Drawing.Point(547, 737);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(39, 35);
            this.buttonOpen.TabIndex = 38;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1058, 737);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 25);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(364, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(367, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1105, 772);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonDeleteLastOne);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonExpend);
            this.Controls.Add(this.buttonRollUp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TheBestPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button choosePen;
        private System.Windows.Forms.Button chooseEraser;
        private System.Windows.Forms.Button chooseFill;
        private System.Windows.Forms.Button choosePipette;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button oval;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button IsoscelesTriangle;
        private System.Windows.Forms.Button RightTriangle;
        private System.Windows.Forms.TrackBar lineThickness;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRollUp;
        private System.Windows.Forms.Button buttonExpend;
        private System.Windows.Forms.PictureBox pictureBox3;
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
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonDeleteLastOne;
        private System.Windows.Forms.Button buttonReturn;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem заливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безЗаливкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заливкаОднотоннаяToolStripMenuItem;
        private System.Windows.Forms.Button margin;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перемещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перемещениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem верхушкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масштабируемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem меняетФигуруToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

