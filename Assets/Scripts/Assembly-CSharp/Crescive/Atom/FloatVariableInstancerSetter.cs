using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Atom
{
	public class FloatVariableInstancerSetter : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private FloatVariableInstancer variableInstancer;

		public float Value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void Set(float value)
		{
		}

		public void Set(PersistentFloatVariable persistentVariable)
		{
		}

		public void Set(PersistentIntVariable persistentVariable)
		{
		}

		public void Set(FloatScriptableProperty scriptableProperty)
		{
		}

		public void Set(IntScriptableProperty scriptableProperty)
		{
		}

		public void Add(float value)
		{
		}

		public void Add(AtomBaseVariable<float> variable)
		{
		}

		public void Subtract(float value)
		{
		}

		public void Subtract(AtomBaseVariable<float> variable)
		{
		}

		public void MultiplyBy(float value)
		{
		}

		public void MultiplyBy(AtomBaseVariable<float> variable)
		{
		}

		public void DivideBy(float value)
		{
		}

		public void DivideBy(AtomBaseVariable<float> variable)
		{
		}
	}
}
