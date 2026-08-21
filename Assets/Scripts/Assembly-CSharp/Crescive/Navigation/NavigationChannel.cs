using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Navigation
{
	[CreateAssetMenu(fileName = "NavigationChannel", menuName = "Crescive/Navigation/NavigationChannel")]
	public class NavigationChannel : ScriptableObject
	{
		[SerializeField]
		private NavigationStack stack;

		public UnityEvent<Navigatable> OnShow;

		public UnityEvent<string> OnShowId;

		public UnityEvent<Navigatable> OnPop;

		public UnityEvent<string> OnPopId;

		public UnityEvent OnStackEmpty;

		public UnityEvent OnStackNotEmpty;

		public UnityEvent OnStackChanged;

		public NavigationStack Stack => null;

		public bool IsStackInitialized => false;

		public bool IsEmpty => false;

		public void ResetData()
		{
		}

		public void SetController(NavigationStack newStack)
		{
		}

		public Navigatable GetNavigatable(string navigatableId)
		{
			return null;
		}

		public void Push(Navigatable navigatable)
		{
		}

		public void Push(StringConstant id)
		{
		}

		public void Push(string id)
		{
		}

		public void Push(string id, object args)
		{
		}

		public void SinglePush(Navigatable navigatable)
		{
		}

		public void SinglePush(StringConstant id)
		{
		}

		public void SinglePush(string id)
		{
		}

		public void SinglePush(string navigatableId, object args)
		{
		}

		public void PushWithPopIfCurrent(Navigatable navigatable)
		{
		}

		public void PushWithPopIfCurrent(StringConstant id)
		{
		}

		public void PushWithPopIfCurrent(string id)
		{
		}

		public void PushWithPopIfCurrent(string id, object args)
		{
		}

		public void PushBack(Navigatable navigatable)
		{
		}

		public void PushBack(StringConstant id)
		{
		}

		public void PushBack(string id)
		{
		}

		public void PushBack(string id, object args)
		{
		}

		public void Overlay(Navigatable navigatable)
		{
		}

		public void Overlay(StringConstant id)
		{
		}

		public void Overlay(string id)
		{
		}

		public void Overlay(string id, object args)
		{
		}

		public void Pop()
		{
		}

		public void Pop(Navigatable navigatable)
		{
		}

		public void Pop(string id)
		{
		}

		public void PopAll()
		{
		}
	}
}
