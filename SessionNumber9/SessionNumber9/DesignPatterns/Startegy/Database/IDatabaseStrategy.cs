using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Startegy.Database
{
    internal interface IDatabaseStrategy
    {
        void Connect();
        void Disconnect();
    }
}
