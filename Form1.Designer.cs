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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.straightLine = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.blackColor = new System.Windows.Forms.Button();
            this.redColor = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.blueColor = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.moreColor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonDeleteLastOne = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1105, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // choosePen
            // 
            this.choosePen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.choosePen.FlatAppearance.BorderSize = 0;
            this.choosePen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.chooseEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.chooseEraser.FlatAppearance.BorderSize = 0;
            this.chooseEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.chooseFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.chooseFill.FlatAppearance.BorderSize = 0;
            this.chooseFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseFill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseFill.Image = ((System.Drawing.Image)(resources.GetObject("chooseFill.Image")));
            this.chooseFill.Location = new System.Drawing.Point(86, 68);
            this.chooseFill.Name = "chooseFill";
            this.chooseFill.Size = new System.Drawing.Size(46, 46);
            this.chooseFill.TabIndex = 7;
            this.chooseFill.UseVisualStyleBackColor = false;
            // 
            // choosePipette
            // 
            this.choosePipette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.choosePipette.FlatAppearance.BorderSize = 0;
            this.choosePipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosePipette.Image = ((System.Drawing.Image)(resources.GetObject("choosePipette.Image")));
            this.choosePipette.Location = new System.Drawing.Point(25, 68);
            this.choosePipette.Name = "choosePipette";
            this.choosePipette.Size = new System.Drawing.Size(46, 46);
            this.choosePipette.TabIndex = 8;
            this.choosePipette.UseVisualStyleBackColor = false;
            this.choosePipette.Click += new System.EventHandler(this.choosePipette_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.circle.FlatAppearance.BorderSize = 0;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(230, 9);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(49, 48);
            this.circle.TabIndex = 13;
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // oval
            // 
            this.oval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.oval.FlatAppearance.BorderSize = 0;
            this.oval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oval.Image = ((System.Drawing.Image)(resources.GetObject("oval.Image")));
            this.oval.Location = new System.Drawing.Point(225, 71);
            this.oval.Name = "oval";
            this.oval.Size = new System.Drawing.Size(63, 42);
            this.oval.TabIndex = 14;
            this.oval.UseVisualStyleBackColor = false;
            this.oval.Click += new System.EventHandler(this.oval_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.IsoscelesTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.IsoscelesTriangle.FlatAppearance.BorderSize = 0;
            this.IsoscelesTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.RightTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.RightTriangle.FlatAppearance.BorderSize = 0;
            this.RightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightTriangle.ForeColor = System.Drawing.Color.White;
            this.RightTriangle.Image = ((System.Drawing.Image)(resources.GetObject("RightTriangle.Image")));
            this.RightTriangle.Location = new System.Drawing.Point(362, 4);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(39, 57);
            this.RightTriangle.TabIndex = 18;
            this.RightTriangle.UseVisualStyleBackColor = false;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // lineThickness
            // 
            this.lineThickness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.lineThickness.Location = new System.Drawing.Point(534, 74);
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
            this.buttonRollUp.Location = new System.Drawing.Point(976, 0);
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
            this.buttonExpend.Location = new System.Drawing.Point(1018, 0);
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
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(54)))));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(316, 5);
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
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 126);
            this.panel2.TabIndex = 28;
            // 
            // straightLine
            // 
            this.straightLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.straightLine.FlatAppearance.BorderSize = 0;
            this.straightLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.straightLine.Image = ((System.Drawing.Image)(resources.GetObject("straightLine.Image")));
            this.straightLine.Location = new System.Drawing.Point(419, 13);
            this.straightLine.Name = "straightLine";
            this.straightLine.Size = new System.Drawing.Size(48, 48);
            this.straightLine.TabIndex = 30;
            this.straightLine.UseVisualStyleBackColor = false;
            this.straightLine.Click += new System.EventHandler(this.straightLine_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(419, 74);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 28);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(803, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 25);
            this.button6.TabIndex = 34;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonOrange_CheckedChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(356, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 45);
            this.button5.TabIndex = 31;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(829, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 24);
            this.button7.TabIndex = 35;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonPurple_CheckedChanged);
            // 
            // blackColor
            // 
            this.blackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.blackColor.FlatAppearance.BorderSize = 0;
            this.blackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackColor.Image = ((System.Drawing.Image)(resources.GetObject("blackColor.Image")));
            this.blackColor.Location = new System.Drawing.Point(803, 70);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(27, 20);
            this.blackColor.TabIndex = 40;
            this.blackColor.UseVisualStyleBackColor = false;
            this.blackColor.Click += new System.EventHandler(this.buttonBlack_CheckedChanged);
            // 
            // redColor
            // 
            this.redColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.redColor.FlatAppearance.BorderSize = 0;
            this.redColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redColor.Image = ((System.Drawing.Image)(resources.GetObject("redColor.Image")));
            this.redColor.Location = new System.Drawing.Point(801, 22);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(32, 19);
            this.redColor.TabIndex = 39;
            this.redColor.UseVisualStyleBackColor = false;
            this.redColor.Click += new System.EventHandler(this.buttonRed_CheckedChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(801, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 22);
            this.button8.TabIndex = 36;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonGreen_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(299, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 50);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // blueColor
            // 
            this.blueColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.blueColor.FlatAppearance.BorderSize = 0;
            this.blueColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueColor.Image = ((System.Drawing.Image)(resources.GetObject("blueColor.Image")));
            this.blueColor.Location = new System.Drawing.Point(829, 46);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(32, 22);
            this.blueColor.TabIndex = 37;
            this.blueColor.UseVisualStyleBackColor = false;
            this.blueColor.Click += new System.EventHandler(this.buttonBlue_CheckedChanged);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(829, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 19);
            this.button10.TabIndex = 38;
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
            this.moreColor.Location = new System.Drawing.Point(899, 4);
            this.moreColor.Name = "moreColor";
            this.moreColor.Size = new System.Drawing.Size(203, 117);
            this.moreColor.TabIndex = 0;
            this.moreColor.UseVisualStyleBackColor = false;
            this.moreColor.Click += new System.EventHandler(this.moreColor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(829, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 24);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonGrey_CheckedChanged);
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
            this.buttonDeleteAll.TabIndex = 29;
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
            this.buttonDeleteLastOne.TabIndex = 30;
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
            this.buttonReturn.TabIndex = 31;
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1105, 772);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonDeleteLastOne);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonExpend);
            this.Controls.Add(this.buttonRollUp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TheBestPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonDeleteLastOne;
        private System.Windows.Forms.Button buttonReturn;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

