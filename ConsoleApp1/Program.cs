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
            var dbs = new IDBModel[]
            {
                new JSONModel(),
                new CollectionsModel()
            };

            PrintDBs(dbs);

            foreach (var db in dbs)
                db.AddRoom(new Room
                {
                    Name = "NEW ROOM TO ADD QWEQWEQWE"
                });
            
            foreach (var db in dbs)
                db.AddUser(new User
                {
                    Login = "Nikolay",
                    Password = "ZXCZXCZXCZXC"
                });

            Console.WriteLine();

            PrintDBs(dbs);
        }

        public static void PrintDBs(IDBModel[] dbs)
        {
            foreach (var db in dbs)
            {
                Console.WriteLine(db.Name);

                Console.WriteLine("ROOMS:");

                foreach (var room in db.GetRooms())
                {
                    Console.WriteLine(room.Name);
                }

                Console.WriteLine("USERS:");

                foreach (var user in db.GetUsers())
                {
                    Console.WriteLine(user.Login + ": " + user.Password);
                }
            }
        }
    }
}
