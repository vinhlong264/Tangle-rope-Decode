using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopeSelectionListener : MonoBehaviour
	{
		[SerializeField]
		private RopeSelectionChannel selectionChannel;

		public UnityEvent OnSelectionEnabled;

		public UnityEvent OnSelectionDisabled;

		public UnityEvent<bool> OnSelectionChanged;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
