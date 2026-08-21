using System.Collections.Generic;
using Crescive.Navigation;
using UnityEngine;
using UnityEngine.UI;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeUI : MonoBehaviour
	{
		[SerializeField]
		private GameObject main;

		[SerializeField]
		private Navigatable dynamicQuestTimeNavigatable;

		[SerializeField]
		private DynamicQuestTimeRewardRow dynamicQuestTimeRewardRow;

		[SerializeField]
		private RectTransform rewardRowParent;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button infoButton;

		private List<DynamicQuestTimeRewardRow> items;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnUpdateDynamicQuestTimeUI(DynamicQuestTimeEvents.OnUpdateDynamicQuestTimeUI p)
		{
		}

		private void OnOpenDynamicQuestTimeUI(DynamicQuestTimeEvents.OnOpenDynamicQuestTimeUI p)
		{
		}

		private void OnCloseDynamicQuestTimeUI(DynamicQuestTimeEvents.OnCloseDynamicQuestTimeUI p)
		{
		}

		public void CreateUI()
		{
		}

		private void OnInfoButtonClicked()
		{
		}

		public void OpenUI()
		{
		}

		private void SetContentPosition(int index)
		{
		}

		public void CloseUI()
		{
		}

		private void UpdateUI()
		{
		}
	}
}
