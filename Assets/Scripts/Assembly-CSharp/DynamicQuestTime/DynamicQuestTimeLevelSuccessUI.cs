using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeLevelSuccessUI : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI countText;

		[SerializeField]
		private TextMeshProUGUI timeText;

		[SerializeField]
		private GameObject timeTokenContent;

		[SerializeField]
		private GameObject emojiContent;

		[SerializeField]
		private IntVariable timeLimitDesync;

		public void OnWin()
		{
		}
	}
}
