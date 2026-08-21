using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class DiscoPremiumRopeController : BaseRopeModelActor
	{
		[SerializeField]
		private Material premiumMaterial;

		[SerializeField]
		private float scrollAmountPerInterval;

		[SerializeField]
		private float scrollInterval;

		private static readonly int BaseMap;

		private static readonly int EmissionMap;

		protected override void OnDisable()
		{
		}

		protected override void OnInitialized()
		{
		}

		protected override void OnColorUpdated(Color color)
		{
		}
	}
}
