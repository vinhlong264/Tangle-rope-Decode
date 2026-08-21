using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "Float Desync Variable", menuName = "Crescive/Scriptables/Desync Variable/Float Desync Variable")]
	public class FloatDesyncVariable : DesyncVariable<float, FloatPair, FloatConstant, FloatVariable, FloatEvent, FloatPairEvent, FloatFloatFunction, FloatVariableInstancer, PersistentFloatVariable, FloatSettableScriptableProperty, FloatSettableVariableReference>
	{
	}
}
