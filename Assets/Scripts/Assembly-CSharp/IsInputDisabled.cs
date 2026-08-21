using Crescive.Scriptables;
using UnityEngine;

[CreateAssetMenu(fileName = "IsInputDisabled", menuName = "GameData/Gameplay/IsInputDisabled")]
public class IsInputDisabled : BoolScriptableProperty
{
	private bool _isInputDisabled;

	protected override bool GetValue()
	{
		return false;
	}
}
