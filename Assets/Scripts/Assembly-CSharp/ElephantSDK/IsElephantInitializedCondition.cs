using UnityAtoms;
using UnityEngine;

namespace ElephantSDK
{
	[CreateAssetMenu(menuName = "Elephant/Conditions/IsElephantInitializedCondition")]
	public class IsElephantInitializedCondition : AtomCondition
	{
		public override bool Call()
		{
			return false;
		}
	}
}
