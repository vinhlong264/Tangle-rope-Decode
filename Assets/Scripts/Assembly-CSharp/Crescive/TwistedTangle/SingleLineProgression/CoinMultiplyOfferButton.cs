using Crescive.HelperTypes;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	[DefaultExecutionOrder(1)]
	public class CoinMultiplyOfferButton : MonoBehaviour
	{
		[SerializeField]
		private FloatVariableReference baseCoins;

		[SerializeField]
		private FloatVariableReference multiplier;

		[SerializeField]
		private FloatVariableInstancer finalCoins;

		[SerializeField]
		private TMP_Text multiplierText;

		private void OnEnable()
		{
		}

		private void Initialize()
		{
		}
	}
}
