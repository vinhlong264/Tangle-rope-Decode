using System.Collections.Generic;
using UnityEngine;

namespace Crescive.AutoLayout
{
	public abstract class TransformAutoLayout : MonoBehaviour
	{
		[SerializeField]
		protected bool updateInEditor;

		[SerializeField]
		protected bool autoUpdate;

		[SerializeField]
		protected bool useList;

		[SerializeField]
		protected List<Transform> items;

		[SerializeField]
		protected int previousChildCount;

		public List<Transform> ActiveItems => null;

		public List<Transform> InactiveItems => null;

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public void ActivateItems(int amount)
		{
		}

		public void DeactivateItems(int amount)
		{
		}

		public abstract void UpdateLayout();

		public abstract Vector3 GetItemPositionAtIndexForItemCount(int i, int itemCount);
	}
}
