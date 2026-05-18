using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Furniture
    {
        string material;
        int price;

        public void fur()
        {
            Console.WriteLine("hello from furniture");
        }
       
    }
    public class Table:Furniture
    {
        int height;
        int surface_area;
        
        public void tabl()
        {
            Console.WriteLine("hello from table");
        }
    }
}
