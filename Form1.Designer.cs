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
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripSplitButton1.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 445);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 108);
            this.tabControl1.TabIndex = 2;
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
            this.buttonYellow.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYellow.Location = new System.Drawing.Point(189, 54);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(64, 21);
            this.buttonYellow.TabIndex = 8;
            this.buttonYellow.Text = "Yellow";
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.CheckedChanged += new System.EventHandler(this.buttonYellow_CheckedChanged);
            // 
            // buttonPurple
            // 
            this.buttonPurple.AutoSize = true;
            this.buttonPurple.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurple.Location = new System.Drawing.Point(189, 31);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(64, 21);
            this.buttonPurple.TabIndex = 7;
            this.buttonPurple.Text = "Purple";
            this.buttonPurple.UseVisualStyleBackColor = true;
            this.buttonPurple.CheckedChanged += new System.EventHandler(this.buttonPurple_CheckedChanged);
            // 
            // buttonGreen
            // 
            this.buttonGreen.AutoSize = true;
            this.buttonGreen.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreen.Location = new System.Drawing.Point(189, 7);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(62, 21);
            this.buttonGreen.TabIndex = 6;
            this.buttonGreen.Text = "Green";
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.CheckedChanged += new System.EventHandler(this.buttonGreen_CheckedChanged);
            // 
            // buttonGrey
            // 
            this.buttonGrey.AutoSize = true;
            this.buttonGrey.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrey.Location = new System.Drawing.Point(98, 54);
            this.buttonGrey.Name = "buttonGrey";
            this.buttonGrey.Size = new System.Drawing.Size(53, 21);
            this.buttonGrey.TabIndex = 5;
            this.buttonGrey.Text = "Grey";
            this.buttonGrey.UseVisualStyleBackColor = true;
            this.buttonGrey.CheckedChanged += new System.EventHandler(this.buttonGrey_CheckedChanged);
            // 
            // buttonWhite
            // 
            this.buttonWhite.AutoSize = true;
            this.buttonWhite.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhite.Location = new System.Drawing.Point(98, 31);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(61, 21);
            this.buttonWhite.TabIndex = 4;
            this.buttonWhite.Text = "White";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.CheckedChanged += new System.EventHandler(this.buttonWhite_CheckedChanged);
            // 
            // buttonOrange
            // 
            this.buttonOrange.AutoSize = true;
            this.buttonOrange.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrange.Location = new System.Drawing.Point(98, 7);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(69, 21);
            this.buttonOrange.TabIndex = 3;
            this.buttonOrange.Text = "Orange";
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.CheckedChanged += new System.EventHandler(this.buttonOrange_CheckedChanged);
            // 
            // buttonBlue
            // 
            this.buttonBlue.AutoSize = true;
            this.buttonBlue.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlue.Location = new System.Drawing.Point(7, 54);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(52, 21);
            this.buttonBlue.TabIndex = 2;
            this.buttonBlue.Text = "Blue";
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.CheckedChanged += new System.EventHandler(this.buttonBlue_CheckedChanged);
            // 
            // buttonRed
            // 
            this.buttonRed.AutoSize = true;
            this.buttonRed.BackColor = System.Drawing.Color.Transparent;
            this.buttonRed.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRed.ImageKey = "(none)";
            this.buttonRed.Location = new System.Drawing.Point(7, 31);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(50, 21);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.Text = "Red";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.CheckedChanged += new System.EventHandler(this.buttonRed_CheckedChanged);
            // 
            // buttonBlack
            // 
            this.buttonBlack.AutoSize = true;
            this.buttonBlack.Checked = true;
            this.buttonBlack.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlack.Location = new System.Drawing.Point(7, 7);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(58, 21);
            this.buttonBlack.TabIndex = 0;
            this.buttonBlack.TabStop = true;
            this.buttonBlack.Text = "Black";
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.CheckedChanged += new System.EventHandler(this.buttonBlack_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 82);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Figure";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TheBestPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}

