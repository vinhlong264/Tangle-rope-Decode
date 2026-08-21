using Crescive.Factory;
using Crescive.UI;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestTokenCollectAnimator : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private CanvasChannel canvasChannel;

		[SerializeField]
		private GameObjectFactory tokenCollectFxFactory;

		private void SpawnFx(Vector3 screenPosition)
		{
		}

		public void TriggerAnimation(Vector3 position)
		{
		}
	}
}
