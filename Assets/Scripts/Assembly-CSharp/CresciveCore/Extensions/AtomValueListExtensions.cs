using System;
using System.Collections.Generic;
using UnityAtoms;

namespace CresciveCore.Extensions
{
	public static class AtomValueListExtensions
	{
		public static void AddRange<T, E>(this AtomValueList<T, E> atomList, IEnumerable<T> items) where E : AtomEvent<T>
		{
		}

		public static void RemoveAll<T, E>(this AtomValueList<T, E> atomList, Predicate<T> predicate) where E : AtomEvent<T>
		{
		}

		public static void CopyFrom<T, E>(this AtomValueList<T, E> atomList, AtomValueList<T, E> other) where E : AtomEvent<T>
		{
		}
	}
}
