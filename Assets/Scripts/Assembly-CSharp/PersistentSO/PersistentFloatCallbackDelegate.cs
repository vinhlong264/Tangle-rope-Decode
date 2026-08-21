using UnityEngine;
using UnityEngine.Events;

namespace PersistentSO
{
	public class PersistentFloatCallbackDelegate : MonoBehaviour
	{
		[SerializeField]
		private PersistentFloatVariable variable;

		public UnityEvent<float> OnInvoke;

		public UnityEvent<float> OnInvokeInitialValue;

		public void Invoke()
		{
		}
	}
}
