using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class IntSettableVariableReference : SettableVariableReference<int, IntPair, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer, PersistentIntVariable, IntSettableScriptableProperty>
	{
	}
}
