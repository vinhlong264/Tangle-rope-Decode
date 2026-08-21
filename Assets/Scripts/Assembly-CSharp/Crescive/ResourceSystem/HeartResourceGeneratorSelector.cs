using System;
using System.Runtime.CompilerServices;
using Crescive.LiveEvents.BattlePass;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	public class HeartResourceGeneratorSelector : ResourceGeneratorDataProviderWrapper
	{
		[SerializeField]
		private ResourceGeneratorDataService basic;

		[SerializeField]
		private ResourceGeneratorDataService battlePass;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		public override event Action Changed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnBattlePassChanged(BattlePassData _)
		{
		}

		public override ResourceGeneratorData GetData()
		{
			return null;
		}

		public override void GetSync()
		{
		}
	}
}
