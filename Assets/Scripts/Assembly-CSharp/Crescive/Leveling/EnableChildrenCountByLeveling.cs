using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class EnableChildrenCountByLeveling : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private LevelingBehaviour leveling;

		[Header("Settings")]
		[SerializeField]
		private bool updateOnAwake;

		[Header("Events")]
		[SerializeField]
		private UnityEvent OnChildrenUpdated;

		private void Awake()
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

		private void UpdateChildren()
		{
		}
	}
}
