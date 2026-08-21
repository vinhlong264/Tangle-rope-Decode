using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.OnlineLevels
{
	public class OnlineLevelLoader : MonoBehaviour
	{
		[SerializeField]
		private OnlineLevelsDataService service;

		[SerializeField]
		private StringEvent loadOnlineLevelEvent;

		public void LoadOnlineLevel(int levelNumber)
		{
		}
	}
}
