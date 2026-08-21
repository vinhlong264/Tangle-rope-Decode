using Crescive.Draggables;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "RopeSelectionChannel", menuName = "GameData/Map/Channels/RopeSelectionChannel")]
	public class RopeSelectionChannel : ScriptableObject
	{
		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		public UnityEvent OnSelectionEnabled;

		public UnityEvent OnSelectionDisabled;

		public UnityEvent<bool> OnSelectionChanged;

		public void EnableSelection()
		{
		}

		public void DisableSelection()
		{
		}

		public void ToggleSelection(bool active)
		{
		}
	}
}
