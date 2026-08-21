using System.Runtime.InteropServices;

namespace Plinko
{
	public class PlinkoEvents
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnPlinkoMenuButtonClicked : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnInfoButtonClicked : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnPlinkoTutorialStarted : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnCurrencyChanged : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnBallSpawned : IEvent
		{
		}

		public struct OnRewardAreaTriggered : IEvent
		{
			public int index;

			public int amount;

			public OnRewardAreaTriggered(int index, int amount)
			{
				this.index = 0;
				this.amount = 0;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnRefreshButtonTutorialStarted : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnTutorialRefreshClicked : IEvent
		{
		}

		public struct OnPlinkoTokenEarned : IEvent
		{
			public int amount;

			public OnPlinkoTokenEarned(int amount)
			{
				this.amount = 0;
			}
		}
	}
}
