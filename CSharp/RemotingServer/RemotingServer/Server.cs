using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;


namespace RemotingServer
{
    public class RemoteObjectsServer
    {
        public RemoteObjectsServer() {  }
    }


    //service class
    public class Service : MarshalByRefObject
    {
        public string SayHello(string s)
        {
            return "Hello" + s;
        }

        public int HighestNumber(int n1, int n2)
        {
            int maxnumber = (Math.Max(n1, n2));
            Console.WriteLine("Remote Call Executed..");
            return maxnumber;
        }
    }
    //server class
    //it hosts the services by registering them
    class Server
    {
        static void Main(string[] args)
        {
            //create a new channel for communication
            HttpChannel c = new HttpChannel(85); //port number

            //register the channel
            ChannelServices.RegisterChannel(c);

            //configure all known services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "OurFirstRemoteService",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services started at Port No: 85...");
            Console.WriteLine("Press any Key to Stop the Server Services..");
            Console.ReadLine();
        }
    }
}
