using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "FakeRankUserList", menuName = "Crescive/Ranking/FakeRankUserList", order = 0)]
	public class FakeRankUserList : ScriptableObject
	{
		[SerializeField]
		private List<FakeRankCountryUsers> fakeCountryUsers;

		public List<FakeRankCountryUsers> FakeCountryUsers => null;

		public List<FakeRankUser> AllFakeUsers => null;

		public List<FakeRankUser> GetRandomFakeUsers(int count)
		{
			return null;
		}

		public string GetFakeUserCountryCode(FakeRankUser user)
		{
			return null;
		}
	}
}
