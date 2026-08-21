using System.Collections.Generic;
using Crescive.GameStates;
using Crescive.LocalNotifications;
using UnityEngine;

public abstract class BaseDispatcher : MonoBehaviour
{
	[SerializeField]
	private int notificationServiceIndex;

	[SerializeField]
	private LocalNotificationSettingsService localNotificationsService;

	[SerializeField]
	private LocalNotificationChannel channel;

	[SerializeField]
	private string ID_KEY;

	[SerializeField]
	private int remainedMinutesBeforeDeletion;

	[SerializeField]
	private GameStateEvents gameStateEvents;

	[SerializeField]
	private PersistentNotificationInfoList persistentNotificationInfoList;

	protected int startHour;

	protected int endHour;

	protected List<LanguageTextPair> languageTextPairList;

	private int systemLanguageIndex;

	private string systemLanguage;

	private bool IsEnabled => false;

	private void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	private void InitializeData()
	{
	}

	private void DeleteNotiIfDateIsDue()
	{
	}

	protected List<string> GetLanguages()
	{
		return null;
	}

	protected List<string> GetHeadings()
	{
		return null;
	}

	protected List<string> GetContents()
	{
		return null;
	}

	protected string GetLanguage()
	{
		return null;
	}

	protected string GetHeadingsSystemLanguage()
	{
		return null;
	}

	protected string GetContentsSystemLanguage()
	{
		return null;
	}

	private int GetSystemLanguageIndex()
	{
		return 0;
	}

	private string GetSystemLanguage()
	{
		return null;
	}

	protected virtual double ActualDelay()
	{
		return 0.0;
	}

	public virtual void SendNotification()
	{
	}

	public void SendNotificationWithDelayInSeconds(double delayInSeconds)
	{
	}

	public virtual void DeleteNotification()
	{
	}
}
