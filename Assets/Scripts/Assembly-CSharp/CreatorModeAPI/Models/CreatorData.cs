namespace CreatorModeAPI.Models
{
	public class CreatorData
	{
		public string Id { get; set; }

		public string LevelJson { get; set; }

		public CreatorData(string id, string levelJson)
		{
		}

		public CreatorData(string id)
		{
		}
	}
}
