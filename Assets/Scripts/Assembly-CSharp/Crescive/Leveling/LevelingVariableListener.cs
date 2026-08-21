using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public abstract class LevelingVariableListener<T> : MonoBehaviour
	{
		private enum TriggerEventTime
		{
			None = 0,
			OnAwake = 1,
			OnEnable = 2,
			OnStart = 3
		}

		[SerializeField]
		protected LevelingVariable<T> levelingVariable;

		[SerializeField]
		private TriggerEventTime triggerEventTime;

		public UnityEvent<T> OnChangedValue;

		public UnityEvent<int> OnChangedLevel;

		private bool TriggerEventsOnAwake => false;

		private bool TriggerEventsOnEnable => false;

		private bool TriggerEventsOnStart => false;

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

		protected virtual void TriggerLevelingChanged(int leveling)
		{
		}

		public void UpdateData(LevelingVariable<T> newLevelingVariable, bool triggerEvent = true)
		{
		}

		public void RaiseEvents()
		{
		}
	}
}
