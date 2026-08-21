using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-delicate")]
	[AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Transform Variable Instancer to Collection")]
	public class SyncTransformVariableInstancerToCollection : SyncVariableInstancerToCollection<Transform, TransformVariable, TransformVariableInstancer>
	{
	}
}
