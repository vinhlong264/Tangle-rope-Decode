using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassRemainingTimeController : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI timeText;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private FloatReference timeFloatReference;

		[SerializeField]
		private GameObject timeTextGameObject;

		[SerializeField]
		private GameObject finishedTextGameObject;

		private void Update()
		{
		}
	}
}
