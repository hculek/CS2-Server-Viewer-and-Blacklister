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


        public async Task<Regions> TranslateGeoToRegion(GeographicCoordinates geo)
        {
            var result = Regions.World;

            foreach (var region in regions)
            {
                if (await IsPointInsidePolygon(geo, region.Polygon))
                {
                    result = region.Region;
                    break;
                }
            }

            return result;
        }

        private async Task<bool> IsPointInsidePolygon(GeographicCoordinates geo, List<(double latitude, double longitude)> polygon) 
        {
            int count = polygon.Count;

            int intersectionCrossingCount = 0; // even = inside, odd = outside

            for (int i = 0; i < count; i++)
            {
                var poly1 = polygon[i];
                var poly2 = polygon[(i + 1)%count];

                if ((poly1.latitude > geo.Latitude) != (poly2.latitude > geo.Latitude))
                {
                    double intersection = 
                        poly1.longitude + ((geo.Latitude - poly1.latitude) / (poly2.latitude - poly1.latitude))
                        * (poly2.longitude - poly1.longitude);

                    if (geo.Longitude < intersection)
                    {
                        intersectionCrossingCount++;
                    }
                }
            }

            return (intersectionCrossingCount % 2 == 1);
        }
    }
}
