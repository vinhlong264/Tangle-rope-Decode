using Crescive.Offer;
using TMPro;
using UnityEngine;

public class OfferRequesterInputFieldDefaultSetter : MonoBehaviour
{
	[SerializeField]
	private PersistentOfferTestMetaData persistentOfferTestMetaData;

	[SerializeField]
	private TMP_InputField triggerPointTextFİeld;

	[SerializeField]
	private TMP_InputField healthCurrencyTextField;

	[SerializeField]
	private TMP_InputField coinCurrencyTextField;

	[SerializeField]
	private TMP_InputField boosterCurrencyTextField;

	[SerializeField]
	private TMP_InputField totalCurrencyTransactionTextField;

	[SerializeField]
	private TMP_InputField sessionCurrencyTransactionTextField;

	[SerializeField]
	private TMP_InputField TotalIAPCountTextField;

	[SerializeField]
	private TMP_InputField SessionIAPCountTextField;

	[SerializeField]
	private TMP_InputField totalIAPLTVTextField;

	[SerializeField]
	private TMP_InputField sessionIAPLTVTextField;

	[SerializeField]
	private TMP_InputField totalBossLevelStartedCountTextField;

	[SerializeField]
	private TMP_InputField sessionBossLevelStartedCountTextField;

	[SerializeField]
	private TMP_InputField totalBossLevelCompletedCountTextField;

	[SerializeField]
	private TMP_InputField sessionBossLevelCompletedCountTextField;

	[SerializeField]
	private TMP_InputField totalChallengeLevelStartedCountTextField;

	[SerializeField]
	private TMP_InputField sessionChallengeLevelStartedCountTextField;

	[SerializeField]
	private TMP_InputField totalChallengeLevelCompletedCountTextField;

	[SerializeField]
	private TMP_InputField sessionChallengeLevelCompletedCountTextField;

	private void OnEnable()
	{
	}

	private void SetInitialTextFieldValues()
	{
	}
}
