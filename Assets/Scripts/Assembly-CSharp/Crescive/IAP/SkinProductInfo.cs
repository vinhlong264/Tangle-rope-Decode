using System;
using PersistentSO;
using UnityEngine;

namespace Crescive.IAP
{
	[Serializable]
	public class SkinProductInfo
	{
		[field: SerializeField]
		public string ProductPackId { get; private set; }

		[field: SerializeField]
		public PersistentStringListVariable UnlockSkins { get; private set; }
	}
}
