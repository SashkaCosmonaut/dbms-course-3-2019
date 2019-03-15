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
        class JSONFileModel
        {
            public Room[] Rooms { get; set; }
            public User[] Users { get; set; }
        }

        public string Name
        {
            get
            {
                return "JSON Database";
            }
        }

        public void AddRoom(Room newRoom)
        {
            var model = DeserializeModel();

            var rooms = model.Rooms.ToList();

            rooms.Add(newRoom);

            model.Rooms = rooms.ToArray();

            SerializeModel(model);
        }

        public void AddUser(User newUser)
        {
            var model = DeserializeModel();

            var users = model.Users.ToList();

            users.Add(newUser);

            model.Users = users.ToArray();

            SerializeModel(model);
        }

        public Room[] GetRooms()
        {
            var model = DeserializeModel();

            return model.Rooms;
        }

        public User[] GetUsers()
        {
            var model = DeserializeModel();

            return model.Users;
        }

        private JSONFileModel DeserializeModel()
        {
            using (var sr = new StreamReader("jsondb.json"))
            {
                return JsonConvert.DeserializeObject<JSONFileModel>(sr.ReadToEnd());
            }
        }

        private void SerializeModel(JSONFileModel model)
        {
            using (var sw = new StreamWriter("jsondb.json"))
            {
                sw.Write(JsonConvert.SerializeObject(model));
            }
        }
    }
}
