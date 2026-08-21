using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class IntVariableReference : VariableReference<int, IntPair, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer, IntReference, PersistentIntVariable, IntScriptableProperty, IntConditionalScriptableProperty>
	{
	}
}
