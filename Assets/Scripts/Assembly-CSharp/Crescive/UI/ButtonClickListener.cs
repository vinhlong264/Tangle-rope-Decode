using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.UI
{
	public class ButtonClickListener : MonoBehaviour
	{
		[SerializeField]
		private bool hasMultipleButtons;

		[SerializeField]
		private Button button;

		[SerializeField]
		private Button[] buttons;

		public UnityEvent OnClick;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Subscribe()
		{
		}

		private void Unsubscribe()
		{
		}
	}
}
