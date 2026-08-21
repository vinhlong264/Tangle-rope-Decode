using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class BoolSettableVariableReference : SettableVariableReference<bool, BoolPair, BoolConstant, BoolVariable, BoolEvent, BoolPairEvent, BoolBoolFunction, BoolVariableInstancer, PersistentBoolVariable, BoolSettableScriptableProperty>
	{
	}
}
