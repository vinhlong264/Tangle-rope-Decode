using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Levels
{
	public class LevelDifficultyListener : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod triggerMethod;

		[SerializeField]
		private StringVariable difficulty;

		[SerializeField]
		private StringVariable detailedDifficulty;

		public UnityEvent<string> OnDifficultyChanged;

		public UnityEvent<string> OnDetailedDifficultyChanged;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void TriggerEvents()
		{
		}
	}
}
