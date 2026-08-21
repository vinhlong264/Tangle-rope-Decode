using System;
using System.Collections.Generic;
using Crescive.Randomness;

namespace CresciveCore.Extensions
{
	public static class IListExtensions
	{
		public static int FirstIndex<T>(this IList<T> source, Predicate<T> predicate)
		{
			return 0;
		}

		public static T GetRandom<T>(this IList<T> list, IRandom random)
		{
			return default(T);
		}

		public static T GetRandom<T>(this IList<T> list)
		{
			return default(T);
		}

		public static IList<T> Shuffle<T>(this IList<T> list, IRandom random)
		{
			return null;
		}

		public static IList<T> Shuffle<T>(this IList<T> list)
		{
			return null;
		}
	}
}
