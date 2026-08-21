using Crescive.ResourceSystem;
using UnityAtoms;
using UnityEngine;

namespace Crescive
{
	[CreateAssetMenu(fileName = "ResourceInfiniteCondition", menuName = "Unity Atoms/Conditions/ResourceInfiniteCondition")]
	public class ResourceInfiniteCondition : AtomCondition
	{
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private bool isInfinite;

		public override bool Call()
		{
			return false;
		}
	}
}
