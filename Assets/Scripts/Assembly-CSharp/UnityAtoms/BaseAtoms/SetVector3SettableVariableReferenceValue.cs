using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "Set Vector3 Settable Variable Reference Value", menuName = "Unity Atoms/Actions/Set Settable Variable Reference Value/Vector3")]
	public class SetVector3SettableVariableReferenceValue : SetSettableVariableReferenceValue<Vector3, Vector3Pair, Vector3Constant, Vector3Variable, Vector3Event, Vector3PairEvent, Vector3Vector3Function, Vector3VariableInstancer, Vector3Reference, PersistentVector3Variable, Vector3ScriptableProperty, Vector3SettableScriptableProperty, Vector3ConditionalScriptableProperty, Vector3VariableReference, Vector3SettableVariableReference>
	{
	}
}
