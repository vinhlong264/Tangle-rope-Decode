using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Layout
{
	public class LayoutElementIgnoreLayoutSyncer : MonoBehaviour
	{
		[SerializeField]
		private LayoutElement selfLayoutElement;

		[SerializeField]
		private List<LayoutElement> layoutElements;

		private bool _forceClose;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSetNoadsButton(UiEvents.SetNoadsButton obj)
		{
		}

		private void Update()
		{
		}

		private bool CheckIsIgnoring()
		{
			return false;
		}
	}
}
