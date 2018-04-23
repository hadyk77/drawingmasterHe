using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Stack<Shape> stack = new Stack<Shape>();

        Bitmap b;
        Color fontcolor = Color.Black;
        Point currentpoint = new Point();
        Point nextposition = new Point();
        string mode;
        Graphics g, gr;
        Pen p = new Pen(Color.Black, 1);
        int i = 0;
        Dictionary<string, Shape> dic = new Dictionary<string, Shape>();
        Point[] array = new Point[3];
        Point[] LongArray = new Point[5];
        List<Point> Longer = new List<Point>();
       public List<Point> freeshapelist = new List<Point>();
        public int freeshape_points_number;
        string choise;


        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(drawingpicbox.Width, drawingpicbox.Height);

            g = Graphics.FromImage(b);
            drawingpicbox.BackgroundImage = b;
            drawingpicbox.BackgroundImageLayout = ImageLayout.None;
            gr = drawingpicbox.CreateGraphics();
           

        }

        private void fileToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;
        }


        private void fileToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {

            form2 fr = new form2(this);
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                if (BackColor == Color.FromArgb(40, 40, 40))
                {
                    MaximizeButton.BackgroundImage = Properties.Resources.MaxDark;
                }
                else
                    MaximizeButton.BackgroundImage = Properties.Resources.min2;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                if (BackColor == Color.FromArgb(40, 40, 40))
                    MaximizeButton.BackgroundImage = Properties.Resources.minDark;
                else
                    MaximizeButton.BackgroundImage = Properties.Resources.max1;

            }

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            if (BackColor == Color.FromArgb(40, 40, 40))
                closeButton.BackColor = Color.FromArgb(40, 40, 40);
            else
                closeButton.BackColor = Color.FromArgb(238, 238, 242);

        }

        private void pERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 fr = new form2(this);
            fr.Show();

        }



        private void minimizebutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

            currentpoint = e.Location;
            //if (mode == "FreeShape")
            //{
            //    if (FreeShapePol>=0)
            //        LongArray[FreeShapePol-1] = currentpoint;
            //    if (FreeShapePol == 0)
            //        g.DrawPolygon(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), LongArray);

            //}
            //if (mode == "FreeShape")//LongArray[x] = currentpoint;
            //{
            //    Point _newPoint = currentpoint;
            //    Longer.Add(_newPoint);
            //}
            if (mode == "FreeShape")
            {
                g.FillEllipse(new SolidBrush(button12.BackColor), currentpoint.X, currentpoint.Y, 10, 10);
                freeshapelist.Add(currentpoint);
                drawingpicbox.Invalidate();
            }





        }

        private void drawingpicbox_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {

                if (mode == "HandDrawing")
                {
                    nextposition = e.Location;
                    g.DrawLine(p, currentpoint, nextposition);
                    currentpoint = nextposition;
                    drawingpicbox.Refresh();
                    currentpoint = e.Location;
                }
                else if (mode == "Eraser")
                {
                    nextposition = e.Location;
                    g.DrawLine(p, currentpoint, nextposition);
                    currentpoint = nextposition;
                    currentpoint = e.Location;
                    drawingpicbox.Invalidate();
                }
                else
                    nextposition = e.Location;
                drawingpicbox.Refresh();

            }
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mode = "HandDrawing";
            p.Color = button12.BackColor;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mode = "Eraser";
            p.Color = Color.White;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button12.BackColor = colorDialog1.Color;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = float.Parse((numericUpDown1.Value).ToString());
        }

        public void rectanglebutton_MouseDown(object sender, MouseEventArgs e)
        {

            mode = "Rectangle";
        }

        private void drawingpicbox_Paint(object sender, PaintEventArgs e)
        {
            if (dic.Count > 0)
            {
                redraw(e);
            }
            if (checkBox1.Checked)
            {
                drawfill(e);
                

            }
            else
            {
                if (mode == "Circle")
                {
                    e.Graphics.DrawEllipse(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), getRectangle());
                }
                else if (mode == "Rectangle")
                    e.Graphics.DrawRectangle(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), getRectangle());
                else if (mode == "Line")

                    e.Graphics.DrawLine(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), currentpoint, nextposition);
                else if (mode == "Triangle")
                {
                    triangle();
                    e.Graphics.DrawPolygon(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), array);
                }
                else if (mode == "FreeShape")
                {
                    if (freeshapelist.Count==freeshape_points_number)
                    {
                        if (choise == "1")
                        {

                            e.Graphics.DrawPolygon(new Pen(button12.BackColor, Convert.ToInt32(numericUpDown1.Value)), freeshapelist.ToArray());
                        }
                        else  if(choise=="2")
                        {
                            e.Graphics.DrawClosedCurve(new Pen(button12.BackColor, Convert.ToInt32(numericUpDown1.Value)), freeshapelist.ToArray());
                        }
                        foreach (Point item in freeshapelist)
                        {
                            g.FillEllipse(new SolidBrush(drawingpicbox.BackColor), item.X, item.Y, 10, 10);
                           
                        }
                         
                        Shape sh = new Shape(currentpoint, nextposition, button12.BackColor, Convert.ToInt32(numericUpDown1.Value), freeshapelist.ToArray());
                        objectname(sh);
                        mode = "";
                        minimizebutton.Focus();
                        drawingpicbox.Invalidate();
                      
                    }

                    
                }
                //{
                //    //       e.Graphics.DrawLine(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), currentpoint, nextposition);

                //    if (x == 4)
                //    {
                //        e.Graphics.DrawPolygon(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), Longer.ToArray());


                //    }
                //    else
                //        e.Graphics.DrawLine(new Pen(colorDialog1.Color, (int)numericUpDown1.Value), currentpoint, nextposition);

                //}
            }
          
        }


        private void drawingpicbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (mode == "FreeShape")
                return;
            else
            {
                //if (mode == "FreeShape" && x != 4)
                //{
                //    x++;
                //    return;
                //}
                //{
                Shape sh = new Shape(currentpoint, nextposition, colorDialog1.Color, Convert.ToInt32(numericUpDown1.Value), Longer.ToArray());
                if (checkBox1.Checked)
                {
                    sh.shapecolor = colorDialog1.Color;
                    sh.isFalled = true;

                }
                objectname(sh);

                //    x = 0;
                //    Longer.Clear();
                //}
                //x++;
                if (checkBox1.Checked)
                    checkBox1.CheckState = CheckState.Unchecked;
                //if (mode == "FreeShape")
                //{
                //    FreeShapePol--;
                //}
            }
        }


        
        private void FreeShapeGenerator()
        {

            //  LongArray[FreeShapePol - Loops] = currentpoint;


        }

        private void circlebutton_Click(object sender, EventArgs e)
        {
            mode = "Circle";
        }

        private void Layers_Click(object sender, EventArgs e)
        {
            if (Layers.SelectedItem != null)
            {
                if (mode == "Delete")
                {
                    delete();
                    Refresh();
                }
                else if (mode == "Fillcolor")
                {
                    fillshape();
                }
            }
        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            mode = "Delete";

        }

        private void trianglebutton_Click(object sender, EventArgs e)
        {
            mode = "Triangle";

        }

        private void linebutton_Click(object sender, EventArgs e)
        {
            mode = "Line";
        }
   
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog save = new SaveFileDialog();
            //save.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|All files (*.*)|*.*";
            //save.FilterIndex = 2;
            //save.RestoreDirectory = true;
            //save.OverwritePrompt = true;
            //save.ShowHelp = true;
            //save.AddExtension = true;
            //if (save.ShowDialog() == DialogResult.OK)
            //{

            //        drawingpicbox.Image.Save(@"D:\\temp.png", System.Drawing.Imaging.ImageFormat.Png);

            //}
            //using (SaveFileDialog sfdlg = new SaveFileDialog())
            //{
            //    sfdlg.Title = "Save Dialog";
            //    sfdlg.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
            //    if (sfdlg.ShowDialog(this) == DialogResult.OK)
            //    {
            //        using (Bitmap bmp = new Bitmap(drawingpicbox.Width, drawingpicbox.Height))
            //        {
            //            drawingpicbox.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //            drawingpicbox.Image = new Bitmap(drawingpicbox.Width, drawingpicbox.Height);
            //            drawingpicbox.Image.Save("c://cc.Jpg");
            //            bmp.Save(sfdlg.FileName);
            //            MessageBox.Show("Saved Successfully.....");

            //        }
            //    }
            //} ديه شغاله يا هادي بس فيها مشكله .. ابقى بص عليها 
           
            save();

        }
        private void fillcolorbutton_Click(object sender, EventArgs e)
        {
            mode = "Fillcolor";
        }
        private void pastbutton_Click(object sender, EventArgs e)
        {
            past();
        }

        private void copybutton_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void strokebutton_Click(object sender, EventArgs e)
        {

        }

        private void freeshapebutton_Click(object sender, EventArgs e)
        {
            choise = Interaction.InputBox("choose 1 for straight shape 2 to curve shape", "shape type");
            freeshape_points_number =int.Parse( Interaction.InputBox("Enter the number of shape points", "point number"));
            
            mode = "FreeShape";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog2.Color;

            }
           
            drawingpicbox.BackColor = colorDialog2.Color;
           
           
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bit = new Bitmap(open.FileName);
                    drawingpicbox.Image = bit;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Layers.SetSelected(Layers.Items.Count - 1, true);
            copybutton_Click(sender, e);
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undo();
            Layers_Click(sender, e);
            
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redo(stack.Last());
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers ==Keys.Control&&e.KeyCode==Keys.Z)
            {
                undo();
                delete();
                Refresh();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                save();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                Layers.SetSelected(Layers.Items.Count - 1, true);
                copy();
            }
            if (e.KeyCode==Keys.Delete)
            {
                Layers.SetSelected(Layers.Items.Count - 1, true);
                EventArgs ee = new EventArgs();
                Deletebutton_Click(sender, ee);
                Layers_Click(sender, ee);
            }
        }
        //METHODS
        private Rectangle getRectangle()
        {

            return new Rectangle(
                Math.Min(currentpoint.X, nextposition.X),
                Math.Min(currentpoint.Y, nextposition.Y),
                Math.Abs(currentpoint.X - nextposition.X),
                Math.Abs(currentpoint.Y - nextposition.Y));

        }
        public void delete()
        {
            if (dic[Layers.SelectedItem.ToString()].name.Contains("Redoo"))
            {
                g.FillRectangle(new SolidBrush(drawingpicbox.BackColor), dic[Layers.SelectedItem.ToString()].startPosition.X, dic[Layers.SelectedItem.ToString()].startPosition.Y, dic[Layers.SelectedItem.ToString()].width + 10, dic[Layers.SelectedItem.ToString()].heigth + 10);
                drawingpicbox.Invalidate();
            }


            dic.Remove((Layers.SelectedItem).ToString());
            Layers.Items.Remove(Layers.SelectedItem);

        }

        public void objectname(Shape sh)
        {




            if (mode != null)
            {
                if (mode.Contains("Rectangle") || mode.Contains("Circle") || mode.Contains("Triangle")||mode.Contains("FreeShape"))
                {

                    sh.name = mode + i;
                    Layers.Items.Add(sh.name);
                    dic.Add(sh.name, sh);
                    i++;
                }
            }
        }

        public void triangle()
        {
            array[0] = currentpoint;
            array[1] = nextposition;
            int w = Math.Abs(array[0].X - array[1].X);
            if (currentpoint.X > nextposition.X) array[2].X = currentpoint.X + w;
            else array[2].X = currentpoint.X - w;
            array[2].Y = nextposition.Y;



        }
        public void drawfill(PaintEventArgs e)
        {
            if (mode == "Circle")
            {
                e.Graphics.FillEllipse(new SolidBrush(colorDialog1.Color), getRectangle());

            }
            else if (mode == "Rectangle")
                e.Graphics.FillRectangle(new SolidBrush(colorDialog1.Color), getRectangle());

            else if (mode == "Triangle")
            {
                triangle();
                e.Graphics.FillPolygon(new SolidBrush(colorDialog1.Color), array);
            }

        }
        public void redraw(PaintEventArgs e)
        {

            foreach (KeyValuePair<string, Shape> item in dic)
            {
                if (item.Key.Contains("Triangle"))
                {
                    if (item.Value.isFalled)
                        e.Graphics.FillPolygon(new SolidBrush(item.Value.shapecolor), item.Value.triangle());

                    else
                        e.Graphics.DrawPolygon(new Pen(item.Value.pencolor, item.Value.size), item.Value.triangle());

                }
                if (item.Key.Contains("Circle"))
                {
                    if (item.Value.isFalled) { e.Graphics.FillEllipse(new SolidBrush(item.Value.shapecolor), item.Value.getRectangle()); }
                    else
                        e.Graphics.DrawEllipse(new Pen(item.Value.pencolor, item.Value.size), item.Value.getRectangle());
                }
                else if (item.Key.Contains("Rectangle"))
                {

                    if (item.Value.isFalled)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(item.Value.shapecolor), item.Value.getRectangle());

                    }
                    else
                        e.Graphics.DrawRectangle(new Pen(item.Value.pencolor, item.Value.size), item.Value.getRectangle());
                }
                else if (item.Key.Contains("Line"))
                {
                    e.Graphics.DrawLine(new Pen(item.Value.pencolor, item.Value.size), item.Value.startPosition, item.Value.currentPosition);
                }
                else if (item.Key.Contains("FreeShape"))
                {
                    if (choise == "1")
                    {
                        if (item.Value.isFalled)
                            e.Graphics.FillPolygon(new SolidBrush(item.Value.shapecolor), item.Value.LongArr);
                        else
                            e.Graphics.DrawPolygon(new Pen(item.Value.pencolor, item.Value.size), item.Value.LongArr);
                    }
                    else if(choise=="2")
                    {
                        if (item.Value.isFalled)
                            e.Graphics.FillClosedCurve(new SolidBrush(item.Value.shapecolor), item.Value.LongArr);
                        else
                            e.Graphics.DrawClosedCurve(new Pen(item.Value.pencolor, item.Value.size), item.Value.LongArr);
                    }
                }
            }

        }
        public void fillshape()
        {
            if (Layers.SelectedItem.ToString().Contains("Circle"))
            {
                g.FillEllipse(new SolidBrush(colorDialog1.Color), currentpoint.X, currentpoint.Y, dic[Layers.SelectedItem.ToString()].width, dic[Layers.SelectedItem.ToString()].heigth);

            }
            else if (Layers.SelectedItem.ToString().Contains("Rectangle"))
                g.FillRectangle(new SolidBrush(colorDialog1.Color), currentpoint.X, currentpoint.Y, dic[Layers.SelectedItem.ToString()].width, dic[Layers.SelectedItem.ToString()].heigth);

            else if (mode == "Triangle")
            {
                triangle();
                g.FillPolygon(new SolidBrush(colorDialog1.Color), array);
            }
            drawingpicbox.Invalidate();
            dic[Layers.SelectedItem.ToString()].shapecolor = colorDialog1.Color;
            dic[Layers.SelectedItem.ToString()].isFalled = true;
        }
        public void SaveV2(string path)
        {
            using (var bitmap = new Bitmap(drawingpicbox.Width, drawingpicbox.Height))
            {
                drawingpicbox.DrawToBitmap(bitmap, drawingpicbox.ClientRectangle);
                ImageFormat imageFormat = null;

                var extension = Path.GetExtension(path);
                switch (extension)
                {
                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                    case ".jpeg":
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".gif":
                        imageFormat = ImageFormat.Gif;
                        break;
                    default:
                        throw new NotSupportedException("File extension is not supported");
                }

                bitmap.Save(path, imageFormat);
            }
        }
        public void redo(Shape sha)
        {

            Shape sh = sha;
            sh.name += "Redoo";
            mode = sh.name;
            if (sh.name.Contains("Rectangle"))
            {
                if (sh.isFalled)
                    g.FillRectangle(new SolidBrush(sh.shapecolor), sh.startPosition.X, sh.startPosition.Y, sh.width, sh.heigth);
                else
                    g.DrawRectangle(new Pen(sh.pencolor, sh.size), sh.startPosition.X, sh.startPosition.Y, sh.width, sh.heigth);
            }
            if (sh.name.Contains("Circle"))
            {
                if (sh.isFalled)
                   g.FillEllipse(new SolidBrush(sh.shapecolor), sh.startPosition.X, sh.startPosition.Y, sh.width, sh.heigth);
                else
                    g.DrawEllipse(new Pen(sh.pencolor, sh.size), sh.startPosition.X, sh.startPosition.Y, sh.width, sh.heigth);
            }
            if (sh.name.Contains("Triangle"))
            {
                if (sh.isFalled)
                    g.FillPolygon(new SolidBrush(sh.shapecolor),sh.arr);
                else
                    g.DrawPolygon(new Pen(sh.pencolor, sh.size), sh.arr);
            }
            if (sh.name.Contains("Line"))
            {                              
                    g.DrawLine(new Pen(sh.pencolor, sh.size), sh.startPosition, sh.currentPosition);
            }
            objectname(sh);
            drawingpicbox.Invalidate();
            closeButton.Focus();


        }
       public void save()
        {
            using (SaveFileDialog Test = new SaveFileDialog())
            {
                Test.Title = "Save";
                Test.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|All files (*.*)|*.*";
                if (Test.ShowDialog(this) == DialogResult.OK)
                {

                    SaveV2(Test.FileName);
                }
            }

        }
        public void copy()
        {
            if (Layers.SelectedItem == null)
            {
                toolTip1.Show("Please select the shape you wanna to copy", this, Cursor.Position, 2000);
                currentpoint.X = 0;
                currentpoint.Y = 0;
                return;
            }

            mode = "Copy";
            toolTip1.Show("COpied_" + dic[Layers.SelectedItem.ToString()].name + " !!", copybutton, 2000);
        }
        public void past()
        {
            Shape b = new Shape(dic[Layers.SelectedItem.ToString()].startPosition, dic[Layers.SelectedItem.ToString()].currentPosition, dic[Layers.SelectedItem.ToString()].pencolor, dic[Layers.SelectedItem.ToString()].size, LongArray);
            currentpoint.X = currentpoint.X - b.width / 2;
            currentpoint.Y = currentpoint.Y - b.heigth / 2;
            //  b.name = dic[Layers.SelectedItem.ToString()].name;
            if (dic[Layers.SelectedItem.ToString()].name.Contains("Circle"))
            {
                g.DrawEllipse(p, currentpoint.X, currentpoint.Y, b.width, b.heigth);
            }
            else if (dic[Layers.SelectedItem.ToString()].name.Contains("Rectangle"))
            {
                g.DrawRectangle(p, currentpoint.X, currentpoint.Y, b.width, b.heigth);
            }
            else if (dic[Layers.SelectedItem.ToString()].name.Contains("Triangle"))
            {

                array[0].X = currentpoint.X + b.width / 2;

                //              g.DrawPolygon(p,);
            }
            objectname(b);
            drawingpicbox.Refresh();
        }
        public void undo()
        {

            stack.Push(dic.Last().Value);
            Layers.SetSelected(Layers.Items.Count - 1, true);
            mode = "Delete";

        }
    }

}
    
