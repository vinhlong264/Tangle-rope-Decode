using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.SelectableItems;
using Cysharp.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Collection
{
	public class CollectionItem : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetData_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CollectionItem _003C_003E4__this;

			public CollectionItemData collectionItemData;

			public BaseCollectionItemGameData itemGameData;

			public CollectionItemSystem itemSystem;

			public bool isBackground;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		protected SelectableItem selectableItem;

		[SerializeField]
		protected Image iconImage;

		[SerializeField]
		protected FloatVariableInstancer costVariable;

		[SerializeField]
		protected bool didSetData;

		[field: SerializeField]
		public CollectionItemData Data { get; private set; }

		[field: SerializeField]
		public BaseCollectionItemGameData GameData { get; private set; }

		[field: SerializeField]
		public CollectionItemType CollectionItemType { get; private set; }

		[field: SerializeField]
		public CollectionItemSystem ItemSystem { get; private set; }

		public SelectableItem SelectableItem => null;

		private void OnEnable()
		{
		}

		private void SyncBindings()
		{
		}

		public void SetType(CollectionItemType collectionItemType)
		{
		}

		[AsyncStateMachine(typeof(_003CSetData_003Ed__25))]
		public void SetData(CollectionItemData collectionItemData, BaseCollectionItemGameData itemGameData, CollectionItemSystem itemSystem, bool isBackground = false)
		{
		}

		public void SetLock(bool isLocked)
		{
		}

		protected virtual UniTask SetDataInternal()
		{
			return default(UniTask);
		}

		protected virtual void SyncBindingsInternal()
		{
		}
	}
}
