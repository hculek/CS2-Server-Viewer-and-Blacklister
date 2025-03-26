using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Server_Viewer.Models
{
    public class ServerModel
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public GeographicCoordinates GeoCoordinates { get; set; } = new GeographicCoordinates();
        public Regions Region { get; set; } = Regions.World; //TODO
        public List<Relay> Relays { get; set; } = new List<Relay>();
        public bool Blacklisted { get; set; }


    }

    public class Relay 
    { 
        public string ipv4 { get; set; }
        public List<string> PortRange { get; set; } = new List<string>();
    }

    public class GeographicCoordinates
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }



    public enum Regions 
    { 
        None = 0,
        World = 1,
        Europe = 2,
        NorthAmerica = 3,
        SouthAmerica = 4,
        Asia = 5,
        Australia = 6,
        Africa = 7
    }
}
