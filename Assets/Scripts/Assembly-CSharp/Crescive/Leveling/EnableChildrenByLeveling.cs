using UnityEngine;

namespace Crescive.Leveling
{
	public class EnableChildrenByLeveling : MonoBehaviour
	{
		[SerializeField]
		private LevelingBehaviour leveling;

		[SerializeField]
		private bool updateOnAwake;

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
