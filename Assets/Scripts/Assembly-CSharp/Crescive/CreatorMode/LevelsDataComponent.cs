using UnityEngine;
using UnityEngine.Events;

namespace Crescive.CreatorMode
{
	public class LevelsDataComponent : MonoBehaviour
	{
		[SerializeField]
		private LevelsData levelsData;

		public UnityEvent<LevelCreatorData> OnGetCurrentLevelTriggered;

		public LevelsData LevelsData => null;

		public void RaiseGetCurrentLevel()
		{
		}
	}
}
