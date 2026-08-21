using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.MultiplierData
{
	public class MultiplierActivationListener : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		[SerializeField]
		private PersistentMultipliers persistentMultipliers;

		[SerializeField]
		private MultiplierArgs args;

		public UnityEvent OnActive;

		public UnityEvent OnInactive;

		public UnityEvent<bool> OnActiveChanged;

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

		private void OnDataChanged(List<MultiplierData> _)
		{
		}

		private void TriggerEvents()
		{
		}
	}
}
