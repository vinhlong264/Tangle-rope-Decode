using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.HomeMenu
{
	public class LevelItem : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text levelText;

		[SerializeField]
		private TMP_Text passiveLevelText;

		[SerializeField]
		private GameObject lockIcon;

		[SerializeField]
		private GameObject focusIcon;

		[SerializeField]
		private GameObject topPath;

		[SerializeField]
		private GameObject topPathActive;

		[SerializeField]
		private GameObject bottomPath;

		[SerializeField]
		private GameObject bottomPathActive;

		[SerializeField]
		private int level;

		[SerializeField]
		private int actualLevel;

		private bool isActive;

		private bool isFocused;

		public UnityEvent OnActivated;

		public UnityEvent OnDeactivated;

		public UnityEvent<bool> OnIsActive;

		public UnityEvent<bool> OnIsActiveReversed;

		public UnityEvent OnFocused;

		public UnityEvent OnUnfocused;

		public UnityEvent<bool> OnIsFocused;

		public UnityEvent<bool> OnIsFocusedReversed;

		public UnityEvent<int> OnSetLevel;

		public UnityEvent<int> OnSetActualLevel;

		public bool IsActive => false;

		public bool IsFocused => false;

		public int Level => 0;

		public int ActualLevel => 0;

		private void Start()
		{
		}

		private void UpdateUI()
		{
		}

		public void SetLevels(int lv, int actualLv)
		{
		}

		public void SetActiveState(bool value)
		{
		}

		public void SetFocusedState(bool value)
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
