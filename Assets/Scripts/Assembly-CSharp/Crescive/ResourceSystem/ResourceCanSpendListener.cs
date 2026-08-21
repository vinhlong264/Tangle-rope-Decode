using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public class ResourceCanSpendListener : MonoBehaviour
	{
		[SerializeField]
		public ResourceChannel resourceChannel;

		[SerializeField]
		private FloatReference spendAmount;

		[SerializeField]
		private List<AtomCondition> canSpendConditions;

		[SerializeField]
		public UnityEvent OnCanSpend;

		[SerializeField]
		public UnityEvent OnCanNotSpend;

		[SerializeField]
		public UnityEvent<bool> OnCanSpendChanged;

		[SerializeField]
		public UnityEvent<bool> OnCanNotSpendChanged;

		private bool? canSpend;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnResourceValueChangedCallback(float value)
		{
		}

		public void CheckCanSpend(bool force = false)
		{
		}

		public void SetResourceChannel(ResourceChannel value)
		{
		}
	}
}
