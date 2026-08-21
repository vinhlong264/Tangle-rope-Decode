using Crescive.UI;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeProgressBar : MonoBehaviour
	{
		[SerializeField]
		private ItemDisplayer itemDisplayer;

		[SerializeField]
		private bool isManuelUpdate;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private TextMeshProUGUI progressText;

		[SerializeField]
		private Canvas overrideCanvas;

		[SerializeField]
		private TextMeshProUGUI infoText;

		[SerializeField]
		private Popover popover;

		[SerializeField]
		private RectTransform token;

		private int lastRewardIndex;

		private int lastProgress;

		private int lastMaxToken;

		private Tween tween;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDynamicQuestTimeProgressAddStarted(DynamicQuestTimeEvents.OnDynamicQuestTimeProgressAddStarted p)
		{
		}

		private void OnDynamicQuestTimeTutorialStarted(DynamicQuestTimeEvents.OnDynamicQuestTimeTutorialStarted p)
		{
		}

		private void OnDynamicQuestTimeTutorialEnded(DynamicQuestTimeEvents.OnDynamicQuestTimeTutorialEnded p)
		{
		}

		private void OnDynamicQuestTimeProgressUpdated(DynamicQuestTimeEvents.OnDynamicQuestTimeProgressUpdated p)
		{
		}

		private void OnEnable()
		{
		}

		public void AnimateUpdateUI()
		{
		}

		private void AnimateBar(DynamicQuestTimeRemote remote, int progress, int currentRewardIndex, int currentToken)
		{
		}

		private float GetDuration(float startValue, float endValue)
		{
			return 0f;
		}

		private void UpdateUI()
		{
		}

		private void DisplayItem(DynamicQuestTimeRemote remote, int progress, int currentRewardIndex, int currentToken)
		{
		}
	}
}
