using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "Set Bool Settable Variable Reference Value", menuName = "Unity Atoms/Actions/Set Settable Variable Reference Value/Bool")]
	public class SetBoolSettableVariableReferenceValue : SetSettableVariableReferenceValue<bool, BoolPair, BoolConstant, BoolVariable, BoolEvent, BoolPairEvent, BoolBoolFunction, BoolVariableInstancer, BoolReference, PersistentBoolVariable, BoolScriptableProperty, BoolSettableScriptableProperty, BoolConditionalScriptableProperty, BoolVariableReference, BoolSettableVariableReference>
	{
	}
}
