using CS_Server_Viewer.Models;
using Newtonsoft.Json.Linq;

namespace CS_Server_Viewer.Components
{
    public class ServerGetter
    {
        public ServerGetter()
        {
               
        }

        public async Task<List<ServerModel>> GetServers() 
        {
            var json = await GetServersJson();

            List<ServerModel> servers = new List<ServerModel>();

            if (json.Length > 0)
            {
                JObject obj = JObject.Parse(json);

                int id = 1;

                var serverProperties = obj["pops"];

                foreach (var item in serverProperties)
                {
                    var relays = item.Children()["relays"].FirstOrDefault();

                    if (relays != null && relays.HasValues)
                    {
                        ServerModel server = new ServerModel();
                        server.Id = id;
                        server.Desc = item.Children()["desc"].FirstOrDefault().ToString();
                        server.GeoCoordinates.Longitude = (double)item.Children()["geo"].FirstOrDefault()[0];
                        server.GeoCoordinates.Latitude = (double)item.Children()["geo"].FirstOrDefault()[1];

                        foreach (var relay in relays)
                        {
                            Relay rel = new Relay
                            {
                                ipv4 = relay.Value<string>("ipv4")
                            };

                            var port_range = relay.SelectToken("port_range");

                            foreach (var port in port_range)
                            {
                                rel.PortRange.Add(port.ToString());
                            }

                            server.Relays.Add(rel);
                        }
                        servers.Add(server);
                        id++;
                    }
                }
            }

            if (servers.Any())
            {
                RegionHelper rh = new RegionHelper();

                foreach (var server in servers)
                {
                    server.Region = await rh.TranslateGeoToRegion(server.GeoCoordinates);
                }

            }

            return servers;
        }


        private async Task<string?> GetServersJson() 
        {
            string result = string.Empty;

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromSeconds(10);
                    result = await httpClient.GetStringAsync("https://api.steampowered.com/ISteamApps/GetSDRConfig/v1/?appid=730");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
