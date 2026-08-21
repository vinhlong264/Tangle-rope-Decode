using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Levels
{
	public class BaseLevelFunnelData<T> : ScriptableObject
	{
		[SerializeField]
		private List<T> levels;

		public List<T> Levels => null;

		public T GetLevel(int levelNumber)
		{
			return default(T);
		}
	}
}
