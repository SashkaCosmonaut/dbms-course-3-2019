using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class CollectionsModel : IDBModel
    {
        public string Name
        {
            get {
                return "Collection Database";
            }
        }

        protected List<Room> Rooms = new List<Room>
        {
            new Room { Name = "Комната из коллекции 1" },
            new Room { Name = "Комната из коллекции 2" },
            new Room { Name = "Комната из коллекции 3" }
        };

        protected List<User> Users = new List<User>
        {
            new User{ Login = "Иванов Иван", Password = "bbybyb" },
            new User{ Login = "Петров Пётр", Password = "qweqweqwe" }
        };

        public void AddRoom(Room newRoom)
        {
            Rooms.Add(newRoom);
        }

        public void AddUser(User newUser)
        {
            Users.Add(newUser);
        }

        public Room[] GetRooms()
        {
            return Rooms.ToArray();
        }

        public User[] GetUsers()
        {
            return Users.ToArray();
        }
    }
}
