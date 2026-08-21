using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Navigation
{
	[CreateAssetMenu(fileName = "Is Navigatable In Stack Condition", menuName = "Crescive/Navigation/Is Navigatable In Stack Condition")]
	public class IsNavigatableInStackCondition : AtomCondition
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

		private bool HasNavigatableIdInStack(StringVariableReference idVariable)
		{
			return false;
		}
	}
}
