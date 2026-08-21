using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class OnOffSwitch : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private GameObject onSwitch;

	[SerializeField]
	private GameObject offSwitch;

	[SerializeField]
	private Sprite onBg;

	[SerializeField]
	private Sprite offBg;

	[SerializeField]
	private bool currentState;

	[Header("Events")]
	public UnityEvent OnSwitchOn;

	public UnityEvent OnSwitchedOff;

	public UnityEvent<bool> OnSwitchChanged;

	public void Toggle()
	{
	}

	public void Toggle(bool isOn, bool notify = true)
	{
	}

	public void ToggleWithNotify(bool isOn)
	{
	}

	public void ToggleWithoutNotify(bool isOn)
	{
	}
}
