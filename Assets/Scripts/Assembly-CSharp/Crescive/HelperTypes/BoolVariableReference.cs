using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class BoolVariableReference : VariableReference<bool, BoolPair, BoolConstant, BoolVariable, BoolEvent, BoolPairEvent, BoolBoolFunction, BoolVariableInstancer, BoolReference, PersistentBoolVariable, BoolScriptableProperty, BoolConditionalScriptableProperty>
	{
		[SerializeField]
		private AtomCondition customType1;

		protected override bool GetCustomType1Value()
		{
			return false;
		}
	}
}
