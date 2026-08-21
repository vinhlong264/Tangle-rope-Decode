using System;
using System.Collections.Generic;
using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.Layout
{
	public class SimpleScrollSnapDynamicObjectsController : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private SimpleScrollSnap scrollSnap;

		[SerializeField]
		private CanvasGroup paginationCanvasGroup;

		[SerializeField]
		[Header("Prefabs")]
		private Toggle paginationTogglePrefab;

		[SerializeField]
		[Header("Settings")]
		private bool hidePaginationWhenSingleContent;

		private Dictionary<GameObject, int> preferredIndices;

		[Header("Events")]
		public UnityEvent OnContentAdded;

		public UnityEvent OnNoContentLeft;

		private void AddPagination()
		{
		}

		private void RemovePagination()
		{
		}

		private void ReorderContent()
		{
		}

		private void AddContent(GameObject content, Action addCallback)
		{
		}

		public void AddToBack(GameObject content)
		{
		}

		public void AddToFront(GameObject content)
		{
		}

		public void AddAtSecond(GameObject content)
		{
		}

		public void Remove(GameObject content)
		{
		}

		public void GoToPanel(GameObject content)
		{
		}
	}
}
