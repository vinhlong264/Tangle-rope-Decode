using System;
using System.Collections.Generic;

[Serializable]
public class TournamentSettings : ICloneable
{
	public int Id;

	public bool isActive;

	public int showLevelLimit;

	public List<TournamentPrize> tournamentPrizeList;

	public virtual bool ValidateConfig(object obj)
	{
		return false;
	}

	public virtual bool ValidateObject(object obj)
	{
		return false;
	}

	public virtual bool IsValid(object obj)
	{
		return false;
	}

	public TournamentSettings(TournamentSettings? other)
	{
	}

	public object Clone()
	{
		return null;
	}

	public override bool Equals(object? obj)
	{
		return false;
	}

	protected bool Equals(TournamentSettings? other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
