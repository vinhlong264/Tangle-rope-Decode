using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Navigation
{
	[CreateAssetMenu(fileName = "Is Navigatable Current Condition", menuName = "Crescive/Navigation/Is Navigatable Current Condition")]
	public class IsNavigatableCurrentCondition : AtomCondition
	{
		[SerializeField]
		private NavigationChannel channel;

		[SerializeField]
		private List<StringVariableReference> navigatableIds;

		[SerializeField]
		private bool trueForAll;

		public override bool Call()
		{
			return false;
		}

		private bool CheckNavigatables()
		{
			return false;
		}

		private bool CurrentMatchesId(StringVariableReference idVariable)
		{
			return false;
		}
	}
}
