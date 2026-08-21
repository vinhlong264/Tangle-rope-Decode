using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeRewardRow : MonoBehaviour
	{
		[SerializeField]
		private ItemDisplayer itemDisplayer;

		[SerializeField]
		private GameObject tickIcon;

		[SerializeField]
		private GameObject filterIcon;

		[SerializeField]
		private GameObject lockIcon;

		[SerializeField]
		private Image fillLine;

		[SerializeField]
		private Image fillPin;

		[SerializeField]
		private TextMeshProUGUI rewardNumber;

		[SerializeField]
		private GameObject rewardShine;

		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject tempBG;

		private bool isReached;

		private float fillAmount;

		private bool isClaimed;

		private ItemData itemData;

		internal void SetData(ItemData itemData, int i, bool isTempBgOpen)
		{
		}

		internal void UpdateData(bool isReached, float fillAmount, bool isClaimed)
		{
		}

		private void OnClicked()
		{
		}
	}
}
