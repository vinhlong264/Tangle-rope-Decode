using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PersistentSO
{
	public abstract class PersistentListVariable<T> : PersistentVariable<List<T>>, ICloneable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		public int Count => 0;

		public bool IsReadOnly => false;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public event Action<T> OnAdd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		bool ICollection<T>.Remove(T item)
		{
			return false;
		}

		public void Sort(Comparison<T> comparison)
		{
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public void AddRange(IEnumerable<T> elements)
		{
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T element)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveAll(Predicate<T> predicate)
		{
		}

		public void InsertRange(int index, IEnumerable<T> elements)
		{
		}

		public void AddOrChange(T element, Predicate<T> predicate)
		{
		}

		public void AddUnique(T element)
		{
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public void Remove(T element)
		{
		}

		public void RemoveSafe(T element)
		{
		}

		public void RemoveRange(IEnumerable<T> elements)
		{
		}

		public void SetItem(int index, T value)
		{
		}

		public void SetItem(T value, Predicate<T> predicate)
		{
		}

		public void SetValue(IEnumerable<T> elements)
		{
		}

		public void SetSize(int size)
		{
		}

		public bool Contains(T element)
		{
			return false;
		}

		public override List<T> GetCopy(List<T> other)
		{
			return null;
		}

		public void Shuffle()
		{
		}

		public void Shuffle(Random random)
		{
		}

		public void Shuffle(int seed)
		{
		}

		public abstract T GetItemCopy(T item);

		public object Clone()
		{
			return null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
