using Crescive.HelperTypes;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Conditions
{
	public class StringVariableCompareCondition : AtomCondition
	{
		[SerializeField]
		private StringVariableReference compareVariable;

		[SerializeField]
		private StringVariableReference referenceVariable;

		[SerializeField]
		private bool isNot;

		public override bool Call()
		{
			return false;
		}
	}
}
