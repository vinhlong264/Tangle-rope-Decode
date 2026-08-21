using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	[CreateAssetMenu(fileName = "RopesEmissionTextureSetter", menuName = "Special Editor/Texture Setters/Ropes Emission Texture Setter")]
	public class RopesEmissionTextureSetter : ScriptableObject
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private TextureHolder textureHolder;

		public void ActivateMaterialsEmission()
		{
		}

		public void DeactivateMaterialsEmission()
		{
		}

		public void SetRopesEmissionTextures()
		{
		}

		public void SetEmissionMapTilingX(float tilingX)
		{
		}

		public void SetEmissionMapTilingY(float tilingY)
		{
		}

		public void SetEmissionMapOffsetX(float offsetX)
		{
		}

		public void SetEmissionMapOffsetY(float offsetY)
		{
		}
	}
}
