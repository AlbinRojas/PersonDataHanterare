
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataHanterare.Data
{
    public struct Birth
    {
        public List<int> Year;
        public List<int> Month;
        public List<int> Day;

        public Birth()
        {
            Year = new List<int>();
            Month = new List<int>();
            Day = new List<int>();
        }

    }
}
