using Core.Scripts.Utils.Condition.Channel;
using UnityEngine;
using UnityEngine.Events;

namespace Core.Scripts.Utils.Condition.Listener
{
	public class ConditionSourcesDataListener : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private ConditionSourcesData conditionSourcesData;

		[Header("Events")]
		[SerializeField]
		private UnityEvent OnAllConditionsMet;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAllConditionsMetCallback()
		{
		}
	}
}
