using System.Collections.Generic;
using MyBox;

namespace Game.Systems.Tutorial
{
	public class TutorialManager : Singleton<TutorialManager>
	{
		public TutorialData TutorialData;

		public bool isTutorialActive;

		private List<BaseTutorial> _tutorials;

		public void Initialize()
		{
		}

		public BaseTutorial GetTutorial(TutorialType tutorialType)
		{
			return null;
		}

		public void StartTutorial(TutorialType tutorialType)
		{
		}

		public void EndTutorial(TutorialType tutorialType)
		{
		}
	}
}
