using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataHanterare.Data
{
    public struct Name
    {
        public List<string> FirstName;
        public List<string> SurName;

        public Name()
        {
            FirstName = new List<string>();
            SurName = new List<string>();
        }

    }
}