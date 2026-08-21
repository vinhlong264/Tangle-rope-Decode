using UnityEngine;
using UnityEngine.Events;

namespace Crescive.StartPanel
{
	public class LevelTreeItemListener : MonoBehaviour
	{
		[SerializeField]
		private LevelTreeItem item;

		public UnityEvent OnActivated;

		public UnityEvent OnDeactivated;

		public UnityEvent<bool> OnActiveState;

		public UnityEvent<bool> OnActiveStateReverse;

		public UnityEvent OnFocused;

		public UnityEvent OnUnfocused;

		public UnityEvent<bool> OnFocusState;

		public UnityEvent<bool> OnFocusStateReverse;

		public UnityEvent OnComingSoon;

		public UnityEvent OnNotComingSoon;

		public UnityEvent<bool> OnComingSoonState;

		public UnityEvent<bool> OnComingSoonStateReverse;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
