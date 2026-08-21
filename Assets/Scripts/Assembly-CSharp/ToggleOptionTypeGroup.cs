using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "GameData/Type/ToggleOptionTypeGroup", fileName = "ToggleOptionTypeGroup")]
public class ToggleOptionTypeGroup : ScriptableObject
{
	[SerializeField]
	[Header("Settings")]
	private List<ToggleOptionType> optionTypes;

	[Header("Events")]
	public UnityEvent<ToggleOptionType> OnToggled;

	private string DataKeyPref => null;

	public int CurrentIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ToggleOptionType GetCurrentOptionType()
	{
		return null;
	}

	public void SwitchToNextOption()
	{
	}

	public void ToggleOptionType(ToggleOptionType optionType)
	{
	}

	public void ToggleCurrentOptionType(bool switchToNext)
	{
	}
}
