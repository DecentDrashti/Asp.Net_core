
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program-1
            /*ArrayList A1 = new ArrayList();
            A1.Add("abc");
            A1.Add("def");
            A1.Add("bcf");
            Console.WriteLine(A1[0]);
            A1.Remove("def");
            A1.RemoveRange(1,1);//removerange(int index,int count)
            foreach(object o in A1) Console.WriteLine(o);*/

            //program-2
            /*List<string> list = new List<string>();
            list.Add("abc");
            list.Add("def");
            list.Add("ced");
            list.Add("tuv");
            list.Remove("tuv");
            list.RemoveRange(0, 1);
            foreach (object o in list) Console.WriteLine(o);*/

            //program-3
            /*Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Contains(1));
            foreach (object o in stack) Console.WriteLine(o);*/

            //program-4
            /*Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");
            queue.Enqueue("E");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains("A"));
            foreach (object o in queue) Console.WriteLine(o);*/

            //program-5
            /*Dictionary<string,string> kvp = new Dictionary<string, string>();
            kvp.Add("1.", "Abc");
            kvp.Add("2.", "cde");
            kvp.Add("3.", "def");
            kvp.Add("4.", "fgh");
            kvp.Add("5.", "ddg");
            foreach (object o in kvp) Console.WriteLine(o);
            kvp.Remove("5");
            kvp.ContainsKey("6");
            kvp.ContainsValue("3");
            foreach (object o in kvp) Console.WriteLine(o);*/

            //program-6
            Hashtable ht = new Hashtable();
            ht.Add("1", "Dras");
            ht.Add("2.", "kei");
            ht.Add("3.", "jhcd");
            ht.Add("4", "uhdlk");
            ht.Add("5", "hsjc");
            ht.Add("6", "jkkd");
            ht.Remove("1");
            ht.ContainsKey("2");
            ht.ContainsValue("Dras");
            foreach (var o in ht.Keys)
            {
                Console.WriteLine();
                Console.Write(o);
                Console.Write(ht[o]);
            }
            //or same as ppt





        }
    }
}
