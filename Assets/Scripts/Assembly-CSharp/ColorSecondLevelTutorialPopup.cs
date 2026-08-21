using System.Collections.Generic;
using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using Crescive.Navigation;
using Crescive.TwistedTangle;
using UnityEngine;

public class ColorSecondLevelTutorialPopup : MonoBehaviour
{
	public Navigatable navigatable;

	public GameObject Step1;

	public GameObject Step2;

	public GameObject Step3;

	public DraggablesControllerChannel DraggablesController;

	[SerializeField]
	private PinSlotsChannel pinSlotsChannel;

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

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void DoSMt(DraggableEventParams arg0)
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

	private void Close()
	{
	}

	public IReadOnlyList<PinSlotEntity> GetActivePinsSlots()
	{
		return null;
	}
}
