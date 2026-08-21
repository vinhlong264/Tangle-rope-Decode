using System.Collections.Generic;

namespace Crescive.DataService
{
	public static class IMergeableExtensions
	{
		public static T MergeAll<T>(this List<T> list) where T : IMergeable<T>
		{
			return default(T);
		}

		public static void MergeOrAdd<T>(this List<T> list, List<T> otherList) where T : IMergeable<T>
		{
		}
	}
}
