using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace devdays
{
	[Route("api/[controller]")]
	public class DataController
	{
		private static List<int> _data = new List<int>();
		[HttpGet]
		public IEnumerable<int> All()
		{
			return _data;
		}
		
		[Route("{item:int}")]
		[HttpGet]
		public string Add(int item)
		{
			_data.Add(item);
			return "Current items:" + _data.Count;
		}
	}
}