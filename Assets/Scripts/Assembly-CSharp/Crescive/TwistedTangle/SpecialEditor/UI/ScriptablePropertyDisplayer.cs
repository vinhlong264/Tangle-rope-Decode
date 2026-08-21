using Crescive.Scriptables;
using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class ScriptablePropertyDisplayer : MonoBehaviour
	{
		[SerializeField]
		private BaseScriptableProperty scriptableProperty;

		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private string prefix;

		[SerializeField]
		private string suffix;

		private void OnEnable()
		{
		}

		public void SetText()
		{
		}
	}
}
