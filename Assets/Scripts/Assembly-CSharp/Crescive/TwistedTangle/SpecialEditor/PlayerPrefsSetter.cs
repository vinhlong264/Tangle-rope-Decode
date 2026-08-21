using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PlayerPrefsSetter : MonoBehaviour
	{
		[SerializeField]
		private PlayerPrefType playerPrefType;

		[SerializeField]
		private string key;

		[SerializeField]
		private int intValue;

		[SerializeField]
		private float floatValue;

		[SerializeField]
		private string stringValue;

		public UnityEvent OnValueChanged;

		public void SetPlayerPref()
		{
		}

		public void SetPlayerPrefInt(int value)
		{
		}

		public void SetPlayerPrefFloat(float value)
		{
		}

		public void SetPlayerPrefString(string value)
		{
		}
	}
}
