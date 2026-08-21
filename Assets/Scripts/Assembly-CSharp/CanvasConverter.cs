using UnityEngine;

public class CanvasConverter : MonoBehaviour
{
	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private string canvasName;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnChangeCanvasToCamera(UiEvents.ChangeCanvasToCamera obj)
	{
	}

	private void OnChangeCanvasToOverlay(UiEvents.ChangeCanvasToOverlay obj)
	{
	}
}
