using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class LevelingDataListener : MonoBehaviour
	{
		public LevelingData levelingData;

		[SerializeField]
		private bool triggerEventsOnAwake;

		[SerializeField]
		private bool triggerEventsOnStart;

		[SerializeField]
		private bool triggerEventsOnEnable;

		public UnityEvent<int> OnChanged;

		public UnityEvent<int> OnIncreased;

		public UnityEvent<int> OnDecreased;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToLeveling()
		{
		}

		private void UnsubscribeFromLeveling()
		{
		}

		private void TriggerEventsIfConditionMet(bool trigger)
		{
		}

		private void TriggerLevelingChanged(int leveling)
		{
		}

		private void TriggerLevelingIncreased(int amount)
		{
		}

		private void TriggerLevelingDecreased(int amount)
		{
		}

		public void UpdateData(LevelingData levelingData, bool triggerEvent = true)
		{
		}
	}
}
