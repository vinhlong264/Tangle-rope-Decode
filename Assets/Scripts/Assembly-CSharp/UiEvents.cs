public class UiEvents
{
	public struct SetNoadsButton : IEvent
	{
		public bool open;

		public SetNoadsButton(bool open)
		{
			this.open = false;
		}
	}

	public struct ChangeCanvasToCamera : IEvent
	{
		public string CanvasName;

		public float plaintDistance;

		public ChangeCanvasToCamera(string canvasName, float plaintDistance)
		{
			CanvasName = null;
			this.plaintDistance = 0f;
		}
	}

	public struct ChangeCanvasToOverlay : IEvent
	{
		public float plaintDistance;

		public string CanvasName;

		public ChangeCanvasToOverlay(string canvasName, float plaintDistance)
		{
			this.plaintDistance = 0f;
			CanvasName = null;
		}
	}
}
