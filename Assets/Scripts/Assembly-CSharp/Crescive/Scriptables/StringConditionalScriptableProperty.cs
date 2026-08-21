using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "String Conditional Scriptable Property", menuName = "Crescive/Scriptables/Property/Conditional/String Conditional Scriptable Property")]
	public class StringConditionalScriptableProperty : ConditionalScriptableProperty<string, StringPair, StringConstant, StringVariable, StringEvent, StringPairEvent, StringStringFunction, StringVariableInstancer, StringReference, PersistentStringVariable, StringScriptableProperty, StringConditionalScriptableProperty, StringVariableReference, StringConditionVariableReferencePair>
	{
	}
}
