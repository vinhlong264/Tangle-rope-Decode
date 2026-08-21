using Crescive.HelperTypes;
using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "Current Scene Or Level Type", menuName = "Crescive/Scene Type/Current Scene Or Level Type")]
	public class CurrentSceneOrLevelTypeScriptableProperty : StringScriptableProperty
	{
		[SerializeField]
		private StringVariableReference sceneTypeId;

		[SerializeField]
		private StringVariableReference levelTypeId;

		[SerializeField]
		private StringVariableReference gameSceneTypeId;

		protected override string GetValue()
		{
			return null;
		}
	}
}
