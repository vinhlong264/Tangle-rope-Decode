using System;
using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
	public static int FirstIndex<T>(this IList<T> source, Predicate<T> predicate)
	{
		return 0;
	}

	public static T GetRandom<T>(this IList<T> list, System.Random random)
	{
		return default(T);
	}

	public static T GetRandom<T>(this IList<T> list)
	{
		return default(T);
	}

	public static List<T> GetRandomAmountDistinct<T>(this IList<T> list, int amount, System.Random random)
	{
		return null;
	}

	public static List<T> GetRandomAmountDistinct<T>(this IList<T> list, int amount)
	{
		return null;
	}

	public static List<T> GetRandomWeightedAmountDistinct<T>(this IList<T> list, AnimationCurve weight, int limit)
	{
		return null;
	}

	public static bool AddUnique<T>(this List<T> list, T item)
	{
		return false;
	}

	public static bool AddUnique<T>(this List<T> list, T item, Func<T, bool> predicate)
	{
		return false;
	}

	public static void AddRangeUnique<T>(this List<T> list, IEnumerable<T> items, Func<T, bool> predicate)
	{
	}

	public static bool RemoveSafe<T>(this List<T> list, T item)
	{
		return false;
	}

	public static List<T> Shuffle<T>(this List<T> list)
	{
		return null;
	}

	public static List<T> Shuffle<T>(this List<T> list, System.Random random)
	{
		return null;
	}

	public static List<T> Shuffle<T>(this List<T> list, int seed)
	{
		return null;
	}

	public static List<T> RemoveNulls<T>(this List<T> list) where T : class
	{
		return null;
	}

	public static bool ContainsAny<T>(this List<T> list, List<T> otherList)
	{
		return false;
	}

	public static void SetSize<T>(this List<T> list, int size)
	{
	}

	public static List<T> AddIfNotContains<T>(this List<T> list, T item)
	{
		return null;
	}

	public static List<T> AddRangeIfNotContains<T>(this List<T> list, List<T> items)
	{
		return null;
	}

	public static List<T> CloneAll<T>(this List<T> list) where T : ICloneable
	{
		return null;
	}

	public static List<T> CopyAll<T>(this List<T> list) where T : struct
	{
		return null;
	}
}
