using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "CresciveEventSender", menuName = "Crescive/Event/CresciveEventSender")]
public class CresciveEventSender : ScriptableObject
{
	[Header("Events")]
	public UnityEvent<string, Dictionary<string, object>> OnSendEvent;

	public void SendEvent(string eventType, Dictionary<string, object> args = null)
	{
	}
}
