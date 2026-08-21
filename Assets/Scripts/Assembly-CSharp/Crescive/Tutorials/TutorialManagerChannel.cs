using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Tutorials
{
	[CreateAssetMenu(fileName = "Tutorial Manager Channel", menuName = "Crescive/Tutorial/Tutorial Manager Channel")]
	public class TutorialManagerChannel : ObjectChannel<TutorialManager>
	{
		public UnityEvent<TutorialStateChangedEvent> TutorialStateChanged;

		public ITutorialState? CurrentState => null;

		public override void SetupData(TutorialManager newData)
		{
		}

		public override void ResetData()
		{
		}

		public void OnTutorialStateChanged(TutorialStateChangedEvent tutorialStateChangedEvent)
		{
		}
	}
}
