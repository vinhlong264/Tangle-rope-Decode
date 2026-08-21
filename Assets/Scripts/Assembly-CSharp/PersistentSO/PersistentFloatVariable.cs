using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentFloatVariable", menuName = "ScriptableObjects/Persistent/PersistentFloatVariable")]
	public class PersistentFloatVariable : PersistentVariable<float>
	{
		public override float GetCopy(float value)
		{
			return 0f;
		}
	}
}
