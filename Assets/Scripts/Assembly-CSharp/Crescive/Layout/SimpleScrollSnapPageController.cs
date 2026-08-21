using System.Collections.Generic;
using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Layout
{
	public class SimpleScrollSnapPageController : MonoBehaviour
	{
		[SerializeField]
		private ToggleGroup toggleGroup;

		[SerializeField]
		private SimpleScrollSnap scrollSnap;

		[SerializeField]
		private Transform inactivePagesParent;

		[SerializeField]
		private Transform inactivePaginationsParent;

		[SerializeField]
		[Space]
		private List<SimpleScrollSnapContentData> contentsData;

		public SimpleScrollSnap ScrollSnap => null;

		public void Add(string key)
		{
		}

		public void Remove(string key)
		{
		}

		public void GoToPanel(string key)
		{
		}
	}
}
