using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace ElephantSDK
{
	public class ElephantTrackerListener : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		[SerializeField]
		private bool onlyTriggerForEditor;

		public UnityEvent OnElephantActive;

		public UnityEvent OnElephantInactive;

		public UnityEvent<bool> OnElephantActiveChanged;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void Trigger()
		{
		}
	}
}
