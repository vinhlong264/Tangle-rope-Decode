using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class SpawnerByLeveling : MonoBehaviour
	{
		[SerializeField]
		private PrefabsLevelingSettings data;

		[SerializeField]
		private Transform centerPivot;

		[SerializeField]
		private bool removeOldClone;

		[SerializeField]
		private bool animate;

		[SerializeField]
		private float animDuration;

		[RequireInterface(typeof(ILevelingValue))]
		[SerializeField]
		private Object levelingObject;

		private GameObject current;

		private int currentLevel;

		private GameObject currentPrefab;

		public UnityEvent<GameObject> OnUpdated;

		public UnityEvent<GameObject> OnLevelUpgraded;

		public UnityEvent<GameObject> OnLevelDowngraded;

		private ILevelingValue LevelingValue => null;

		public GameObject Current => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLevelChanged(int level)
		{
		}

		private void UpdateSpawn(bool animate = true)
		{
		}

		private void AnimateToDestroy(GameObject go, Ease ease = Ease.Unset, TweenCallback OnComplete = null)
		{
		}

		private void AnimateSpawn(GameObject go, Ease ease = Ease.Unset, TweenCallback OnComplete = null)
		{
		}
	}
}
