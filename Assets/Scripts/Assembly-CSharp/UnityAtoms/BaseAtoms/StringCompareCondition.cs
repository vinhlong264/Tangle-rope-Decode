using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "StringCompareCondition", menuName = "Unity Atoms/Conditions/StringCompareCondition")]
	public class StringCompareCondition : BoolCondition
	{
		[SerializeField]
		private StringVariable compareVariable;

		[SerializeField]
		private StringReference referenceVariable;

		[SerializeField]
		private bool isNot;

		public override bool Call()
		{
			return false;
		}
	}
}
