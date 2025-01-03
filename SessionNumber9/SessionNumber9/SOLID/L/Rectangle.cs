using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.L
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {

        }

        public void SetWith(int width)
        {
            this.Width = width;
        }
        public void SetHeight(int height)
        {
            this.Height = height;
        }

        public string Draw()
        {
            return "Drawing a rectangle => "+ this.Width * this.Height;
        }
    }
}