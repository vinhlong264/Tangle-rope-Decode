using Crescive.Navigation;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[RequireComponent(typeof(Navigatable))]
	public class BattlePassInfoStepsPanel : MonoBehaviour
	{
		[SerializeField]
		private GameObject infoWithMultipleStepsView;

		private Navigatable _navigatable;

		private Navigatable Navigatable => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}
	}
}
