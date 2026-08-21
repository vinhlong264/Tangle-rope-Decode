using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Levels
{
	public class LevelsDataServiceListener : MonoBehaviour
	{
		public UnityEvent<NewLevelsData> OnNewLevelsAdded;

		public UnityEvent<NewLevelsData> OnNewLevelsAddedWhenOnLoop;

		public UnityEvent OnUniqueLevelCompleted;

		public UnityEvent OnLoopLevelCompleted;

		public UnityEvent OnUniqueLevelsCompleted;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
