using Crescive.ResourceSystem;
using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.Text.DataBinder.HeartLimitBridge
{
	[CreateAssetMenu(fileName = "GoldenTicketHeartLimitProperty", menuName = "Crescive/Scriptables/Property/Heart/Golden Ticket Heart Limit Property")]
	public class GoldenTicketHeartLimitProperty : IntScriptableProperty
	{
		[Header("References")]
		[SerializeField]
		private ResourceGeneratorDataService heartGeneratorDataServiceGoldenTicket;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
