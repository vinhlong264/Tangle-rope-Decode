using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "Int Conditional Scriptable Property", menuName = "Crescive/Scriptables/Property/Conditional/Int Conditional Scriptable Property")]
	public class IntConditionalScriptableProperty : ConditionalScriptableProperty<int, IntPair, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer, IntReference, PersistentIntVariable, IntScriptableProperty, IntConditionalScriptableProperty, IntVariableReference, IntConditionVariableReferencePair>
	{
	}
}
