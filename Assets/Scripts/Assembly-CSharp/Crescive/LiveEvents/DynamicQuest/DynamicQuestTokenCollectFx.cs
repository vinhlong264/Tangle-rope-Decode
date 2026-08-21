using BrunoMikoski.AnimationSequencer;
using Crescive.Pooling;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestTokenCollectFx : MonoBehaviour, IPooledObject
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private DynamicQuestTokenView tokenView;

		[SerializeField]
		private AnimationSequencerController animation;

		[SerializeField]
		private float randomPosStrength;

		public UnityEvent OnSetup;

		public CanvasGroup CanvasGroup => null;

		public GameObjectPooler Pooler { get; set; }

		private void DestroySelf()
		{
		}

		public void SetupAndPlay()
		{
		}
	}
}
