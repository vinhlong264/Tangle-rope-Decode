using Crescive.CloudSync;
using Crescive.GameStates;
using UnityEngine;

[DefaultExecutionOrder(int.MinValue)]
public class ElephantSaveSystemManager : MonoBehaviour
{
	public static ElephantSaveSystemManager Instance;

	public static ElephantStorageSaveData StorageSaveData;

	public iOSKeyChainSync iOSKeyChainSync;

	public GameStateEvents gameStateEvents;

	public CustomDataSetter CustomDataSetter;

	internal bool isStopSaving;

	public bool isFirstSession;

	private bool isSaveWaiting;

	public bool IsFirstTimeDataMigration
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Initialize(iOSKeyChainSync iOSKeyChainSync, bool dontReturn = false)
	{
	}

	private void Update()
	{
	}

	public void SaveStorage()
	{
	}

	public void SaveInstant()
	{
	}

	public void TrySaveInstant()
	{
	}
}
