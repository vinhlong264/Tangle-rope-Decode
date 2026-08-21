using System;
using System.Collections.Generic;
using Crescive.Randomness;

namespace CresciveCore.Extensions
{
	public static class EnumerableExtensions
	{
		public static T GetRandom<T>(this IEnumerable<T> enu)
		{
			return default(T);
		}

		public static T GetRandom<T>(this IEnumerable<T> enu, IRandom random)
		{
			return default(T);
		}

		public static List<T> ToListShuffled<T>(this IEnumerable<T> list, IRandom random)
		{
			return null;
		}

		public static List<T> ToListShuffled<T>(this IEnumerable<T> list)
		{
			return null;
		}

		public static IEnumerable<T> WhereMin<T, T2>(this IEnumerable<T> enu, Func<T, T2> selector) where T2 : IComparable<T2>
		{
			return null;
		}

		public static IEnumerable<T> If<T>(this IEnumerable<T> enu, Func<bool> condition, Func<IEnumerable<T>, IEnumerable<T>> func)
		{
			return null;
		}

		public static Queue<T> ToQueue<T>(this IEnumerable<T> enu)
		{
			return null;
		}
	}
}
