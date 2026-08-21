using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	[CreateAssetMenu(fileName = "RopesBaseTextureSetter", menuName = "Special Editor/Texture Setters/Ropes Base Texture Setter")]
	public class RopesBaseTextureSetter : ScriptableObject
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private TextureHolder textureHolder;

		public void SetRopesMainTextures()
		{
		}

		public void SetBaseMapTilingX(float tilingX)
		{
		}

		public void SetBaseMapTilingY(float tilingY)
		{
		}

		public void SetBaseMapOffsetX(float offsetX)
		{
		}

		public void SetBaseMapOffsetY(float offsetY)
		{
		}
	}
}
