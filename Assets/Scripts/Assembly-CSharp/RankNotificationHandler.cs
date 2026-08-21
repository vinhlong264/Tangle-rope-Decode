using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.League;
using Crescive.LocalNotifications;
using Crescive.Ranking;
using UnityEngine;

public class RankNotificationHandler : MonoBehaviour
{
	[SerializeField]
	private PersistentRankingEntries persistentRankingEntries;

	[SerializeField]
	private BasicLocalNotificationDispatcher lowRankNotificationDispatcher;

	[SerializeField]
	private BasicLocalNotificationDispatcher highRankNotificationDispatcher;

	[SerializeField]
	private BasicLocalNotificationDispatcher leagueEndNotificationDispatcher;

	[SerializeField]
	private LeagueRankingConfig leagueRankingConfig;

	[SerializeField]
	private BoolVariableReference isEnteredLeague;

	[SerializeField]
	private int checkIntervalHourCount;

	[SerializeField]
	private int maxCheckHourCount;

	[SerializeField]
	private LocalNotificationSettingsService localNotificationSettingsService;

	[SerializeField]
	private PersistentLiveLeagueData liveLeagueData;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SetNotificationsBasedOnCurrentRanking(List<RankingEntryData> arg0)
	{
	}

	private void ScheduleHighRankDate()
	{
	}

	private void ScheduleLowRankDate()
	{
	}

	private DateTime GetHighDate()
	{
		return default(DateTime);
	}

	private DateTime GetLowDate()
	{
		return default(DateTime);
	}

	private void ScheduleLeagueEndNotification()
	{
	}
}
