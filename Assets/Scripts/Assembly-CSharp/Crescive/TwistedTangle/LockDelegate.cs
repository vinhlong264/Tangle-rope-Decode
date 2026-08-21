using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class LockDelegate : MonoBehaviour, ILockDelegate
	{
		[field: SerializeField]
		public Lock TargetLocker { get; private set; }

		public void SetTargetLocker(Lock locker)
		{
		}
	}
}
