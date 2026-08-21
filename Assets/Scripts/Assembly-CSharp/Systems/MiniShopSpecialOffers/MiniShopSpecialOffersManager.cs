using CresciveCore;
using UnityEngine;

namespace Systems.MiniShopSpecialOffers
{
	[DefaultExecutionOrder(int.MinValue)]
	public class MiniShopSpecialOffersManager : MonoBehaviour
	{
		public static MiniShopSpecialOffersManager Instance;

		private MiniShopSpecialOffersData miniShopSpecialOffersData;

		private MiniShopSpecialOffersRemote miniShopSpecialOffersRemote;

		[SerializeField]
		private LevelSystem levelSystem;

		public bool IsAlive;

		public static MiniShopSpecialOffersData MiniShopSpecialOffersData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MiniShopSpecialOffersRemote MiniShopSpecialOffersRemote => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnMiniShopOffersTimeExpired()
		{
		}

		private void OnReturnedHome(GameEvents.OnReturnedHome p)
		{
		}

		private void CheckMiniShopOffers()
		{
		}
	}
}
