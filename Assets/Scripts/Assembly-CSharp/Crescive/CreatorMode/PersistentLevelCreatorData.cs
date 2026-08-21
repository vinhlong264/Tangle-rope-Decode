using PersistentSO;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "PersistentLevelCreatorData", menuName = "Crescive/Creator Mode/Persistent Level Creator Data")]
	public class PersistentLevelCreatorData : PersistentVariable<LevelCreatorSaveData>
	{
		public override LevelCreatorSaveData GetCopy(LevelCreatorSaveData value)
		{
			return null;
		}
	}
}
