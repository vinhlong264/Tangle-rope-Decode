using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Economics
{
	[CreateAssetMenu(fileName = "LevelCurrencyProviderData", menuName = "GameData/Coin/Level Coin Provider Data")]
	public class LevelCoinProviderData : ScriptableObject
	{
		[SerializeField]
		private IntVariableReference externalEarnSource;

		public float GetCurrentLevelEarnCoin()
		{
			return 0f;
		}
	}
}
