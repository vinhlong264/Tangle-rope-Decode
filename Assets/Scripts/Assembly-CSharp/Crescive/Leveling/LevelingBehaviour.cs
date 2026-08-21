using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class LevelingBehaviour : MonoBehaviour, ILevelingValue
	{
		[SerializeField]
		private bool hasMaxLevel;

		[SerializeField]
		private int maxLevel;

		[SerializeField]
		private LevelingDataValueType dataValueType;

		[SerializeField]
		private IntReference initialAtomLevel;

		[SerializeField]
		private PersistentIntVariable initialPersistentLevel;

		private int level;

		[SerializeField]
		private UnityEvent<int> OnLevelChangedEvent;

		[SerializeField]
		private UnityEvent<int> OnLevelIncreasedEvent;

		[SerializeField]
		private UnityEvent<int> OnLevelDecreasedEvent;

		[SerializeField]
		public UnityEvent OnLevelReachedToZero;

		public int Level => 0;

		public UnityEvent<int> OnLevelChanged => null;

		public UnityEvent<int> OnLevelIncreased => null;

		public UnityEvent<int> OnLevelDecreased => null;

		public bool DidReachMaxLevel => false;

		private void Awake()
		{
		}

		private int GetInitialLevel()
		{
			return 0;
		}

		public void SetLevel(int newLevel)
		{
		}

		public void IncreaseLevel(int amount = 1)
		{
		}

		public void DecreaseLevel(int amount = 1)
		{
		}

		public void SetLevelToInitial()
		{
		}
	}
}
