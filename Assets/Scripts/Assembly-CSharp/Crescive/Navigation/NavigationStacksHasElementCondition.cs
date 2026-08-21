using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Navigation
{
	[CreateAssetMenu(fileName = "Navigation Stacks Has Element Condition", menuName = "Crescive/Navigation/Navigation Stacks Has Element Condition")]
	public class NavigationStacksHasElementCondition : BoolCondition
	{
		[SerializeField]
		private List<NavigationChannel> channels;

		private bool IsTrue => false;

		public override bool Call()
		{
			return false;
		}
	}
}
