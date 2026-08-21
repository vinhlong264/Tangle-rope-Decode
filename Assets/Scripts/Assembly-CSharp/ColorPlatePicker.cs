using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorPlatePicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	[SerializeField]
	private RawImage paletteImage;

	[SerializeField]
	private RectTransform cursor;

	[SerializeField]
	private Button closeButton;

	private Texture2D paletteTexture;

	private Action<Color> onColorPicked;

	private Vector2 lastLocalPoint;

	public bool ActiveUse;

	public void Initialize(Action<Color> onColorPicked)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void UpdateCursorPosition(PointerEventData eventData)
	{
	}

	private void PickColor()
	{
	}

	private void ClosePicker()
	{
	}

	private void Reset()
	{
	}

	private void OnDestroy()
	{
	}
}
