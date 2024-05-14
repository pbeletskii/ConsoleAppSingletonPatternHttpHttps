using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Servers
    {
        static Lazy<Servers> servers = new();
        public static List<string> listServer = new();
        public static Servers Istance
        {
            get
            {
                return servers.Value;
            }
        }

        public bool Add(string server)
        {
            if (server.StartsWith("http") || server.StartsWith("https"))
            {
                listServer.Add(server);
                return true;
            }
            return false;
        }
        public List<string> GetServer(string parameter)
        {
            switch (parameter.ToLower())
            {
                case "http":
                    return GetServers(0);
                case "https":
                    return GetServers(1);
                default: return listServer;
            }
        }
        protected List<string> GetServers(int parameter)
        {
            List<string> list = new();
            foreach (var server in listServer)
            {
                if (parameter == 0 && server.ToString().Substring(0,5) != "https") list.Add(server);
                if (parameter == 1 && server.ToString().Substring(0, 5) == "https") list.Add(server);
            }
            return list;
        }
        public List<string> GetServer()
        {
            return listServer;
        }

    }
}
