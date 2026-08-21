using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Leveling
{
	public class SetLocalScaleByLeveling : MonoBehaviour
	{
		[SerializeField]
		private LevelingBehaviour leveling;

		[SerializeField]
		private bool updateOnAwake;

		[SerializeField]
		private List<Vector3> scales;

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
