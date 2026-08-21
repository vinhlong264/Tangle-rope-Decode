using Crescive.Scriptables;
using UnityEngine;

[CreateAssetMenu(fileName = "EditorSceneCheckProperty", menuName = "GameData/EditorSceneCheckProperty")]
public class EditorSceneCheckProperty : BoolScriptableProperty
{
	protected override bool GetValue()
	{
		return false;
	}
}
