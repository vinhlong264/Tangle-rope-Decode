using System.Collections.Generic;
using ElephantSocial.Model;
using UnityEngine;

public class LadderView : MonoBehaviour
{
	[SerializeField]
	[Header("UI")]
	private List<PlayerLadderCardController> playerLadderCards;

	[SerializeField]
	private List<PlayerLadderBadgeController> playerLadderBadges;

	private const int Podium = 3;

	public int FindMyRank(CachedBoard b)
	{
		return 0;
	}

	public bool IsPodiumChange(int oldRank, int newRank)
	{
		return false;
	}

	public void FullRefresh(CachedBoard board)
	{
	}

	private static bool SyncSelfAvatar(BoardPlayer r, Player me)
	{
		return false;
	}

	public bool TryGetControllerForRank(int rank, out PlayerLadderBadgeController badge, out PlayerLadderCardController card, out int visualIndex)
	{
		badge = null;
		card = null;
		visualIndex = default(int);
		return false;
	}
}
