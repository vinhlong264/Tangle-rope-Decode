using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class GameObjectQueue : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod autoSetupMethod;

		[SerializeField]
		private bool dequeueOnceOnSetup;

		[SerializeField]
		private List<GameObjectQueueContent> contents;

		[SerializeField]
		private bool queueFinished;

		private Queue<GameObjectQueueContent> _queue;

		private GameObjectQueueContent current;

		public UnityEvent OnQueueFinished;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void Setup()
		{
		}

		public void TryDequeue()
		{
		}
	}
}
