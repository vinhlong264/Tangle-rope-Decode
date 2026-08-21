using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.StartPanel
{
	public class LevelTreeItem : MonoBehaviour
	{
		[SerializeField]
		private IntVariableInstancer levelVar;

		[SerializeField]
		private GameObject visualPivot;

		[Header("Paths")]
		[SerializeField]
		private GameObject topPath;

		[SerializeField]
		private GameObject topPathActive;

		[SerializeField]
		private GameObject bottomPath;

		[SerializeField]
		private GameObject bottomPathActive;

		private bool didSetData;

		private int level;

		private bool isActive;

		private bool isFocused;

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

		private void SyncDataToInstancers()
		{
		}

		public void SetData(int itemLevel)
		{
		}

		public void SetActiveState(bool value)
		{
		}

		public void SetFocusedState(bool value)
		{
		}

		public void SetComingSoonState(bool value)
		{
		}

		public void SetVisibleState(bool value)
		{
		}

		public void SetTopPathState(bool value)
		{
		}

		public void SetBottomPathState(bool value)
		{
		}

		public void SetTopPathActiveState(bool value)
		{
		}

		public void SetBottomPathActiveState(bool value)
		{
		}
	}
}
