using Crescive.CreatorMode;

namespace CreatorModeAPI.Models
{
	public class LevelModel
	{
		public string LevelJson { get; set; }

		public LevelModel(string levelJson)
		{
		}

		public LevelCreatorSaveData ToCreatorData()
		{
			return null;
		}
	}
}
