using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[DefaultExecutionOrder(-99999999)]
	public class CreatorSaveDataProcessorSetup : MonoBehaviour
	{
		[SerializeField]
		private bool autoAddAtAwake;

		[SerializeField]
		private bool autoAddAtOnEnable;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		[SerializeField]
		private List<BaseCreatorSaveDataProcessor<LevelCreatorSaveData>> processors;

		[SerializeField]
		private List<BoolVariableReference> processConditions;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void AddProcessors()
		{
		}

		private void RemoveProcessors()
		{
		}
	}
}
