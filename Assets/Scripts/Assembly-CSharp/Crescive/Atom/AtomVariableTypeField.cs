using System;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Atom
{
	[Serializable]
	public abstract class AtomVariableTypeField<V, VI, T, P, E1, E2, F> where V : AtomVariable<T, P, E1, E2, F> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where P : struct, IPair<T> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T>
	{
		[SerializeField]
		private AtomVariableType variableType;

		[SerializeField]
		private V variable;

		[SerializeField]
		private VI variableInstancer;

		private bool ShowVariable => false;

		private bool ShowVariableInstancer => false;

		public V Variable => null;

		public T Value => default(T);

		public E1 Changed => null;

		public E2 ChangedWithHistory => null;
	}
}
