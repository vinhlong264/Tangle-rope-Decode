using System;

[Serializable]
public class BaseTutorial
{
	public TutorialType tutorialType;

	public TutorialType nextTutorialType;

	public TutorialVisualData visualData;

	public TutorialSteps CurrentStep { get; private set; }

	public BaseTutorial CreateInstance()
	{
		return null;
	}

	public virtual void StartTutorial()
	{
	}

	public virtual void FinishTutorial()
	{
	}

	protected void SetTutorial(TutorialType t)
	{
	}

	protected void SaveCompletedTutorial(TutorialType type)
	{
	}

	public static bool IsTutorialCompleted(TutorialType type)
	{
		return false;
	}
}
