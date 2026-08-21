using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.UI
{
	public class ToggleListener : MonoBehaviour
	{
		[SerializeField]
		private Toggle toggle;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethods;

		public UnityEvent<bool> OnValueChanged;

		public UnityEvent<bool> OnValueChangedReverse;

		public UnityEvent OnValueChangedTrue;

		public UnityEvent OnValueChangedFalse;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnToggleValueChanged(bool value)
		{
		}
	}
}
