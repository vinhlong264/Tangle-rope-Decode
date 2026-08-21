using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ElephantEventSendDestinationIntegration", menuName = "Crescive/Integrations/Events/ElephantEventSendDestination")]
public class ElephantEventSendDestinationIntegration : CresciveEventSendDestination
{
	public const string CustomDataKey = "customData";

	public override void SendEvent(string eventType, int level, Dictionary<string, object> args)
	{
	}
}
