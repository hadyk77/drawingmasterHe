namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headline = new System.Windows.Forms.Label();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.minimizebutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeButton = new System.Windows.Forms.Button();
            this.Layers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copybutton = new System.Windows.Forms.Button();
            this.pastbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fillcolorbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.drawingpicbox = new System.Windows.Forms.PictureBox();
            this.freeshapebutton = new System.Windows.Forms.Button();
            this.linebutton = new System.Windows.Forms.Button();
            this.rectanglebutton = new System.Windows.Forms.Button();
            this.circlebutton = new System.Windows.Forms.Button();
            this.trianglebutton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.headline);
            this.panel1.Controls.Add(this.MaximizeButton);
            this.panel1.Controls.Add(this.minimizebutton);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.closeButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // headline
            // 
            resources.ApplyResources(this.headline, "headline");
            this.headline.ForeColor = System.Drawing.Color.Navy;
            this.headline.Name = "headline";
            // 
            // MaximizeButton
            // 
            resources.ApplyResources(this.MaximizeButton, "MaximizeButton");
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // minimizebutton
            // 
            resources.ApplyResources(this.minimizebutton, "minimizebutton");
            this.minimizebutton.FlatAppearance.BorderSize = 0;
            this.minimizebutton.ForeColor = System.Drawing.Color.DimGray;
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.UseVisualStyleBackColor = true;
            this.minimizebutton.Click += new System.EventHandler(this.minimizebutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.pERToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // pERToolStripMenuItem
            // 
            this.pERToolStripMenuItem.Name = "pERToolStripMenuItem";
            resources.ApplyResources(this.pERToolStripMenuItem, "pERToolStripMenuItem");
            this.pERToolStripMenuItem.Click += new System.EventHandler(this.pERToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pastbutton_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.ForeColor = System.Drawing.Color.DimGray;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // Layers
            // 
            this.Layers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.Layers, "Layers");
            this.Layers.ForeColor = System.Drawing.Color.Black;
            this.Layers.FormattingEnabled = true;
            this.Layers.Name = "Layers";
            this.Layers.Click += new System.EventHandler(this.Layers_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // copybutton
            // 
            resources.ApplyResources(this.copybutton, "copybutton");
            this.copybutton.FlatAppearance.BorderSize = 0;
            this.copybutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copybutton.Name = "copybutton";
            this.copybutton.UseVisualStyleBackColor = true;
            this.copybutton.Click += new System.EventHandler(this.copybutton_Click);
            // 
            // pastbutton
            // 
            resources.ApplyResources(this.pastbutton, "pastbutton");
            this.pastbutton.FlatAppearance.BorderSize = 0;
            this.pastbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pastbutton.Name = "pastbutton";
            this.pastbutton.UseVisualStyleBackColor = true;
            this.pastbutton.Click += new System.EventHandler(this.pastbutton_Click);
            // 
            // Deletebutton
            // 
            resources.ApplyResources(this.Deletebutton, "Deletebutton");
            this.Deletebutton.FlatAppearance.BorderSize = 0;
            this.Deletebutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Name = "label3";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button12, "button12");
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fillcolorbutton
            // 
            resources.ApplyResources(this.fillcolorbutton, "fillcolorbutton");
            this.fillcolorbutton.FlatAppearance.BorderSize = 0;
            this.fillcolorbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fillcolorbutton.Name = "fillcolorbutton";
            this.fillcolorbutton.UseVisualStyleBackColor = true;
            this.fillcolorbutton.Click += new System.EventHandler(this.fillcolorbutton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Name = "label4";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // drawingpicbox
            // 
            resources.ApplyResources(this.drawingpicbox, "drawingpicbox");
            this.drawingpicbox.BackColor = System.Drawing.Color.White;
            this.drawingpicbox.Name = "drawingpicbox";
            this.drawingpicbox.TabStop = false;
            this.drawingpicbox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingpicbox_Paint);
            this.drawingpicbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.drawingpicbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingpicbox_MouseMove);
            this.drawingpicbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingpicbox_MouseUp);
            // 
            // freeshapebutton
            // 
            resources.ApplyResources(this.freeshapebutton, "freeshapebutton");
            this.freeshapebutton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.freeshapebutton.Name = "freeshapebutton";
            this.freeshapebutton.UseVisualStyleBackColor = true;
            this.freeshapebutton.Click += new System.EventHandler(this.freeshapebutton_Click);
            // 
            // linebutton
            // 
            resources.ApplyResources(this.linebutton, "linebutton");
            this.linebutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linebutton.Name = "linebutton";
            this.linebutton.UseVisualStyleBackColor = true;
            this.linebutton.Click += new System.EventHandler(this.linebutton_Click);
            // 
            // rectanglebutton
            // 
            resources.ApplyResources(this.rectanglebutton, "rectanglebutton");
            this.rectanglebutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rectanglebutton.Name = "rectanglebutton";
            this.rectanglebutton.UseVisualStyleBackColor = true;
            this.rectanglebutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectanglebutton_MouseDown);
            // 
            // circlebutton
            // 
            resources.ApplyResources(this.circlebutton, "circlebutton");
            this.circlebutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.circlebutton.Name = "circlebutton";
            this.circlebutton.UseVisualStyleBackColor = true;
            this.circlebutton.Click += new System.EventHandler(this.circlebutton_Click);
            // 
            // trianglebutton
            // 
            resources.ApplyResources(this.trianglebutton, "trianglebutton");
            this.trianglebutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trianglebutton.Name = "trianglebutton";
            this.trianglebutton.UseVisualStyleBackColor = true;
            this.trianglebutton.Click += new System.EventHandler(this.trianglebutton_Click);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "test";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.drawingpicbox);
            this.Controls.Add(this.fillcolorbutton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.pastbutton);
            this.Controls.Add(this.copybutton);
            this.Controls.Add(this.freeshapebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linebutton);
            this.Controls.Add(this.rectanglebutton);
            this.Controls.Add(this.circlebutton);
            this.Controls.Add(this.trianglebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Layers);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pERToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        public System.Windows.Forms.ListBox Layers;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button minimizebutton;
        public System.Windows.Forms.Button trianglebutton;
        public System.Windows.Forms.Button circlebutton;
        public System.Windows.Forms.Button rectanglebutton;
        public System.Windows.Forms.Button linebutton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button freeshapebutton;
        public System.Windows.Forms.Button copybutton;
        public System.Windows.Forms.Button pastbutton;
        public System.Windows.Forms.Button Deletebutton;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Button fillcolorbutton;
        public System.Windows.Forms.PictureBox drawingpicbox;
        public System.Windows.Forms.Button MaximizeButton;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label headline;
    }
}

