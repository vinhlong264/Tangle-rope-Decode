using System.Collections.Generic;
using UnityEngine;

public abstract class CresciveEventSendDestination : ScriptableObject
{
	public abstract void SendEvent(string eventType, int level, Dictionary<string, object> args);
}
