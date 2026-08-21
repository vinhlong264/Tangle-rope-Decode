using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "SkinsProductSettings", menuName = "Crescive/Shop/Resolvers/Skins/Skins Product Settings")]
	public class SkinsProductSettings : ScriptableObject
	{
		[field: SerializeField]
		public List<SkinProductInfo> SkinProductInfos { get; private set; }

		public SkinProductInfo GetSkinProductInfo(string packId)
		{
			return null;
		}
	}
}
