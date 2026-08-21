using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentIntVariable", menuName = "ScriptableObjects/Persistent/PersistentIntVariable")]
	public class PersistentIntVariable : PersistentVariable<int>
	{
		public override int GetCopy(int value)
		{
			return 0;
		}

		public void Add(int value)
		{
		}

		public void Subtract(int value)
		{
		}
	}
}
