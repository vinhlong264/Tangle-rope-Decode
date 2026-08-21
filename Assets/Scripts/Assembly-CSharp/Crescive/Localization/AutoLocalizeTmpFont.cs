using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

namespace Crescive.Localization
{
	public class AutoLocalizeTmpFont : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text tmpText;

		[SerializeField]
		private string localizationFontMaterialKey;

		private LocalizedTmpFont localizedFont;

		private bool didSetFontOnce;

		private static LocalizationManager LocalizationManager => null;

		private List<string> LocalizedFontMaterialKeys => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetFont(TMP_FontAsset font)
		{
		}
	}
}
