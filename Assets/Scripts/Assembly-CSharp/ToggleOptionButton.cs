using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ToggleOptionButton : MonoBehaviour
{
	[SerializeField]
	[Header("References")]
	private Image buttonImage;

	[SerializeField]
	private TextMeshProUGUI buttonText;

	[Header("Settings")]
	[SerializeField]
	private ToggleOptionTypeGroup optionTypeGroup;

	[SerializeField]
	private List<Sprite> buttonSprites;

	[Header("Events")]
	[SerializeField]
	private UnityEvent OnToggled;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateButton(ToggleOptionType _ = null)
	{
	}

	public void ToggleNextOption()
	{
	}
}
