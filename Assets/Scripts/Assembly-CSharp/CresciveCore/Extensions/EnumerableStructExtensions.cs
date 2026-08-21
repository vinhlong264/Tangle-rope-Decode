using System;
using System.Collections.Generic;

namespace CresciveCore.Extensions
{
	public static class EnumerableStructExtensions
	{
		public static T? FirstOrNullStruct<T>(this IEnumerable<T> source, Func<T, bool> predicate) where T : struct
		{
			return null;
		}

		public static T? FirstOrNullStruct<T>(this IEnumerable<T> source) where T : struct
		{
			return null;
		}
	}
}
