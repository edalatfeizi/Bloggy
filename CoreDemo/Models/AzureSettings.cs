using System.Collections.Generic;

namespace CoreDemo.Models
{
	public class AzureSettings
	{
		public int MaxUserCount { get; set; }
		public bool CanUserAddQueue { get; set; }
		public List<BlobStorage> BlobStorages { get; set; }
	}

	public class BlobStorage
	{
		public string Name { get; set; }
		public bool IsPublic { get; set; }
	}
}
