using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class AnalyticsEventParamHelper : ScriptableObject
{
	[SerializeField]
	private BoolReference isStageLevel;

	[SerializeField]
	private IntReference stageIndex;

	[SerializeField]
	private StringVariableReference levelType;

	public int GetStageNumber()
	{
		return 0;
	}

	public bool IsStageLevel()
	{
		return false;
	}

	public string GetLevelType()
	{
		return null;
	}
}
