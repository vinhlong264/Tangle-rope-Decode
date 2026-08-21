using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "Set Vector2 Settable Variable Reference Value", menuName = "Unity Atoms/Actions/Set Settable Variable Reference Value/Vector2")]
	public class SetVector2SettableVariableReferenceValue : SetSettableVariableReferenceValue<Vector2, Vector2Pair, Vector2Constant, Vector2Variable, Vector2Event, Vector2PairEvent, Vector2Vector2Function, Vector2VariableInstancer, Vector2Reference, PersistentVector2Variable, Vector2ScriptableProperty, Vector2SettableScriptableProperty, Vector2ConditionalScriptableProperty, Vector2VariableReference, Vector2SettableVariableReference>
	{
	}
}
