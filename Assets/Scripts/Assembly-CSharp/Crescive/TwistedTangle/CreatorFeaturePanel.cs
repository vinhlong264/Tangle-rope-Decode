using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class CreatorFeaturePanel : MonoBehaviour
	{
		[SerializeField]
		private OnOffSwitch moveToggle;

		[SerializeField]
		private TMP_InputField moveCountField;

		[SerializeField]
		private IntVariable moveCount;

		[SerializeField]
		private BoolVariable hasMoveCount;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void OnHasMoveCountChanged()
		{
		}

		private void OnSwitchedChanged(bool switchOn)
		{
		}

		private void OnMoveCountFieldValueChanged(int arg0)
		{
		}

		private void OnMoveCountFieldEdit(string arg0)
		{
		}

		private void UpdateUI()
		{
		}
	}
}
