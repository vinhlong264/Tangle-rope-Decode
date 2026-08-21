using UnityEngine;
using UnityEngine.Events;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "Map Profile Data", menuName = "Level Creator/Map Profile Data")]
	public class MapProfileData : ScriptableObject
	{
		public UnityEvent<int> OnMapNumberChanged;

		[field: SerializeField]
		public int MapNumber { get; private set; }

		[field: SerializeField]
		public int MinNumber { get; private set; }

		[field: SerializeField]
		public int MaxNumber { get; private set; }

		public void SetMapNumber(int value)
		{
		}

		public void IncreaseMapNumber()
		{
		}

		public void DecreaseMapNumber()
		{
		}
	}
}
