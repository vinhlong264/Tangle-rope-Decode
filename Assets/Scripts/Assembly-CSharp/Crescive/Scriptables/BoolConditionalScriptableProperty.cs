using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "Bool Conditional Scriptable Property", menuName = "Crescive/Scriptables/Property/Conditional/Bool Conditional Scriptable Property")]
	public class BoolConditionalScriptableProperty : ConditionalScriptableProperty<bool, BoolPair, BoolConstant, BoolVariable, BoolEvent, BoolPairEvent, BoolBoolFunction, BoolVariableInstancer, BoolReference, PersistentBoolVariable, BoolScriptableProperty, BoolConditionalScriptableProperty, BoolVariableReference, BoolConditionVariableReferencePair>
	{
	}
}
