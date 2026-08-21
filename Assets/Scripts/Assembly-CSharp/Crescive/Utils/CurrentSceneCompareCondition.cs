using System.Collections.Generic;
using Crescive.HelperTypes;
using CresciveCore.Utils;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(menuName = "Crescive/Scene/CurrentSceneCompareCondition")]
	public class CurrentSceneCompareCondition : AtomCondition
	{
		[SerializeField]
		private StringVariableReference currentScene;

		[SerializeField]
		private List<SceneField> scenes;

		public override bool Call()
		{
			return false;
		}
	}
}
