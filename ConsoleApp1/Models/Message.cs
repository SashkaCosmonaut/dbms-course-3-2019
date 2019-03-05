using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Message
    {
        public string Text { get; set; }

        public Room Room { get; set; }

        public User User { get; set; }
    }
}
