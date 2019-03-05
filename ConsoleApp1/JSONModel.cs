using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class JSONModel : IDBModel
    {
        public string Name
        {
            get
            {
                return "JSON Database";
            }
        }

        public void AddRoom(Room newRoom)
        {
            var rooms = GetRooms().ToList();

            rooms.Add(newRoom);

            using (var sw = new StreamWriter("jsondb.json"))
            {
                sw.Write(JsonConvert.SerializeObject(rooms.ToArray()));
            }
        }

        public void AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public Room[] GetRooms()
        {
            using (var sr = new StreamReader("jsondb.json"))
            {
                return JsonConvert.DeserializeObject<Room[]>(sr.ReadToEnd());
            }
        }

        public User[] GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
