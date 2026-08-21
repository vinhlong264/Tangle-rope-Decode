using UnityEngine;

namespace Crescive.CreatorMode
{
	public abstract class BaseCreatorData : ScriptableObject
	{
		[SerializeField]
		private int levelId;

		public int LevelId => 0;

		public abstract void SetDataFromJson(string json);

		public abstract string GetDataAsJson();

		public void CopyDataJsonToClipboard()
		{
		}
	}
}
