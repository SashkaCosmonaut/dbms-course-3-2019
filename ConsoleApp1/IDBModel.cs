using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IDBModel
    {
        string Name { get; }

        Room[] GetRooms();

        User[] GetUsers();

        void AddRoom(Room newRoom);

        void AddUser(User newUser);
    }
}
