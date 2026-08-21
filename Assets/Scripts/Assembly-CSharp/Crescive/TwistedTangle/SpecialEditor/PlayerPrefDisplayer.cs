using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PlayerPrefDisplayer : MonoBehaviour
	{
		[SerializeField]
		private PlayerPrefType playerPrefType;

		[SerializeField]
		private string key;

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
