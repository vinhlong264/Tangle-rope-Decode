using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "CountriesData", menuName = "Crescive/UI/CountriesData", order = 0)]
	public class CountriesData : ScriptableObject
	{
		[Serializable]
		public struct CountryData
		{
			public string countryCode;

			public Sprite countryImage;
		}

		[SerializeField]
		private List<CountryData> countryDataList;

		public CountryData GetCountryData(string countryCode)
		{
			return default(CountryData);
		}
	}
}
