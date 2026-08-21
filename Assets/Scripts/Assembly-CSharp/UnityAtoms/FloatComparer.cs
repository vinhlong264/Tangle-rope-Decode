using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
	public class FloatComparer : MonoBehaviour
	{
		[SerializeField]
		private FloatReference valueToCompare;

		[SerializeField]
		private float equalityTolerance;

		public UnityEvent OnGreater;

		public UnityEvent OnLess;

		public UnityEvent OnEqual;

		public void Compare(float value)
		{
		}

		public void Compare(int value)
		{
		}
	}
}
