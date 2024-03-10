using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerPOS
{
    public class DataContainer
    {
        public List<string> table {  get; set; }
        public List<int> price { get; set; }
        public List<string> menu {  get; set; }
        public DataContainer()
        { 
            table = new List<string>();
            price = new List<int>();
            menu = new List<string>();
        }
    }
}
