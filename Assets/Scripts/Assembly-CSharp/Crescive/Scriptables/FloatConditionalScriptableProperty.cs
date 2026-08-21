using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "Float Conditional Scriptable Property", menuName = "Crescive/Scriptables/Property/Conditional/Float Conditional Scriptable Property")]
	public class FloatConditionalScriptableProperty : ConditionalScriptableProperty<float, FloatPair, FloatConstant, FloatVariable, FloatEvent, FloatPairEvent, FloatFloatFunction, FloatVariableInstancer, FloatReference, PersistentFloatVariable, FloatScriptableProperty, FloatConditionalScriptableProperty, FloatVariableReference, FloatConditionVariableReferencePair>
	{
	}
}
