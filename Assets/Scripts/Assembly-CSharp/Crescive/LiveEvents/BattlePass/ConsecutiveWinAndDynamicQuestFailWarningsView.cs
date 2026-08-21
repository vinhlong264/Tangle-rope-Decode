using Crescive.LiveEvents.DynamicQuest;
using TMPro;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	public class ConsecutiveWinAndDynamicQuestFailWarningsView : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI warningText;

		[SerializeField]
		private TextMeshProUGUI dynamicQuestTokenText;

		[SerializeField]
		private GameObject dynamicQuestParentObject;

		[SerializeField]
		private GameObject consecutiveWinParentObject;

		[SerializeField]
		private AtomCondition dynamicQuestCondition;

		[SerializeField]
		private AtomCondition consecutiveWinCondition;

		[SerializeField]
		private DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		private StringVariableInstancer superPowerupsLocalizationIdReference;

		[SerializeField]
		private StringVariableInstancer ampersandLocalizationIdReference;

		[SerializeField]
		private StringVariableInstancer crystalsLocalizationIdReference;

		private void OnEnable()
		{
		}

		public void Setup()
		{
		}
	}
}
