using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "Set String Settable Variable Reference Value", menuName = "Unity Atoms/Actions/Set Settable Variable Reference Value/String")]
	public class SetStringSettableVariableReferenceValue : SetSettableVariableReferenceValue<string, StringPair, StringConstant, StringVariable, StringEvent, StringPairEvent, StringStringFunction, StringVariableInstancer, StringReference, PersistentStringVariable, StringScriptableProperty, StringSettableScriptableProperty, StringConditionalScriptableProperty, StringVariableReference, StringSettableVariableReference>
	{
	}
}
