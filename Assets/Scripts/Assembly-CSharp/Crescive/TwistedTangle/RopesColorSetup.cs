using System;
using System.Collections.Generic;
using Crescive.ColorUtils;
using Crescive.Utils;
using CresciveCore;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(100)]
	public class RopesColorSetup : MonoBehaviour
	{
		[SerializeField]
		private bool useLevelNumberSeed;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private ColorListData colorListData;

		[SerializeField]
		private NearColorsListData nearColorsData;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private bool updateOnChannelDataChanged;

		[SerializeField]
		private BoolVariable useNearColors;

		[SerializeField]
		private BoolVariable useCustomNearColors;

		[SerializeField]
		private ColorValueList customNearColorList;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RopeColorChanged(Color obj)
		{
		}

		private void OnRopeAdd(RopeEntity ropeEntity)
		{
		}

		private void SetupRandomColors(bool forceRandom = false)
		{
		}

		private void SetupNearColors(bool forceRandom = false)
		{
		}

		private void SetupRopesColors(List<Color> colors)
		{
		}

		private List<Color> GetRandomNearColors(bool forceRandom)
		{
			return null;
		}

		private List<Color> GetRandomColors(bool forceRandom)
		{
			return null;
		}

		private System.Random GetRandom(bool forceRandom = false)
		{
			return null;
		}

		public void Setup(bool forceRandom = false)
		{
		}

		public void SetUseNearColors(bool active)
		{
		}

		public void SetUseNearColorsForceRandom(bool active)
		{
		}

		public void SetUseCustomNearColorsForceRandom(bool active)
		{
		}
	}
}
