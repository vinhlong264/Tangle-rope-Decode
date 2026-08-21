using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Navigation
{
	public class BasicNavigatable : MonoBehaviour
	{
		public UnityEvent OnShow;

		public UnityEvent OnHide;

		public UnityEvent<bool> OnVisibleChanged;

		public bool IsVisible => false;

		public void Show()
		{
		}

		public void Hide()
		{
		}
	}
}
