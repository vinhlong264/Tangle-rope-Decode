using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TrickyNumber
{
	public class ToggleGameObject : MonoBehaviour
	{
		[SerializeField]
		private bool hasCustomToggleState;

		[SerializeField]
		private bool initialToggleState;

		[SerializeField]
		private UnityEvent OnToggleOn;

		[SerializeField]
		private UnityEvent OnToggleOff;

		[SerializeField]
		[Header("State")]
		private bool customToggleState;

		public bool ToggleState => false;

		private void Awake()
		{
		}

		public void Toggle()
		{
		}
	}
}
