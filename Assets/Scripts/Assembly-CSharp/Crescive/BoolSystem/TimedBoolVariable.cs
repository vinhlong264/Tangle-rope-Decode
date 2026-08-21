using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.BoolSystem
{
	[CreateAssetMenu(fileName = "TimedBoolVariable", menuName = "Crescive/BoolSystem/TimedBoolVariable")]
	public class TimedBoolVariable : ScriptableObject
	{
		[SerializeField]
		private PersistentBoolVariable isPermanent;

		[SerializeField]
		private PersistentIntVariable temporaryDurationSeconds;

		public UnityEvent<bool> IsActiveChanged;

		public UnityEvent<bool> IsPermanentChanged;

		public UnityEvent<bool> IsTemporaryChanged;

		public UnityEvent<int> IsTemporarySecondsChanged;

		public bool IsActive => false;

		public bool IsPermanent => false;

		public bool IsTemporary => false;

		public int TemporarySeconds => 0;

		public void SetIsPermanent(bool value)
		{
		}

		public bool IncreaseTemporarySeconds(int seconds)
		{
			return false;
		}

		public bool DecreaseTemporarySeconds(int seconds)
		{
			return false;
		}

		public bool ResetTemporarySeconds()
		{
			return false;
		}

		public void TriggerIsActiveChanged()
		{
		}

		public void TriggerTemporarySecondsChanged()
		{
		}

		public void TriggerPermanentChanged()
		{
		}

		public void TriggerAllEvents()
		{
		}
	}
}
