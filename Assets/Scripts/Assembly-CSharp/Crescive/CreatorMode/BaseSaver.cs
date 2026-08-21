using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public abstract class BaseSaver : MonoBehaviour
	{
		public abstract UniTask SaveLevel(BaseCreatorData data);

		public abstract string GetLevelSaveDataAsJson();

		public void CopyLevelDataJsonToClipboard()
		{
		}
	}
}
