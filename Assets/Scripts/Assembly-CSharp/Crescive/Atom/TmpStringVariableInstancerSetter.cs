using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Atom
{
	[DefaultExecutionOrder(1)]
	public class TmpStringVariableInstancerSetter : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text tmp;

		[SerializeField]
		private StringVariableInstancer variableInstancer;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnVariableChanged(string value)
		{
		}

		public void SetValueToTMP()
		{
		}
	}
}
