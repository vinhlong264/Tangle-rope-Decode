using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentColor", menuName = "ScriptableObjects/Persistent/PersistentColor")]
	public class PersistentColor : PersistentVariable<Color>
	{
		public override Color GetCopy(Color value)
		{
			return default(Color);
		}
	}
}
