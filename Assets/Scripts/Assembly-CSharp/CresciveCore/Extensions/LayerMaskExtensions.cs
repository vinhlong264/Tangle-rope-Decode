using UnityEngine;

namespace CresciveCore.Extensions
{
	public static class LayerMaskExtensions
	{
		public static LayerMask ToLayerMask(int layer)
		{
			return default(LayerMask);
		}

		public static bool IsLayerInMask(this LayerMask mask, int layer)
		{
			return false;
		}
	}
}
