using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "ColorListData", menuName = "GameData/ListData/NearColorsListData", order = 1)]
	public class NearColorsListData : ScriptableObject
	{
		[field: SerializeField]
		public List<NearColorData> ColorListData { get; private set; }

		public NearColorData GetColorData(int index)
		{
			return default(NearColorData);
		}

		public NearColorData GetColorDataByOrder(int order)
		{
			return default(NearColorData);
		}

		public NearColorData GetRandomColorData()
		{
			return default(NearColorData);
		}

		public NearColorData GetRandomColorData(System.Random random)
		{
			return default(NearColorData);
		}

		public List<Color> GetRandomColors(System.Random random)
		{
			return null;
		}
	}
}
