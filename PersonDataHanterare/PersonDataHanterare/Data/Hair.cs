using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataHanterare.Data
{
    public struct Hair
    {
        public List<string> HairColor;
        public List<string> HairLength;

        public Hair()
        {
            HairColor = new List<string>();
            HairLength = new List<string>();
        }
    }
}