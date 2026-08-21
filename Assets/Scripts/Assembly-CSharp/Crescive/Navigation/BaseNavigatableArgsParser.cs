using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Navigation
{
	public abstract class BaseNavigatableArgsParser<TArgs> : MonoBehaviour
	{
		[SerializeField]
		private Navigatable navigatable;

		public UnityEvent<TArgs> OnShowArgsParsed;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnShowArgsCallback(object args)
		{
		}

		private void TriggerShowArgsParsed(TArgs parsedArgs)
		{
		}
	}
}
