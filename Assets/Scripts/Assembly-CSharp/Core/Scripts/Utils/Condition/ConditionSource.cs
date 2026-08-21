using Core.Scripts.Utils.Condition.Channel;
using UnityEngine;
using UnityEngine.Events;

namespace Core.Scripts.Utils.Condition
{
	public class ConditionSource : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private ConditionSourcesData conditionSourcesData;

		[Header("Settings")]
		[SerializeField]
		private bool isActive;

		[Header("Events")]
		public UnityEvent OnConditionMet;

		[Header("State")]
		[SerializeField]
		private bool isConditionMet;

		public bool IsActive => false;

		public bool IsConditionMet => false;

		public ConditionSourcesData ConditionSourcesData => null;

		public void SetCondition(bool value)
		{
		}
	}
}
