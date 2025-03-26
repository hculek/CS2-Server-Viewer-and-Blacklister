using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public Regions Region { get; set; } = Regions.World;
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
        [Display(Name = "Not Found")]
        None = 0,
        [Display(Name = "World")]
        World = 1,
        [Display(Name = "Europe")]
        Europe = 2,
        [Display(Name = "North America")]
        NorthAmerica = 3,
        [Display(Name = "South America")]
        SouthAmerica = 4,
        [Display(Name = "Asia")]
        Asia = 5,
        [Display(Name = "Australia")]
        Australia = 6,
        [Display(Name = "Africa")]
        Africa = 7
    }
}
