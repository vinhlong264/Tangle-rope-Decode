using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Levels
{
	public class AtomConditionEventChooser : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod triggerMethod;

		[SerializeField]
		private List<AtomConditionEventData> events;

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
