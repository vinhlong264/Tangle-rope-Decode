using System.ComponentModel;

public class TwistedSrOptions : SROptions
{
	[Category("Tangle Pass")]
	[DisplayName("Tangle Token Amount")]
	public int TangleTokenAmount { get; set; }

	[Category("Tournament")]
	[DisplayName("Tournament")]
	public int TournamentScore { get; set; }

	[Category("Plinko")]
	public float MinStartForce
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float MaxStartForce
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float ObstaclePushPlusPower
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float PusherPushPlusPower
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float BallBounciness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float BallFriction
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float MinStartOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float MaxStartOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float BallMaxVelocityMagnitude
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public float BallGravityScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Plinko")]
	public int PlinkoCurrencyAmount { get; set; }

	[Category("Plinko")]
	public int PlinkoBallAmount { get; set; }

	[Category("Daily Rewards")]
	public void OnPass1DayClicked()
	{
	}

	[Category("Daily Rewards")]
	public void OnPass2DayClicked()
	{
	}

	[Category("Daily Rewards")]
	public void Add7MonthlyProgression()
	{
	}

	[Category("Daily Rewards")]
	public void OnResetAllClicked()
	{
	}

	[Category("Segmented Offers")]
	public void ResetMySegment()
	{
	}

	[Category("Tangle Pass")]
	public void TanglePass()
	{
	}

	[Category("Tangle Pass")]
	public void AddScoreToTournament()
	{
	}

	[Category("Clear Result")]
	public void ClearResult()
	{
	}

	[Category("Plinko")]
	public void AddPlinkoCurrency()
	{
	}

	[Category("Plinko")]
	public void AddPlinkoBall()
	{
	}
}
