using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class Board
    {
        public string name { get; set; }
        public string level { get; set; }
        public string time { get; set; }
        public string progress { get; set; }

        public Board(string Name, string Level, string Time, string Progress)
        {
            Name = name;
            Level = Level;
            Time = Time;
            Progress = Progress;
        }
    }

    
}
