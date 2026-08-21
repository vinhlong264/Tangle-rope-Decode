using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Levels
{
	public class LevelDifficultyEventChooser : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod triggerMethod;

		[SerializeField]
		private StringVariable difficulty;

		[SerializeField]
		private StringVariable levelType;

		[SerializeField]
		private bool dontListenToChanges;

		[SerializeField]
		private List<BoolVariableReference> conditions;

		[SerializeField]
		private List<LevelDifficultyEventPair> events;

		private bool difficultyPriorityMode;

		[SerializeField]
		private bool bug;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLevelCreated()
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

		private bool OldLogic(LevelDifficultyEventPair pair)
		{
			return false;
		}

		private bool IsNormalLevel(string lvlType)
		{
			return false;
		}
	}
}
