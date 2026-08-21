using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class FloatSettableVariableReference : SettableVariableReference<float, FloatPair, FloatConstant, FloatVariable, FloatEvent, FloatPairEvent, FloatFloatFunction, FloatVariableInstancer, PersistentFloatVariable, FloatSettableScriptableProperty>
	{
	}
}
