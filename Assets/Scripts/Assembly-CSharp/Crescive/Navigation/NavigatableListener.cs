using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Navigation
{
	public class NavigatableListener : MonoBehaviour
	{
		[SerializeField]
		private Navigatable navigatable;

		public UnityEvent OnShow;

		public UnityEvent OnHide;

		public UnityEvent<bool> OnVisibleChanged;

		public UnityEvent<object> OnShowArgs;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
