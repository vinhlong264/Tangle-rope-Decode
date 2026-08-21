using Crescive.PersistentSO;
using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class DropdownPersistentDisplayer : MonoBehaviour
	{
		[SerializeField]
		private TMP_InputField displayText;

		[SerializeField]
		private PersistentSystem persistentSystem;

		public void DisplaySelectedText(string key)
		{
		}
	}
}
