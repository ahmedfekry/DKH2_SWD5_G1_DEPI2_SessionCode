using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Startegy.Database
{
    internal class DatabaseConnector
    {
        private IDatabaseStrategy _databaseStrategy;

        public DatabaseConnector(IDatabaseStrategy databaseStrategy)
        {
            _databaseStrategy = databaseStrategy;
        }

        public void Connect()
        {
            _databaseStrategy.Connect();
        }

        public void Disconnect()
        {
            _databaseStrategy.Disconnect();
        }
    }
}
