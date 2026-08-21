using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public class ResourceGeneratorMaxValueListener : MonoBehaviour
	{
		[SerializeField]
		private ResourceGeneratorDataService resourceGeneratorService;

		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private UnityEvent OnInsideMaxValue;

		[SerializeField]
		private UnityEvent OnBelowMaxValue;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnResourceChannelChangedCallback(float value)
		{
		}
	}
}
