using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentStringListVariable", menuName = "ScriptableObjects/Persistent/PersistentStringListVariable")]
	public class PersistentStringListVariable : PersistentListVariable<string>
	{
		public override string GetItemCopy(string item)
		{
			return null;
		}
	}
}
