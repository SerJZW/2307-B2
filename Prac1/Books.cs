using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prac1
{
    public class Books
    {
        public int id {  get; set; }
        public string? title { get; set; }
        public override string ToString()
        {
            return $"{id}, {title}";
        }

    }
}
