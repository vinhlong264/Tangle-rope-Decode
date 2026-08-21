using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentBoolVariable", menuName = "ScriptableObjects/Persistent/PersistentBoolVariable")]
	public class PersistentBoolVariable : PersistentVariable<bool>
	{
		public override bool GetCopy(bool value)
		{
			return false;
		}
	}
}
