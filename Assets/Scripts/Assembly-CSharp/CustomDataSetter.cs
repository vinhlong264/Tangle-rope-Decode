using Crescive.LiveEvents.BattlePass;
using Crescive.ResourceSystem;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class CustomDataSetter : MonoBehaviour
{
	public PersistentIntVariable CurrentLevelNumber;

	public PersistentIntVariable HighestLevelNumber;

	public PersistentIntVariable CurrentLevelNumberOrdered;

	public PersistentIntVariable LevelSyncIntergrationsLevelNumber;

	public ResourceChannel Coin;

	public ResourceChannel SkipTicket;

	public ResourceChannel CutBooster;

	public ResourceChannel TimeFreezeBooster;

	public ResourceChannel ShuffleBooster;

	public ResourceChannel Heart;

	public BattlePassSystem battlePassSystem;

	public VoidEvent LoadedSceneReady;

	public void SetLevel(int value)
	{
	}

	public int GetLevel()
	{
		return 0;
	}

	public void SetCoin(float value)
	{
	}

	public float GetCoin()
	{
		return 0f;
	}

	public bool GetBattlePassGoldenTicketPurchased()
	{
		return false;
	}

	public void SetBattlePassGoldenTicketPurchased(bool value)
	{
	}

	public void SetSkipTicket(float value)
	{
	}

	public float GetSkipTicket()
	{
		return 0f;
	}

	public void SetCutBooster(float value)
	{
	}

	public float GetCutBooster()
	{
		return 0f;
	}

	public void SetTimeFreezeBooster(float value)
	{
	}

	public float GetTimeFreezeBooster()
	{
		return 0f;
	}

	public void SetShuffleBooster(float value)
	{
	}

	public float GetShuffleBooster()
	{
		return 0f;
	}

	public void SetHeart(float value)
	{
	}

	public float GetHeart()
	{
		return 0f;
	}
}
