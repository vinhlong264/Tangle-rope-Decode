using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Levels
{
	public class LevelDifficultyListenerByLevelNumber : MonoBehaviour
	{
		[SerializeField]
		private IntReference levelNumber;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		[SerializeField]
		private LevelDifficultyTransformer levelDifficultyTransformer;

		public UnityEvent<string> OnDifficultyChanged;

		public UnityEvent<string> OnDifficultyDetailedChanged;

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

		public void SetLevelNumber(int level)
		{
		}
	}
}
