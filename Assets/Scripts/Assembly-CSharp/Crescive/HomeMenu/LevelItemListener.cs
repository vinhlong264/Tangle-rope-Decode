using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.HomeMenu
{
	public class LevelItemListener : MonoBehaviour
	{
		[SerializeField]
		private LevelItem levelItem;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

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

		private void Awake()
		{
		}

		private void Start()
		{
		}

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

		public void TriggerEvents()
		{
		}
	}
}
