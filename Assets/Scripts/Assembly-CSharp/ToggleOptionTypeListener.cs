using UnityEngine;
using UnityEngine.Events;

public class ToggleOptionTypeListener : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private ToggleOptionType toggleOptionType;

	[Header("Events")]
	[SerializeField]
	private UnityEvent OnToggled;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnToggledCallback()
	{
	}
}
