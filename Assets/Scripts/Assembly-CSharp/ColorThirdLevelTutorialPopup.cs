using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class ColorThirdLevelTutorialPopup : MonoBehaviour
{
	public Navigatable navigatable;

	public GameObject Step1;

	public GameObject Step2;

	public GameObject Step3;

	public GameObject reminder;

	[SerializeField]
	private BoolVariable isUiOpen;

	public static bool IsTutorialShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsReminderShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnRopeMergeThatNotTarget()
	{
	}

	private void OnLevelCreated()
	{
	}

	public void OpenTutorial()
	{
	}

	public void CloseStep1()
	{
	}

	public void CloseStep2()
	{
	}

	private void TutorialHandOver()
	{
	}

	public void CloseStep3()
	{
	}

	public void CloseReminder()
	{
	}

	public void Close()
	{
	}
}
