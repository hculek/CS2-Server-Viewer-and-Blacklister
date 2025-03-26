using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CS_Server_Viewer.Models
{
    public class RegionModel
    {
        public List<(double latitude, double longitude)> Polygon { get; set; } = new List<(double latitude, double longitude)>();
        public Regions Region { get; set; }

        public RegionModel()
        {
               
        }

        /// <summary>
        /// Use GeoCordinates_Translate.xlsx in Documentation folder to format GeoCoordinates
        /// </summary>
        /// <returns></returns>
        public List<RegionModel> GetRegionsModel()
        {
            List<RegionModel> regions = new List<RegionModel>();

            #region Europe
            regions.Add(new RegionModel {
                Region = Regions.Europe,
                Polygon = new List<(double latitude, double longitude)>
                {
                    (36.1023764,-18.984375),
                    (35.1738083,35.3320313),
                    (75.9308854,45.8789063),
                    (67.2040323,-24.7851563)
                }

            });
            #endregion

            #region North America
            regions.Add(new RegionModel {
                
                Region = Regions.NorthAmerica,
                Polygon = new List<(double latitude, double longitude)>
                {
                    (75.6721974,-166.2890625),
                    (34.8859309,-167.3437500),
                    (5.4410223,-91.0546875),
                    (17.9787331,-59.4140625),
                    (77.1571625,-9.1406250)
                }
            });
            #endregion

            #region South America
            regions.Add(new RegionModel
            {
                Region = Regions.SouthAmerica,
                Polygon = new List<(double latitude, double longitude)>
                {
                    (-50.9584267,-26.0156250),
                    (-61.4387675,-92.1093750),
                    (5.4410223,-91.0546875),
                    (17.9787331,-59.4140625),
                    (-10.1419317,-26.3671875),
                }
            });
            #endregion

            #region Asia
            regions.Add(new RegionModel
            {
                Region = Regions.Asia,
                Polygon = new List<(double latitude, double longitude)>
                {
                    (33.1375512,25.6640625),
                    (76.8807746,49.5703125),
                    (78.5604883,152.5781250),
                    (68.7841438,191.2500000),
                    (9.6224141,143.9648438),
                    (4.9158328,76.4648438),
                    (12.7260843,49.0429688),
                    (12.0393206,43.5937500),
                    (32.1384087,31.0693359)
                }
            });
            #endregion

            #region Australia
            regions.Add(new RegionModel
            {
                Region = Regions.Australia,
                Polygon = new List<(double latitude, double longitude)>
                {
                    (0.8788718,84.5507813),
                    (18.4796091,134.4726563),
                    (-23.0797318,187.9101563),
                    (-53.7487108,179.6484375),
                    (-36.1733569,113.0273438)
                }
            });
            #endregion

            #region Africa
            regions.Add(new RegionModel
            {
                Region = Regions.Africa,
                Polygon = new List<(double latitude, double longitude)>
                {
                    (35.1019341,-10.1953125),
                    (37.7185903,10.9863281),
                    (33.1375512,19.7753906),
                    (31.9521622,31.8164063),
                    (18.6462451,39.2871094),
                    (11.0059045,44.6484375),
                    (13.6673383,55.1953125),
                    (-39.6395376,51.2402344),
                    (-36.0313318,13.2714844),
                    (16.6361919,-27.6855469)
                }
            });
            #endregion

            return regions;
        }
    }
}
