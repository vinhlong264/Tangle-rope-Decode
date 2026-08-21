using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class LevelingCompareListener : MonoBehaviour
	{
		[RequireInterface(typeof(ILevelingValue))]
		[SerializeField]
		private Object levelingValue;

		[SerializeField]
		private IntVariable playerLeveling;

		[SerializeField]
		private IntReference difference;

		public UnityEvent OnHigherThan;

		public UnityEvent OnEqual;

		public UnityEvent OnLowerThan;

		private ILevelingValue LevelingValue => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnCompareLevelingChanged(int level)
		{
		}
	}
}
