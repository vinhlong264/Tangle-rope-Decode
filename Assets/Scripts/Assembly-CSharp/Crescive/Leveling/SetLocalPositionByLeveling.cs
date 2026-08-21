using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Leveling
{
	public class SetLocalPositionByLeveling : MonoBehaviour
	{
		[SerializeField]
		private LevelingBehaviour leveling;

		[SerializeField]
		private bool updateOnAwake;

		[SerializeField]
		private List<Vector3> positions;

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

		private void UpdatePosition()
		{
		}
	}
}
