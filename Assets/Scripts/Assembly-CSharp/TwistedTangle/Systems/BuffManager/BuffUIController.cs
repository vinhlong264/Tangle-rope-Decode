using TMPro;
using UnityEngine;

namespace TwistedTangle.Systems.BuffManager
{
	public class BuffUIController : MonoBehaviour
	{
		[Header("Configuration")]
		[Tooltip("The type of buff to monitor")]
		public BuffType buffType;

		[Tooltip("GameObject to activate when buff is active")]
		[Header("References")]
		public GameObject[] targetObjects;

		public TextMeshProUGUI textComponent;

		public TextMeshProUGUI detailText;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateBuffStatus()
		{
		}

		private void UpdateRemainingTimeText(float remainingMinutes)
		{
		}
	}
}
