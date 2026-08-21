using System.Collections.Generic;
using UnityEngine;

namespace CresciveCore.Extensions
{
	public static class ComponentListExtensions
	{
		public static Vector3 GetCenterOfComponents<T>(this IList<T> comps) where T : Component
		{
			return default(Vector3);
		}

		public static Vector3 GetCenterOfLowestZComponents<T>(this IEnumerable<T> comps) where T : Component
		{
			return default(Vector3);
		}
	}
}
