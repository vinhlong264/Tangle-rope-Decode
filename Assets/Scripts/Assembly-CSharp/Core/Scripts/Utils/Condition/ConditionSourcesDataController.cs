using System.Collections.Generic;
using Core.Scripts.Utils.Condition.Channel;
using UnityEngine;

namespace Core.Scripts.Utils.Condition
{
	public class ConditionSourcesDataController : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private ConditionSourcesData conditionSourcesData;

		private List<ConditionSource> Conditions => null;

		private void Awake()
		{
		}

		private bool IsConditionMet(ConditionSource cond)
		{
			return false;
		}

		private void OnConditionMetCallback()
		{
		}
	}
}
