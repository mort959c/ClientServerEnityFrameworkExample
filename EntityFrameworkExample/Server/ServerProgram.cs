using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerProgram
    {
        public static ServerCommunication serverCom = new ServerCommunication();
        static void Main(string[] args)
        {
            serverCom.ServerStartListening();
        }
    }
}
