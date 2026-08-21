using System.Collections.Generic;
using UnityEngine;

internal class ColorSecondLevelFirstStep : MonoBehaviour
{
	[SerializeField]
	private ColorSecondLevelTutorialPopup cp;

	[SerializeField]
	[Header("UI")]
	private FakeCircleController circle;

	[SerializeField]
	private RectTransform parent;

	private readonly List<FakeCircleController> spawned;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
