using Crescive.Scriptables;
using PersistentSO;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace TwistedTangle.SpecialEditor
{
	public class PersistentDisplayer : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private BasePersistentVariable[] persistentVariableNoIndent;

		[SerializeField]
		private BasePersistentVariable[] persistentVariableIndented;

		[SerializeField]
		private BoolVariable[] boolVariables;

		[SerializeField]
		private BaseScriptableProperty[] scriptableProperties;

		private void DisplayVariable()
		{
		}

		private void OnEnable()
		{
		}
	}
}
