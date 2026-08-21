using System;
using System.Collections.Generic;
using ElephantSocial.Model;

[Serializable]
public class CachedBoard
{
	public int tournamentId;

	public List<BoardPlayer> players;

	public long remainingSeconds;

	public bool isRunning;

	public DateTime fetchedAtUtc;

	public CachedBoard()
	{
	}

	public CachedBoard(CachedBoard b)
	{
	}
}
