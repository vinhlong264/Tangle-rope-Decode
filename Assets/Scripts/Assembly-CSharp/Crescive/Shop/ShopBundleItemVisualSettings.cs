using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "ShopBundleItemVisualSettings", menuName = "Crescive/Shop/UI/Bundle/ShopBundleItemVisualSettings")]
	public class ShopBundleItemVisualSettings : ScriptableObject
	{
		[SerializeField]
		[Header("Visuals")]
		private Sprite backgroundSprite;

		[SerializeField]
		private Color backgroundGlowColor;

		[Header("Settings")]
		[SerializeField]
		private bool useBackgroundGlow;

		[SerializeField]
		private bool useEdgeGlow;

		[SerializeField]
		private bool useBonus;

		[SerializeField]
		private bool useStarParticles;

		[SerializeField]
		private bool useShiny;

		public Sprite BackgroundSprite => null;

		public Color BackgroundGlowColor => default(Color);

		public bool UseBackgroundGlow => false;

		public bool UseEdgeGlow => false;

		public bool UseBonus => false;

		public bool UseStarParticles => false;

		public bool UseShiny => false;
	}
}
