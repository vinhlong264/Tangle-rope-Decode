namespace Crescive.Tutorials
{
	public struct TutorialStateChangedEvent
	{
		public ITutorialState? PreviousState;

		public ITutorialState? CurrentState;
	}
}
