using UnityAtoms.BaseAtoms;
using UnityEngine.Events;

namespace Crescive.Atom.VariableListener
{
	public class BoolVariableListener : AtomVariableListener<BoolVariable, BoolVariableInstancer, bool, BoolPair, BoolEvent, BoolPairEvent, BoolBoolFunction>
	{
		public UnityEvent<bool> OnValueChangedReverse;

		public UnityEvent OnTrue;

		public UnityEvent OnFalse;

		protected override void OnValueChangedCallbackInternal(bool value)
		{
		}
	}
}
