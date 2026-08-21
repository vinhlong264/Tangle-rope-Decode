using Crescive.LocalNotifications;
using UnityEngine;

public class TestDispatcher : MonoBehaviour
{
	[SerializeField]
	private BasicLocalNotificationDispatcher lowRankDispatcher;

	[SerializeField]
	private BasicLocalNotificationDispatcher highRankDispatcher;

	public void PostHighRankDispatcher()
	{
	}

	public void PostLowRankDispatcher()
	{
	}
}
