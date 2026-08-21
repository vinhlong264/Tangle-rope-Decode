using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(fileName = "IAP Id Exists Condition", menuName = "Crescive/IAP/Conditions/IAP Id Exists Condition")]
	public class IAPIdExistsCondition : StringCondition
	{
		[SerializeField]
		private IAPDataService service;

		public override bool Call(string id)
		{
			return false;
		}
	}
}
