using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class TournamentsSettings : ICloneable
{
	public int ActiveTournamentId;

	public List<TournamentSettings> TournamentsSettingsList;

	private List<int> TournamentsIds => null;

	public bool HasTournament(int id)
	{
		return false;
	}

	[SpecialName]
	private List<int> GetTournamentsIds()
	{
		return null;
	}

	public object Clone()
	{
		return null;
	}

	public TournamentSettings FindTournamentById(int id)
	{
		return null;
	}

	public bool IsTournamentValid(int id)
	{
		return false;
	}

	public TournamentSettings GetAvailableTournament(int id)
	{
		return null;
	}

	public TournamentSettings GetTournament(int id)
	{
		return null;
	}

	public TournamentsSettings()
	{
	}

	public TournamentsSettings(TournamentsSettings other)
	{
	}

	public TournamentsSettings(List<TournamentSettings> tournamentsSettingsList)
	{
	}

	public List<TournamentSettings> GetAllActiveTournaments()
	{
		return null;
	}
}
