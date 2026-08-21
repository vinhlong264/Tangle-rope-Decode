using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class StringVariableReference : VariableReference<string, StringPair, StringConstant, StringVariable, StringEvent, StringPairEvent, StringStringFunction, StringVariableInstancer, StringReference, PersistentStringVariable, StringScriptableProperty, StringConditionalScriptableProperty>
	{
	}
}
