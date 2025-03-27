using CS_Server_Viewer.Models;

namespace CS_Server_Viewer.Components
{
    public class RegionHelper
    {
        List<RegionModel> regions;
        public RegionHelper()
        {
            regions = new List<RegionModel>();

            RegionModel model = new RegionModel();

            regions = model.GetRegionsModel();
        }


        public async Task<RegionsEnum> TranslateGeoToRegion(GeographicCoordinates geo)
        {
            var result = RegionsEnum.World; //fallback if region not recognized

            if (regions.Any())
            {
                foreach (var region in regions)
                {
                    if (await IsPointInsidePolygon(geo, region.Polygon))
                    {
                        result = region.Region;
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Check if geocoordinate is inside polygon using Ray-Casting algorithm
        /// </summary>
        /// <param name="geo"></param>
        /// <param name="polygon"></param>
        /// <returns></returns>
        private async Task<bool> IsPointInsidePolygon(GeographicCoordinates geo, List<(double latitude, double longitude)> polygon) 
        {
            int count = polygon.Count;

            int intersectionCrossingCount = 0; // even = inside polygon, odd = outside polygon

            for (int i = 0; i < count; i++)
            {
                var poly1 = polygon[i];
                var poly2 = polygon[(i + 1)%count];

                //is geocoordinate between vertical boundary of edge
                if ((poly1.latitude > geo.Latitude) != (poly2.latitude > geo.Latitude))
                {
                    //TODO check this formula:
                    double intersection = 
                        poly1.longitude + ((geo.Latitude - poly1.latitude) / (poly2.latitude - poly1.latitude)) 
                        * (poly2.longitude - poly1.longitude); //intersection of edge and horizontal line passing through geocoordinate

                    if (geo.Longitude < intersection) //increase count if geocoordinate is left of the intersection 
                    {
                        intersectionCrossingCount++;
                    }
                }
            }

            return (intersectionCrossingCount % 2 == 1); // count even = inside polygon, odd = outside polygon
        }
    }
}
