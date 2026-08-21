using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Localization
{
	public class ImageSpriteLocalizer : SpriteLocalizer
	{
		[SerializeField]
		private Image image;

		protected override void OnAssetChangedInternal(Sprite value)
		{
		}
	}
}
