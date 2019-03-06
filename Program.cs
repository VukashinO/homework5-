using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            // your code here
            Substrings(5);
            
        }

       static void Substrings(int n)
        {
            var source = "Hello from SEDC CodeCademy v7.0";
            // your code here (using Console.WriteLine)
            var newString = source.Substring(0, n);
            var newString2 = source.Substring(n);
            Console.WriteLine(newString);
            Console.WriteLine(newString2);
           
        }
       
    }
}