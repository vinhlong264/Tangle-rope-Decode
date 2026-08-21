using System.Collections.Generic;
using CresciveCore;
using UnityEngine;

public class CresciveEventManager : MonoBehaviour
{
	[SerializeField]
	[Header("References")]
	private CresciveEventSender eventSender;

	[SerializeField]
	private CresciveEventSendDestination eventSendDestination;

	[SerializeField]
	private LevelSystem levelSystem;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSendEvent(string eventType, Dictionary<string, object> args)
	{
	}
}
