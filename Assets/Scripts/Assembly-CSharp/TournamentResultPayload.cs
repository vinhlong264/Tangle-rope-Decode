using System;
using ElephantSocial.Tournament;

public sealed class TournamentResultPayload
{
	public TournamentResult Result;

	public CachedBoard Board;

	public DateTime StartUtc;

	public DateTime EndUtc;
}
