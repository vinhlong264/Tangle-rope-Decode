using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Navigation
{
	public class Navigatable : MonoBehaviour
	{
		[SerializeField]
		private NavigationChannel navigationChannel;

		[SerializeField]
		private GameObject targetPanel;

		[SerializeField]
		private StringReference id;

		[SerializeField]
		private int priority;

		private object showArgs;

		public UnityEvent OnShow;

		public UnityEvent OnHide;

		public UnityEvent<bool> OnVisibleChanged;

		public UnityEvent<object> OnShowArgs;

		public UnityEvent OnPush;

		public UnityEvent OnOverlay;

		public UnityEvent OnPop;

		public string Id => null;

		public int Priority => 0;

		public GameObject TargetPanel => null;

		public bool IsVisible => false;

		public bool MatchesId(string navigatableId)
		{
			return false;
		}

		public bool HasMorePriorityThan(Navigatable navigatable)
		{
			return false;
		}

		public bool HasSameOrMorePriorityThan(Navigatable navigatable)
		{
			return false;
		}

		public void Show()
		{
		}

		public void Show(object args)
		{
		}

		public void Hide()
		{
		}

		public void TriggerOnPush()
		{
		}

		public void TriggerOnOverlay()
		{
		}

		public void TriggerOnPop()
		{
		}

		public void PushSelf()
		{
		}

		public void PushSelfWithPopIfCurrent()
		{
		}

		public void PushBackSelf()
		{
		}

		public void OverlaySelf()
		{
		}

		public void PopSelf()
		{
		}

		public bool IsNavigationStackEmpty()
		{
			return false;
		}
	}
}
