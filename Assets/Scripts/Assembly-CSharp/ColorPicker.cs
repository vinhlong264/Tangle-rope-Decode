using System;
using System.Runtime.CompilerServices;
using Crescive.TwistedTangle.SpecialEditor.UI;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[ExecuteInEditMode]
public class ColorPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	private enum PointerDownLocation
	{
		HueCircle = 0,
		SVSquare = 1,
		Outside = 2
	}

	[SerializeField]
	private ColorVariable activeColor;

	[SerializeField]
	private ColorVariable selectedColor;

	[SerializeField]
	private SliderValueDisplayer alphaSlider;

	private const float recip2Pi = 1f / (2f * (float)Math.PI);

	private const string colorPickerShaderName = "UI/ColorPicker";

	private static readonly int _HSV;

	private static readonly int _AspectRatio;

	private static readonly int _HueCircleInner;

	private static readonly int _SVSquareSize;

	[SerializeField]
	[HideInInspector]
	private Shader colorPickerShader;

	private Material generatedMaterial;

	private PointerDownLocation pointerDownLocation;

	private RectTransform rectTransform;

	private Image image;

	private float h;

	private float s;

	private float v;

	private float a;

	public Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public event Action<Color> onColorChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetColorAlpha(float newAlpha)
	{
	}

	private void SetColor(Color newColor)
	{
	}

	private void Reset()
	{
	}

	private bool WrongShader()
	{
		return false;
	}

	private void Update()
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void ApplyColor()
	{
	}

	private void OnDestroy()
	{
	}

	public Vector2 GetRelativePosition(PointerEventData eventData)
	{
		return default(Vector2);
	}

	public Rect GetSquaredRect()
	{
		return default(Rect);
	}

	public float InverseLerpUnclamped(float min, float max, float value)
	{
		return 0f;
	}
}
