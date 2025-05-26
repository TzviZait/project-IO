using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
     
    public static class GetString
    {
        public static string Get()
        {
            Console.WriteLine("enter a string:");
            string get = Console.ReadLine();
            return get;
        }
    }
    
}
