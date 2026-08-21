using System;
using UnityEngine;

public class AnalyticsReporter : MonoBehaviour
{
	public void ReportOpened(int tid)
	{
	}

	public void ReportRankDelta(int tid, int prevPos, int curPos)
	{
	}

	public void ReportFinished(int tid, DateTime startUtc, DateTime endUtc, int levelPlayed, int finalPos)
	{
	}

	public void ReportClaim(int tid, int finalPos)
	{
	}
}
