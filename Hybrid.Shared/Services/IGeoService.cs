using System;
namespace Hybrid.Shared.Services
{
	public interface IGeoService
	{
		Task<Position> GetPosition();
	}

	public class Position
	{
		public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

