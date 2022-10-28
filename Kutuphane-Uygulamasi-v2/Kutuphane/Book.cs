using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Book
    {
        public string ISSN;

        public string Name;

        public string Author;
        
        public override string ToString()
        {
            return Name + " (" + Author + ")";
        }
    }
}
