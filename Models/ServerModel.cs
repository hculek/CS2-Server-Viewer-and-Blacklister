using System.ComponentModel.DataAnnotations;

namespace CS_Server_Viewer.Models
{
    public class ServerModel
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public GeographicCoordinates GeoCoordinates { get; set; } = new GeographicCoordinates();
        public RegionsEnum Region { get; set; } = RegionsEnum.World; //fallback if region not recognized
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



    public enum RegionsEnum 
    {
        [Display(Name = "World")]
        World = 0,
        [Display(Name = "Europe")]
        Europe = 1,
        [Display(Name = "North America")]
        NorthAmerica = 2,
        [Display(Name = "South America")]
        SouthAmerica = 3,
        [Display(Name = "Asia")]
        Asia = 4,
        [Display(Name = "Australia")]
        Australia = 5,
        [Display(Name = "Africa")]
        Africa = 6
    }
}
