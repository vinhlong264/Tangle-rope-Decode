using Crescive.ResourceSystem;
using UnityAtoms;
using UnityEngine;

namespace Crescive
{
	[CreateAssetMenu(fileName = "ResourceFullCondition", menuName = "Unity Atoms/Conditions/ResourceFullCondition")]
	public class ResourceFullCondition : AtomCondition
	{
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private HeartResourceGeneratorSelector heartResourceGeneratorSelector;

		[SerializeField]
		private bool isFull;

		public override bool Call()
		{
			return false;
		}
	}
}
