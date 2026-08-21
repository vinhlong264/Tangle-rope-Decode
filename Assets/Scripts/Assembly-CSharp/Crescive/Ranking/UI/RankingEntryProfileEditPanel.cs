using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DanielLochner.Assets.SimpleScrollSnap;
using PersistentSO;
using TMPro;
using UnityEngine;

namespace Crescive.Ranking.UI
{
	[DefaultExecutionOrder(1)]
	public class RankingEntryProfileEditPanel : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFixScroll_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RankingEntryProfileEditPanel _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetCurrentValuesAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RankingEntryProfileEditPanel _003C_003E4__this;

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
		[Header("Initialize References")]
		private CanvasGroup panelCanvasGroup;

		[SerializeField]
		private GameObject panelPivot;

		[Space]
		[SerializeField]
		private RankingEntryProfileOptionsData profileOptionsData;

		[SerializeField]
		private PersistentStringVariable persistentPlayerName;

		[SerializeField]
		private PersistentRankingEntryProfile persistentPlayerProfile;

		[SerializeField]
		[Space]
		private TMP_InputField nameInputField;

		[SerializeField]
		private SimpleScrollSnap iconsScrollSnap;

		[SerializeField]
		private SimpleScrollSnap iconColorsScrollSnap;

		[Space]
		[SerializeField]
		private RankingEntryProfileIcon iconPrefab;

		[SerializeField]
		private RankingEntryProfileIconColor iconColorPrefab;

		[SerializeField]
		private bool didSetup;

		[SerializeField]
		private bool didFixScrollOnce;

		[SerializeField]
		private string fieldPlayerName;

		[SerializeField]
		private int fieldIconId;

		[SerializeField]
		private int fieldIconColorId;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupIfRequiredAsync()
		{
		}

		private void Setup()
		{
		}

		[AsyncStateMachine(typeof(_003CSetCurrentValuesAsync_003Ed__19))]
		private void SetCurrentValuesAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CFixScroll_003Ed__20))]
		private UniTask FixScroll()
		{
			return default(UniTask);
		}

		private void OnNameChangedCallback(string value)
		{
		}

		private void OnIconIdChangedCallback(int value)
		{
		}

		private void OnIconColorIdChangedCallback(int value)
		{
		}

		private void SetName(string playerName)
		{
		}

		private void SetIconId(int id)
		{
		}

		private void SetIconColorId(int id)
		{
		}

		public void SetupIfRequired()
		{
		}

		public void SaveValues()
		{
		}

		public void SetCurrentValues()
		{
		}
	}
}
