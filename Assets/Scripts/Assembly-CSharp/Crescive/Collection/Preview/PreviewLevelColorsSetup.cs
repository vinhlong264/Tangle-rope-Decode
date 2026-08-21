using System;
using System.Collections.Generic;
using Crescive.ColorUtils;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.Collection.Preview
{
	[DefaultExecutionOrder(100)]
	public class PreviewLevelColorsSetup : MonoBehaviour
	{
		[SerializeField]
		private ColorListData colorListData;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private bool updateOnChannelDataChanged;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRopeAdd(RopeEntity ropeEntity)
		{
		}

		private void SetupRandomColors()
		{
		}

		private void SetupRopesColors(List<Color> colors)
		{
		}

		private List<Color> GetRandomColors()
		{
			return null;
		}

		private System.Random GetRandom()
		{
			return null;
		}

		public void Setup()
		{
		}
	}
}
