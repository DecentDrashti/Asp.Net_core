using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        int Id;
        string Name;
        int Age;
        int Weight;
        double Height;

        public void GetCandidate(int i)
        {
            Console.WriteLine("the data of candidate" +i);
            Console.WriteLine("enter candidate id: ");
             Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the candidate Name: ");
            Name=Console.ReadLine();
            Console.WriteLine("enter the candidate Age: ");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the candidate weight: ");
            Weight=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the candidate height: ");
            Height=Convert.ToDouble(Console.ReadLine());
           
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Weight: "+Weight);
            Console.WriteLine("Height: "+Height);
        }
    }
}
