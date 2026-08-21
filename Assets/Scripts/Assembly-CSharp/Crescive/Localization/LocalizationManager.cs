using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using CresciveCore.Utils;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

namespace Crescive.Localization
{
	[CreateAssetMenu(fileName = "Localization Manager", menuName = "Crescive/Localization/Manager/Localization Manager")]
	public sealed class LocalizationManager : SingletonSO<LocalizationManager>
	{
		[SerializeField]
		private LocalizationDataService localizationDataService;

		[SerializeField]
		private string timeStringTable;

		[SerializeField]
		private List<string> stringTableNames;

		[SerializeField]
		private List<string> fontTableNames;

		[SerializeField]
		private List<string> fontMaterialTableNames;

		[SerializeField]
		private List<string> spriteTableNames;

		[SerializeField]
		private List<string> fontMaterialKeys;

		public List<string> StringTableNames => null;

		public List<string> FontTableNames => null;

		public List<string> FontMaterialTableNames => null;

		public List<string> SpriteTableNames => null;

		public List<string> FontMaterialKeys => null;

		public string DefaultStringTableName => null;

		public string DefaultFontTableName => null;

		public string DefaultFontMaterialTableName => null;

		public string DefaultSpriteTableName => null;

		public string DefaultFontKey => null;

		public string DefaultFontMaterialKey => null;

		public string TimeStringTable => null;

		public CultureInfo CurrentCulture => null;

		public LocalizationCommonStrings CommonStrings { get; private set; }

		protected override void OnInitialize()
		{
		}

		protected override void OnDispose()
		{
		}

		private void InitializeLocalization(LocalizationData _)
		{
		}

		private void SetLocale(string locale)
		{
		}

		public LocalizedString GetLocalizedStringInstance(string key, string tableName = null)
		{
			return null;
		}

		public string GetString(string key, string tableName = null)
		{
			return null;
		}

		public UniTask<string> GetStringAsync(string key, string tableName = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<string>);
		}

		public void SetFontMaterial(TMP_Text tmp, string key)
		{
		}
	}
}
