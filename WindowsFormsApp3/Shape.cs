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
    public  class Shape :ICloneable
    {
        public Color shapecolor,pencolor;
        public int size;
        public int x;
        public int y;
        public string name;
        public Point startPosition { get; set; }
        public int width { get; set; }
        public int heigth { get; set; }
        //public Point currentPosition { get; set; }
        public Point currentPosition = new Point();
        public bool isFalled = false;
        public  Point[] arr = new Point[3];
        public Point[] LongArr = new Point[5];

        public Shape()
        {

        }
        public Shape(Point start, Point next, Color color, int fontsize,Point[] FreeArr)
        {
            startPosition = start;
            currentPosition = next;
            width = Math.Abs(currentPosition.X - startPosition.X);
            heigth = Math.Abs(currentPosition.Y - startPosition.Y);
            pencolor = color;
            size = fontsize;
            LongArr = FreeArr;
         
        
    }
        public virtual Rectangle getRectangle()

        {

            return new Rectangle(
                Math.Min(currentPosition.X, startPosition.X),
                Math.Min(currentPosition.Y, startPosition.Y), width, heigth);
        }
      
       public  Point[] triangle()
        {
            arr[0] = startPosition;
            arr[1] = currentPosition;
            width = Math.Abs(arr[0].X - arr[1].X);
            if (arr[0].X > arr[1].X) arr[2].X = arr[0].X + width;
            else arr[2].X = arr[0].X - width;
            arr[2].Y = arr[1].Y;
            return arr;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
    }

}
