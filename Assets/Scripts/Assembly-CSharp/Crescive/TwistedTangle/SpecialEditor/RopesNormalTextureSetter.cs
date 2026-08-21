using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	[CreateAssetMenu(fileName = "RopesNormalTextureSetter", menuName = "Special Editor/Texture Setters/Ropes Normal Texture Setter")]
	public class RopesNormalTextureSetter : ScriptableObject
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private TextureHolder textureHolder;

		public void ActivateMaterialsNormal()
		{
		}

		public void DeactivateMaterialsNormal()
		{
		}

		public void SetRopesNormalTextures()
		{
		}

		public void SetNormalMapTilingX(float tilingX)
		{
		}

		public void SetNormalMapTilingY(float tilingY)
		{
		}

		public void SetNormalMapOffsetX(float offsetX)
		{
		}

		public void SetNormalMapOffsetY(float offsetY)
		{
		}
	}
}
