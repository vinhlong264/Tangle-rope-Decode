using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class SelectorsToggleControllerListener : MonoBehaviour
	{
		[SerializeField]
		private SelectorsToggleController controller;

		public UnityEvent<bool> OnSelectionToggled;

		public UnityEvent OnSelectionEnabled;

		public UnityEvent OnSelectionDisabled;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
