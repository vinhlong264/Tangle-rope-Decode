using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(menuName = "Crescive/Platform/Conditions/PlatformCompareCondition")]
	public class PlatformCompareCondition : AtomCondition
	{
		[SerializeField]
		private List<RuntimePlatform> platforms;

		public override bool Call()
		{
			return false;
		}
	}
}
