using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.SOLID.L
{
    internal interface IShape
    {
        string Draw();
        void SetWith(int width);
        void SetHeight(int height);
    }
}
