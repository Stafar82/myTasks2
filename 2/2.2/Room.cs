using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56
{
    public class Room
    {
        public string Icon { get; set; }

        public Room(string icon = " ")
        {
            Icon = icon; 
        }
        public string GetRoom()
        {
            return $"[{Icon}]";
        }


    }
}
