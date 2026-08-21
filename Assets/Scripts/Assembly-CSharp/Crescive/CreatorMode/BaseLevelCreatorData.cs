using UnityEngine;

namespace Crescive.CreatorMode
{
	public class BaseLevelCreatorData<TSaveData> : BaseCreatorData
	{
		[SerializeField]
		protected TSaveData saveData;

		public virtual TSaveData SaveData => default(TSaveData);

		public int GetLevelId()
		{
			return 0;
		}

		public void SetData(TSaveData data)
		{
		}

		public override void SetDataFromJson(string json)
		{
		}

		public override string GetDataAsJson()
		{
			return null;
		}
	}
}
