using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Atom
{
	[DefaultExecutionOrder(1)]
	public class StringVariableInstancerSetter : MonoBehaviour
	{
		[SerializeField]
		private StringVariableInstancer variableInstancer;

		[SerializeField]
		private StringVariableReference valueToSet;

		[Space]
		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void Set(string value)
		{
		}
	}
}
