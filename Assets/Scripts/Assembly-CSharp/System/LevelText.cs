using CresciveCore;
using TMPro;
using UnityEngine;

namespace System
{
	public class LevelText : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI levelText;

		[SerializeField]
		private LevelSystem levelSystem;

		private void OnEnable()
		{
		}
	}
}
