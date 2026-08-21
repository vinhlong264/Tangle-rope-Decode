using UnityEngine;
using UnityEngine.Events;

public class InputKeyListener : MonoBehaviour
{
	[SerializeField]
	private KeyCode keyCode;

	[SerializeField]
	private float holdInterval;

	public UnityEvent OnInputKey;

	public UnityEvent OnInputHold;

	private float holdTimer;

	private void HandleInputs()
	{
	}

	private void Update()
	{
	}
}
