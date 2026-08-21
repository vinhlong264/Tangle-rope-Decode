using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "Set Float Settable Variable Reference Value", menuName = "Unity Atoms/Actions/Set Settable Variable Reference Value/Float")]
	public class SetFloatSettableVariableReferenceValue : SetSettableVariableReferenceValue<float, FloatPair, FloatConstant, FloatVariable, FloatEvent, FloatPairEvent, FloatFloatFunction, FloatVariableInstancer, FloatReference, PersistentFloatVariable, FloatScriptableProperty, FloatSettableScriptableProperty, FloatConditionalScriptableProperty, FloatVariableReference, FloatSettableVariableReference>
	{
	}
}
