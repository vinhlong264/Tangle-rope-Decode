using PersistentSO;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	public class ResourceGenerator : MonoBehaviour
	{
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private ResourceGeneratorDataProviderWrapper resourceChannelDataProviderWrapper;

		[SerializeField]
		private PersistentStringVariable lastGeneratedTime;

		[SerializeField]
		private PersistentStringVariable nextGenerateTime;

		[SerializeField]
		private HeartResourceGeneratorSelector heartResourceGeneratorSelector;

		[SerializeField]
		private DateTimeCountdownBehaviour countdown;

		private ResourceGeneratorData Data => null;

		private double GenerateIntervalSeconds => 0.0;

		private bool CanGenerate => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void OnResourceCapacityChanged()
		{
		}

		private void OnTimerExpiredCallback()
		{
		}

		private void Generate()
		{
		}

		private void UpdateTimes()
		{
		}

		private void TryUpdateNextGenerateTime()
		{
		}

		private void ResetNextGenerateTime()
		{
		}

		private void OnResourceChangedCallback(float previous, float current)
		{
		}
	}
}
