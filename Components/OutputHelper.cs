using CS_Server_Viewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Server_Viewer.Components
{
    public class OutputHelper
    {
        public OutputHelper()
        {
            
        }

        public async Task<(string, string)> GetBlacklist(string delimiter, List<ServerModel> servers) 
        {
            HashSet<string> ips = new HashSet<string>();
            HashSet<string> ports = new HashSet<string>();

            if (servers.Any()) { 
                foreach (var server in servers)
                {
                    if (server.Blacklisted == true)
                    {
                        foreach (var relay in server.Relays)
                        {
                            ips.Add(relay.ipv4);

                            foreach (var port in relay.PortRange)
                            {
                                ports.Add(port);
                            }
                        }
                    }
                }
            }

            StringBuilder ipResult = new StringBuilder();
            StringBuilder portsResult = new StringBuilder();

            if (ips.Any() && ports.Any())
            {

                ipResult.AppendJoin(delimiter, ips.ToArray());

                portsResult.AppendJoin(delimiter, ports.ToArray());
            }

            return (ipResult.ToString(), portsResult.ToString());
        }

    }
}
