using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Navigation
{
	[DefaultExecutionOrder(-10000)]
	public class BasicNavigationStack : MonoBehaviour
	{
		[SerializeField]
		private BasicNavigatable firstNavigatable;

		[SerializeField]
		private List<BasicNavigatable> stack;

		public BasicNavigatable Current => null;

		private void ShowCurrent()
		{
		}

		private void Awake()
		{
		}

		public void Push(BasicNavigatable navigatable)
		{
		}

		public void Overlay(BasicNavigatable navigatable)
		{
		}

		public void Pop()
		{
		}

		public void Pop(BasicNavigatable navigatable)
		{
		}
	}
}
