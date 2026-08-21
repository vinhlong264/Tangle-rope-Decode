using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	[CreateAssetMenu(menuName = "ScriptableObjects/Leveling/LevelingData", fileName = "LevelingData")]
	public class LevelingData : ScriptableObject
	{
		[SerializeField]
		private bool hasMaxLevel;

		[SerializeField]
		private int maxLevel;

		[SerializeField]
		private LevelingDataValueType dataValueType;

		[SerializeField]
		private IntReference atomLevel;

		[SerializeField]
		private PersistentIntVariable persistentLevel;

		public UnityEvent<int> OnChanged;

		public UnityEvent<int> OnIncreased;

		public UnityEvent<int> OnDecreased;

		public int Value => 0;

		public bool HasMaxLevel => false;

		public int MaxLevel => 0;

		public bool MaxLevelReached => false;

		public void SetLevel(int level)
		{
		}

		public void IncreaseLevel()
		{
		}

		public void DecreaseLevel()
		{
		}

		private int GetLevel()
		{
			return 0;
		}
	}
}
