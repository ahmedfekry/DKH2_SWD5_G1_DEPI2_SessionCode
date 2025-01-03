using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.L
{
    internal class Square : IShape
    {
        public int Width { get; set; }
        public string Draw()
        {
            return "Drawing a square => " + this.Width * this.Width;
        }

        public void SetHeight(int height)
        {
            this.SetWith(height);
        }

        public void SetWith(int width)
        {
            this.Width = width;
        }


    }
}
