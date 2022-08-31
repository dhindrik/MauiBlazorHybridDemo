using System;
namespace Hybrid.Shared.Services
{
	public interface IDataService
	{
		Task<List<string>> GetData();
	}
}

