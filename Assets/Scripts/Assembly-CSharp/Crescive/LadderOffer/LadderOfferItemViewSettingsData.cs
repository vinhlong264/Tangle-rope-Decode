using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOfferItemViewSettingsData
	{
		[Serializable]
		public class BackgroundData
		{
			public Sprite ItemBackground;

			public Sprite ContentBackground;
		}

		public List<BackgroundData> Backgrounds;

		public BackgroundData LastBackground;
	}
}
