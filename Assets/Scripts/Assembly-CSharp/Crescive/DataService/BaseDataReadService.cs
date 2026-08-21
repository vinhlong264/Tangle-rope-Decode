using UnityEngine;

namespace Crescive.DataService
{
	public abstract class BaseDataReadService : ScriptableObject
	{
		public abstract void GetSync();

		public abstract void ResetActualData();
	}
}
