using Crescive.Scriptables;
using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ScriptableIntPropertyDisplayer : MonoBehaviour
	{
		[SerializeField]
		private string prefix;

		[SerializeField]
		private string suffix;

		[SerializeField]
		private ScriptableProperty<int> intProperty;

		[SerializeField]
		private TextMeshProUGUI displayText;

		private void OnEnable()
		{
		}

		private void SetText()
		{
		}
	}
}
