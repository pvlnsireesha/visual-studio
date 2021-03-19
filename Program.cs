using System;
using System.Collections.Generic;

namespace GenericApp
{
   public class SampleClass
    {

        public void Gmethod<T>(T a, T b)
        {
            Console.WriteLine("param 1:{0}", a);
            Console.WriteLine("param 2:{0}", b);
        }
    }
        class program
        { 
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("generics method example");

            SampleClass s = new SampleClass();
            s.Gmethod<int>(1, 2);
            s.Gmethod("sujatha", "kerala");
            s.Gmethod("oops", "subject");
            Console.ReadLine();
        }
    }
}