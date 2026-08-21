using Crescive.HelperTypes;
using CresciveCore;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Analytics
{
	public class SceneOpenEventsIntegration : MonoBehaviour
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private StringVariable currentSceneTypeId;

		[SerializeField]
		private StringConstant targetSceneTypeId;

		[SerializeField]
		private StringVariableReference eventParam;

		[SerializeField]
		private bool oneShot;

		private bool isSentAny;

		private int LevelNumber => 0;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSceneTypeChangedCallback(string sceneTypeId)
		{
		}

		public void SendEvent()
		{
		}
	}
}
