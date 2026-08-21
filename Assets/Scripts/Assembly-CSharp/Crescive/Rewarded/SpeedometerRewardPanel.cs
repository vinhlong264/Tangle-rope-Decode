using System;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Rewarded
{
	public class SpeedometerRewardPanel : MonoBehaviour
	{
		[Serializable]
		private struct SpeedoMeterItemData
		{
			public SpeedoMeterItem item;

			public float startAngle;

			public float endAngle;
		}

		[Serializable]
		private struct SpeedoMeterFactorData
		{
			public List<SpeedoMeterItem> items;
		}

		[SerializeField]
		private Transform indicator;

		[SerializeField]
		private FloatReference collectedCoins;

		[SerializeField]
		private FloatReference multiplier;

		[SerializeField]
		private List<SpeedoMeterItemData> items;

		[SerializeField]
		private RewardedCoinButton rewardCoinButton;

		[SerializeField]
		[Header("Factor Rank")]
		private SpeedometerSettingsDataReadService speedometerSettingsDataReadService;

		[SerializeField]
		private List<SpeedoMeterFactorData> factorsData;

		private SpeedoMeterItem activeItem;

		public SpeedoMeterItem ActiveItem => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetupFactorItems()
		{
		}

		private void HandleCoinMultiplicator()
		{
		}

		private float CalculateIndicatorRot()
		{
			return 0f;
		}

		private SpeedoMeterItem GetCurrentItem(float zAngle)
		{
			return null;
		}

		private void SetActiveStateOfItems(SpeedoMeterItem activeItem)
		{
		}
	}
}
