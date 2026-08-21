using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class StringSettableVariableReference : SettableVariableReference<string, StringPair, StringConstant, StringVariable, StringEvent, StringPairEvent, StringStringFunction, StringVariableInstancer, PersistentStringVariable, StringSettableScriptableProperty>
	{
	}
}
