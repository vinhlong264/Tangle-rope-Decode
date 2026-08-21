using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataSO<TData> : ScriptableObject
	{
		[SerializeField]
		protected TData data;

		public TData Data => default(TData);

		public void CopyDataJsonToClipboard(bool prettyPrint = true)
		{
		}

		public void PasteDataJsonFromClipboard()
		{
		}

		public void ResetData()
		{
		}
	}
}
