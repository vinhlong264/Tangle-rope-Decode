using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.MultiplierData
{
	public class MultiplierListener : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		[SerializeField]
		private PersistentMultipliers persistentMultipliers;

		[SerializeField]
		private MultiplierArgs multiplierArgs;

		public UnityEvent<string> OnGetId;

		public UnityEvent<float> OnGetMultiplier;

		public UnityEvent<int> OnGetMultiplierInt;

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
