using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbs = new List<IDBModel>
            {
                new JSONModel(),
                new CollectionsModel(),
                new CSVModel()
            };

            var newRoom = new Room
            {
                Name = "NEW ROOM TO ADD"
            };

            foreach (var db in dbs)
            {
                db.AddRoom(newRoom);
            }

            foreach (var db in dbs)
            {
                Console.WriteLine(db.Name);

                foreach (var room in db.GetRooms())
                {
                    Console.WriteLine(room.Name);
                }
            }
        }
    }
}
