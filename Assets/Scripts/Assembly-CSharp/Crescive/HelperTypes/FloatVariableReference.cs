using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class FloatVariableReference : VariableReference<float, FloatPair, FloatConstant, FloatVariable, FloatEvent, FloatPairEvent, FloatFloatFunction, FloatVariableInstancer, FloatReference, PersistentFloatVariable, FloatScriptableProperty, FloatConditionalScriptableProperty>
	{
	}
}
