using System.Collections.Generic;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public class CreatorApiLevelsValidator : MonoBehaviour
	{
		[SerializeField]
		private string baseUrl;

		[SerializeField]
		private List<string> levelIds;

		[SerializeField]
		private List<string> difficulties;

		[SerializeField]
		private List<int> timeLimits;

		private void ValidateOnlineLevels()
		{
		}

		private void CopyLevelIdsFromClipboard()
		{
		}

		private void CopyDifficultiesFromClipboard()
		{
		}

		private void CopyTimeLimitsFromClipboard()
		{
		}
	}
}
