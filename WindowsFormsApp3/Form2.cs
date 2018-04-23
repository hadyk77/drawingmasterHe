using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class form2 : Form
    {
        Form1 f;
        public bool isDark = false;
        public form2(Form1 form)
        {
            InitializeComponent();
            f = form;
        }

        private void form2_Load(object sender, EventArgs e)
        {
            if (f.BackColor == Color.FromArgb(238, 238, 242))
            {
                radioButton1.Select();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            f.BackColor = Color.FromArgb(40, 40, 40);
            f.menuStrip1.BackColor = Color.FromArgb(40, 40, 40);
            f.fileToolStripMenuItem.ForeColor = Color.Silver;
            f.fileToolStripMenuItem.BackColor= Color.FromArgb(40, 40, 40);
            f.editToolStripMenuItem.ForeColor = Color.Silver;
            f.editToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            f.Layers.BackColor = Color.FromArgb(40, 40, 40);
            f.circlebutton.BackgroundImage = Properties.Resources.ass1;
            f.trianglebutton.BackgroundImage = Properties.Resources.ass;
            f.rectanglebutton.BackgroundImage = Properties.Resources.Untitled_12;
            f.linebutton.BackgroundImage = Properties.Resources.Untitled_13;
            f.freeshapebutton.Image = Properties.Resources.Untitled_14;
            f.freeshapebutton.ForeColor = Color.Silver;
            f.Deletebutton.BackColor = Color.FromArgb(40, 40, 40);
            f.Deletebutton.ForeColor = Color.Silver;
            f.copybutton.BackColor = Color.FromArgb(40, 40, 40);
            f.copybutton.ForeColor = Color.Silver;
            f.pastbutton.BackColor = Color.FromArgb(40, 40, 40);
            f.pastbutton.ForeColor = Color.Silver;
   
            f.fillcolorbutton.BackColor = Color.FromArgb(40, 40, 40);
            f.fillcolorbutton.ForeColor = Color.Silver;
            f.MaximizeButton.BackgroundImage = Properties.Resources.min;
            f.closeButton.ForeColor = Color.White;
            f.minimizebutton.ForeColor = Color.White;
            f.Layers.ForeColor = Color.White;
            isDark = true;
            f.Layers.ForeColor = Color.Black;
            f.headline.ForeColor = Color.White;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            f.BackColor = Color.FromArgb(238,238,242);
            f.menuStrip1.BackColor = Color.FromArgb(238, 238, 242);
            f.fileToolStripMenuItem.ForeColor = Color.Black;
            f.fileToolStripMenuItem.BackColor = Color.FromArgb(238, 238, 242);
            f.editToolStripMenuItem.ForeColor = Color.Black;
            f.editToolStripMenuItem.BackColor = Color.FromArgb(238, 238, 242);
            f.Layers.BackColor = Color.FromArgb(238, 238, 242);
            f.circlebutton.BackgroundImage = Properties.Resources.circle;
            f.trianglebutton.BackgroundImage = Properties.Resources.triangel;
            f.rectanglebutton.BackgroundImage = Properties.Resources.square;
            f.linebutton.BackgroundImage = Properties.Resources.line;
            f.freeshapebutton.Image = Properties.Resources.free;
            f.freeshapebutton.ForeColor = Color.RoyalBlue;
            f.Deletebutton.BackColor = Color.FromArgb(238, 238, 242);
            f.Deletebutton.ForeColor = Color.DimGray;
            f.copybutton.BackColor = Color.FromArgb(238, 238, 242);
            f.copybutton.ForeColor = Color.DimGray;
            f.pastbutton.BackColor = Color.FromArgb(238, 238, 242);
            f.pastbutton.ForeColor = Color.DimGray;

            f.fillcolorbutton.BackColor = Color.FromArgb(238, 238, 242);
            f.fillcolorbutton.ForeColor = Color.DimGray;
            f.MaximizeButton.BackgroundImage = Properties.Resources.min1;
            f.closeButton.ForeColor = Color.DimGray;
            f.minimizebutton.ForeColor = Color.DimGray;
            f.closeButton.BackColor = Color.FromArgb(238, 238, 242);
            f.Layers.ForeColor = Color.White;
            isDark = false;
            f.headline.ForeColor = Color.Navy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

