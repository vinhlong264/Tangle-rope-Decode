using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class BehaviourToggler : MonoBehaviour
	{
		[SerializeField]
		private Behaviour behaviour;

		public UnityEvent OnEnableEvent;

		public UnityEvent OnDisableEvent;

		public void Toggle()
		{
		}
	}
}
