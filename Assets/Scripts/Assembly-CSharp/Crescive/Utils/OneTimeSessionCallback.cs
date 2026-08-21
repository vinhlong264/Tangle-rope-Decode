using CresciveCore.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class OneTimeSessionCallback : Singleton<OneTimeSessionCallback>
	{
		[SerializeField]
		private UnityEvent callback;

		private void Start()
		{
		}
	}
}
