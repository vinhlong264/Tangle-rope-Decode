using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Economics.UI
{
	public class CollectedCoinsText : MonoBehaviour
	{
		[SerializeField]
		private IntReference collectedCoins;

		[SerializeField]
		private TextMeshProUGUI text;

		private void Awake()
		{
		}
	}
}
