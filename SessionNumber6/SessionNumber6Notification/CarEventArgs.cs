using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber6Notification
{
    internal class CarEventArgs : EventArgs
    {
        public string Message { get; set; }
        public DateTime EventDateTime { get; set; }

        public CarEventArgs(string message, DateTime eventDateTime)
        {
            Message = message;
            EventDateTime = eventDateTime;
        }
    }
}
