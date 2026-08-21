using System;
using System.Collections.Generic;

namespace Crescive.Ranking
{
	[Serializable]
	public class FakeRankCountryUsers
	{
		public string countryCode;

		public List<FakeRankUser> users;
	}
}
