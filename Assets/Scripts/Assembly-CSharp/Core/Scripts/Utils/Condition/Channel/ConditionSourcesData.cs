using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Core.Scripts.Utils.Condition.Channel
{
	[CreateAssetMenu(fileName = "ConditionSourcesData", menuName = "GameData/Condition/ConditionSourcesData")]
	public class ConditionSourcesData : ScriptableObject
	{
		[Header("Events")]
		public UnityEvent OnAllConditionsMet;

		[Header("State")]
		[SerializeField]
		private List<ConditionSource> conditions;

		public List<ConditionSource> Conditions => null;

		public void SetData(List<ConditionSource> conditionsList)
		{
		}
	}
}
