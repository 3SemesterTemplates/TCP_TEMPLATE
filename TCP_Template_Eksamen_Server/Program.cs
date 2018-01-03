using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Template_Eksamen_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start();

            Console.ReadLine();
        }
    }
}
