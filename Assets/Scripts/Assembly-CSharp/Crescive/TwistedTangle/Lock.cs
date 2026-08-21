using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class Lock : MonoBehaviour, ILockDelegate
	{
		public UnityEvent OnLock;

		public UnityEvent OnUnlock;

		public UnityEvent<bool> OnLockChanged;

		public UnityEvent<bool> OnUnlockChanged;

		[field: SerializeField]
		public bool Locked { get; private set; }

		public Lock TargetLocker => null;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void SetLock(bool value)
		{
		}

		public void ToggleLock()
		{
		}

		private void TriggerLockEvents()
		{
		}
	}
}
