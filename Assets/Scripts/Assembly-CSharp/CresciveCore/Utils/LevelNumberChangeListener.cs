using System.Collections.Generic;
using PersistentSO;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace CresciveCore.Utils
{
	public class LevelNumberChangeListener : MonoBehaviour
	{
		[SerializeField]
		private PersistentIntVariable savedLevelNumber;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private List<AtomCondition> mustTriggerConditions;

		[SerializeField]
		[Space]
		private List<IntUnityEventCallbackDelegate> changedCallbacks;

		[Space]
		[SerializeField]
		private List<IntUnityEventCallbackDelegate> changedDifferenceCallbacks;

		[Space]
		public UnityEvent<int> OnLevelNumberChanged;

		public UnityEvent<int> OnLevelNumberChangedDifference;

		public void CheckAndTriggerIfNecessary()
		{
		}

		private void Trigger(int levelNumber)
		{
		}
	}
}
