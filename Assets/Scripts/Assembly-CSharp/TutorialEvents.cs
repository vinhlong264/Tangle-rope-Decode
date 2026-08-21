using System.Runtime.InteropServices;

public class TutorialEvents
{
	public struct ActivateTutorialHand : IEvent
	{
		public int Index;

		public ActivateTutorialHand(int Index)
		{
			this.Index = 0;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct TutorialHandOver : IEvent
	{
	}

	public struct OverrideSortingGoal : IEvent
	{
		public bool isAdd;

		public OverrideSortingGoal(bool isAdd)
		{
			this.isAdd = false;
		}
	}

	public struct OverrideSortingGoalsAndTimer : IEvent
	{
		public bool isGoal;

		public bool isAdd;

		public OverrideSortingGoalsAndTimer(bool isGoal, bool isAdd)
		{
			this.isGoal = false;
			this.isAdd = false;
		}
	}
}
