using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class HorizontalCamera : MonoBehaviour
{
	private Camera m_camera;

	private float lastAspect;

	[SerializeField]
	private float m_fieldOfView;

	[SerializeField]
	private float m_orthographicSize;

	public float FieldOfView
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float OrthographicSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void RefreshCamera()
	{
	}

	private void AdjustCamera(float aspect)
	{
	}
}
