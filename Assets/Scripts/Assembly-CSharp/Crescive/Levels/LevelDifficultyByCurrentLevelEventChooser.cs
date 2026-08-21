using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Levels
{
	public class LevelDifficultyByCurrentLevelEventChooser : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod triggerMethod;

		[SerializeField]
		private StringVariableReference difficulty;

		[SerializeField]
		private List<LevelDifficultyEventPair> events;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void TriggerEvents()
		{
		}

		public void TriggerEventsWithDifficulty(string difficultyValue)
		{
		}
	}
}
