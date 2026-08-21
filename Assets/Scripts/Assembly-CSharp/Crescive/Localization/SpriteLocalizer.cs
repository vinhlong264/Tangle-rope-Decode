using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

namespace Crescive.Localization
{
	public abstract class SpriteLocalizer : AssetLocalizer<Sprite, LocalizedSprite>
	{
		protected override string DefaultDynamicKeyTableName => null;

		protected override List<string> DynamicKeyTableNames => null;
	}
}
