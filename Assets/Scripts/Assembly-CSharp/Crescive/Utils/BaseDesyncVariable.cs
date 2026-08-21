using UnityEngine;

namespace Crescive.Utils
{
	public abstract class BaseDesyncVariable : ScriptableObject
	{
		[SerializeField]
		[Header("Settings")]
		private bool initialIsSyncing;

		[Header("State")]
		[SerializeField]
		private bool isSyncing;

		public bool IsSyncing => false;

		public void SetSyncing(bool value)
		{
		}

		public void Setup()
		{
		}

		public void Dispose()
		{
		}

		protected abstract void SetupInternal();

		protected abstract void DisposeInternal();

		protected abstract void SetSyncingInternal(bool value);
	}
}
