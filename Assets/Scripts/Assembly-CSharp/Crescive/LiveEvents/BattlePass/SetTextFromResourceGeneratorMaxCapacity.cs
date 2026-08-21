using Crescive.ResourceSystem;
using TMPro;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	public class SetTextFromResourceGeneratorMaxCapacity : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private ResourceGeneratorDataService resourceGenerator;

		[SerializeField]
		private bool CastToInt;

		private void Start()
		{
		}
	}
}
