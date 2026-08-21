using System.Collections.Generic;
using Crescive.TransformUtils;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Navigation
{
	[DefaultExecutionOrder(-1000)]
	public class NavigationStack : MonoBehaviour
	{
		[SerializeField]
		private NavigationChannel navigationChannel;

		[SerializeField]
		private Transform navigatablesParent;

		[SerializeField]
		private TransformChannel pushParentTransformChannel;

		[SerializeField]
		private Navigatable firstNavigatable;

		[SerializeField]
		private bool setOnTopWhenShown;

		[SerializeField]
		private List<Navigatable> navigatables;

		[SerializeField]
		private List<Navigatable> stack;

		public UnityEvent<Navigatable> OnShow;

		public UnityEvent<string> OnShowId;

		public UnityEvent<Navigatable> OnPop;

		public UnityEvent<string> OnPopId;

		public UnityEvent OnStackEmpty;

		public UnityEvent OnStackNotEmpty;

		private Transform PushParent => null;

		public Navigatable Current => null;

		public List<Navigatable> Navigatables => null;

		public int StackCount => 0;

		public bool IsEmpty => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SetupNavigationChannel()
		{
		}

		private void ShowCurrent(object args)
		{
		}

		private void HideNavigatable(Navigatable navigatable)
		{
		}

		public Navigatable GetNavigatable(string navigatableId)
		{
			return null;
		}

		public bool HasNavigatableInStack(string navigatableId)
		{
			return false;
		}

		public bool IsCurrentNavigatableMatchesId(string navigatableId)
		{
			return false;
		}

		public void Push(string navigatableId, object args)
		{
		}

		public void Push(Navigatable navigatable, object args)
		{
		}

		public void SinglePush(string navigatableId, object args)
		{
		}

		public void SinglePush(Navigatable navigatable, object args)
		{
		}

		public void PushWithPopIfCurrent(string navigatableId, object args)
		{
		}

		public void PushWithPopIfCurrent(Navigatable navigatable, object args)
		{
		}

		public void PushBack(string navigatableId, object args)
		{
		}

		public void PushBack(Navigatable navigatable, object args)
		{
		}

		public void Overlay(string navigatableId, object args)
		{
		}

		public void Overlay(Navigatable navigatable, object args)
		{
		}

		public void Pop()
		{
		}

		public void Pop(string navigatableId)
		{
		}

		public void Pop(Navigatable navigatable)
		{
		}

		public void PopAll()
		{
		}
	}
}
