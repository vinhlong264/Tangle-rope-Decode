using UnityEngine;
using UnityEngine.Events;

namespace Crescive.BoolSystem
{
	public class TimedBoolVariableListener : MonoBehaviour
	{
		[SerializeField]
		private TimedBoolVariable timedBoolVariable;

		public UnityEvent<bool> IsActiveChanged;

		public UnityEvent<bool> IsPermanentChanged;

		public UnityEvent<bool> IsTemporaryChanged;

		public UnityEvent<int> IsTemporarySecondsChanged;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
