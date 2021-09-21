using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                string message = Console.ReadLine();
                if(message == "exit")
                {
                    break;
                }
                if(message == "")
                {
                    Console.WriteLine(new Message().HelloMessage);
                }
            }
        }
    }
}
