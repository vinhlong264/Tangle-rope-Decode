using UnityEngine;

namespace CresciveCore.Utils
{
	public abstract class BaseSingletonSO : ScriptableObject
	{
		public abstract void Initialize();

		public abstract void Dispose();
	}
}
