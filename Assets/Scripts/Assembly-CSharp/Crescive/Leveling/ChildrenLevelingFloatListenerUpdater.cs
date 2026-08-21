using UnityEngine;

namespace Crescive.Leveling
{
	public class ChildrenLevelingFloatListenerUpdater : MonoBehaviour
	{
		[SerializeField]
		private LevelingFloat levelingFloat;

		[SerializeField]
		private bool updateOnAwake;

		[SerializeField]
		private bool updateOnEnable;

		[SerializeField]
		private bool updateOnStart;

		[SerializeField]
		private bool includeInactive;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void UpdateChildren()
		{
		}
	}
}
