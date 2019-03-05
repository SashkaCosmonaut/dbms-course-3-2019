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
        protected List<Room> Rooms = new List<Room>
        {
            new Room { Name = "Комната из коллекции 1" },
            new Room { Name = "Комната из коллекции 2" },
            new Room { Name = "Комната из коллекции 3" }
        };

        protected List<User> Users = new List<User>();

        public string Name
        {
            get
            {
                return "Collection Database";
            }
        }

        public void AddRoom(Room newRoom)
        {
            Rooms.Add(newRoom);
        }

        public void AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public Room[] GetRooms()
        {
            return Rooms.ToArray();
        }

        public User[] GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
