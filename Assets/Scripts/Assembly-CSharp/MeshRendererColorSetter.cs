using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class MeshRendererColorSetter : MonoBehaviour
{
	[SerializeField]
	private Renderer renderer;

	[SerializeField]
	private int materialIndex;

	[SerializeField]
	private List<Renderer> renderers;

	[SerializeField]
	private List<int> materialIndexes;

	private Color color;

	public UnityEvent<Color> OnColorUpdated;

	public UnityEvent<Color> OnColorUpdatedTemporary;

	public UnityEvent<Color, int> OnSubColorUpdated;

	private Tween colorAnimation;

	public Color Color => default(Color);

	private void UpdateMainColor(Color newColor)
	{
	}

	private void SetMaterialColor(Renderer r, int i, Color newColor)
	{
	}

	private void SetMaterialColor(Renderer r, int i, int nameId, Color newColor)
	{
	}

	public void UpdateMaterialMainColor(Color newColor)
	{
	}

	public void UpdateAnimateMaterialMainColor(Color newColor, float t)
	{
	}

	public void UpdateMaterialMainColorTemporary(Color newColor)
	{
	}

	public void UpdateMaterialSubColor(Color newColor, int nameId)
	{
	}
}
