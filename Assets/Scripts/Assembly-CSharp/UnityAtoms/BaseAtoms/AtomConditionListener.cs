using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
	public class AtomConditionListener : MonoBehaviour
	{
		[SerializeField]
		[Header("Trigger Settings")]
		private AutoTriggerMethod autoTriggerMethods;

		[SerializeField]
		private List<AtomCondition> conditions;

		public UnityEvent OnTrue;

		public UnityEvent OnFalse;

		public UnityEvent<bool> OnMatch;

		public UnityEvent<bool> OnMatchReverse;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void TriggerEvents()
		{
		}
	}
}
