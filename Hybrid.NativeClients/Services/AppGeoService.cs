using System;
using Hybrid.Shared.Services;

namespace Hybrid.NativeClients.Services
{
	public class AppGeoService : IGeoService
	{
		public AppGeoService()
		{
		}

        public async Task<Position> GetPosition()
        {
            var postion = await Geolocation.Default.GetLocationAsync();

            return new Position()
            {
                Latitude = postion.Latitude,
                Longitude = postion.Longitude
            };
        }
    }
}

