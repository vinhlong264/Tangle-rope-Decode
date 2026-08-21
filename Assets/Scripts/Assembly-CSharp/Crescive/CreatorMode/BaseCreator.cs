using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public abstract class BaseCreator : MonoBehaviour
	{
		public abstract UniTask CreateLevelFromJson(string json, int index = 0);
	}
}
