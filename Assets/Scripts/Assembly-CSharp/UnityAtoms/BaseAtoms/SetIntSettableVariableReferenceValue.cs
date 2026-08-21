using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "Set Int Settable Variable Reference Value", menuName = "Unity Atoms/Actions/Set Settable Variable Reference Value/Int")]
	public class SetIntSettableVariableReferenceValue : SetSettableVariableReferenceValue<int, IntPair, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer, IntReference, PersistentIntVariable, IntScriptableProperty, IntSettableScriptableProperty, IntConditionalScriptableProperty, IntVariableReference, IntSettableVariableReference>
	{
	}
}
