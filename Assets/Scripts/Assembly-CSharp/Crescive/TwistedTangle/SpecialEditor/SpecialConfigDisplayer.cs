using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class SpecialConfigDisplayer : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI displayText;

		[SerializeField]
		private SpecialRemoteConfigGetter specialRemoteConfigGetter;

		[SerializeField]
		private bool listShouldBeExcluded;

		[SerializeField]
		private List<string> keysList;

		public void DisplayTextList()
		{
		}

		public void DisplaySelectedText(string key)
		{
		}

		public void CopyTextToGUI()
		{
		}
	}
}
