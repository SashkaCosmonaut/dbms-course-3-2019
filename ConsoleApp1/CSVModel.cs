using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class CSVModel : IDBModel
    {
        public string Name => throw new NotImplementedException();

        public void AddRoom(Room newRoom)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public Room[] GetRooms()
        {
            throw new NotImplementedException();
        }

        public User[] GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
