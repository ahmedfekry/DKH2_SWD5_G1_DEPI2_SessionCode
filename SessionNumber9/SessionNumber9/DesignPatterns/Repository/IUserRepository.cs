using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber9.DesignPatterns.Repository
{
    internal interface IUserRepository
    {
        public void AddUser(User user);
        public void RemoveUser(User user);
        public User GetUser(int id);
    }
}
