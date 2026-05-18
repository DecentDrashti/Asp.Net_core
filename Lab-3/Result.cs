using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface Calculate
    {
        int Add(int x,
                int y);
    }
    internal class Result : Calculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}

