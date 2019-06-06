using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HttpServer
{
    // State object for reading client data asynchronously  
    public class Program
    {

        public static int Main(String[] args)
        {
            AsynchronousSocketListener.StartListening();
            return 0;
        }
    }
}