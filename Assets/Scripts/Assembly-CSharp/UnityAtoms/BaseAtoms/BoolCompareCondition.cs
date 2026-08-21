using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "BoolCompareCondition", menuName = "Unity Atoms/Conditions/BoolCompareCondition")]
	public class BoolCompareCondition : BoolCondition
	{
		[SerializeField]
		private BoolReference comparedValue;

		public override bool Call(bool value)
		{
			return false;
		}

		public override bool Call()
		{
			return false;
		}
	}
}
