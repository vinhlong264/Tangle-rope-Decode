using UnityEngine;
using UnityEngine.Events;

namespace PersistentSO
{
	public class PersistentBoolVariableListener : PersistentVariableListener<bool>
	{
		[SerializeField]
		private UnityEvent<bool> OnChangedReverse;

		[SerializeField]
		private UnityEvent OnTrue;

		[SerializeField]
		private UnityEvent OnFalse;

		protected override void OnValueChanged(bool value)
		{
		}
	}
}
