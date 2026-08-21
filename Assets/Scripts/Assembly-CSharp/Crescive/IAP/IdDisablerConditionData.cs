using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/DataService/IdDisablerConditionData", fileName = "IdDisablerConditionData")]
	public class IdDisablerConditionData : ScriptableObject
	{
		[SerializeField]
		private List<BoolVariableReference> disableConditions;

		[SerializeField]
		private List<string> ids;

		private bool IsDisabled => false;

		private List<string> AllIds => null;

		public bool IsIdDisabled(string id)
		{
			return false;
		}
	}
}
