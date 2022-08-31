using System;

namespace Hybrid.Shared.Services
{
	public class DataService : IDataService
	{
		public DataService()
		{
		}

        public Task<List<string>> GetData()
        {
            return Task.FromResult(new List<string>()
            {
                "Gibson",
                "Fender",
                "Gretch",
                "Rickebacker"
            });
        }
    }
}

