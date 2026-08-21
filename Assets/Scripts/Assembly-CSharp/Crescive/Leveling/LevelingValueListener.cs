using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class LevelingValueListener : MonoBehaviour
	{
		private enum TriggerEventTime
		{
			None = 0,
			OnAwake = 1,
			OnEnable = 2,
			OnStart = 3
		}

		[RequireInterface(typeof(ILevelingValue))]
		[SerializeField]
		private Object levelingValue;

		[SerializeField]
		private TriggerEventTime triggerEventTime;

		public UnityEvent<int> OnLevelingValueChanged;

		public UnityEvent<int> OnLevelIncreased;

		public UnityEvent<int> OnLevelDecreased;

		private ILevelingValue LevelingValue => null;

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

		private void TriggerEventsIfConditionMet(bool trigger)
		{
		}

		private void OnLevelingValueChangedCallback(int level)
		{
		}

		private void OnLevelingValueIncreasedCallback(int amount)
		{
		}

		private void OnLevelingValueDecreasedCallback(int amount)
		{
		}
	}
}
