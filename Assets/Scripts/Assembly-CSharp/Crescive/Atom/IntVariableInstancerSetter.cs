using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Atom
{
	public class IntVariableInstancerSetter : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private IntVariableInstancer variableInstancer;

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Set(int value)
		{
		}

		public void Set(IntVariableInstancer variableInstancer)
		{
		}

		public void Add(int value)
		{
		}

		public void Add(AtomBaseVariable<int> variable)
		{
		}

		public void Set(PersistentIntVariable persistentVariable)
		{
		}

		public void Set(IntScriptableProperty scriptableProperty)
		{
		}

		public void Subtract(int value)
		{
		}

		public void Subtract(AtomBaseVariable<int> variable)
		{
		}

		public void MultiplyBy(int value)
		{
		}

		public void MultiplyBy(AtomBaseVariable<int> variable)
		{
		}

		public void DivideBy(int value)
		{
		}

		public void DivideBy(AtomBaseVariable<int> variable)
		{
		}
	}
}
