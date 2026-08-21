using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.Levels;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.NewLevelFeatures
{
	public class NewLevelFeatureChecker : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckForNewLevelFeature_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NewLevelFeatureChecker _003C_003E4__this;

			public NewLevelsData newLevelsData;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private NewLevelFeaturesDataService newLevelFeaturesDataService;

		private UniTask newLevelFeaturesDataServiceInitialized;

		public UnityEvent<bool> OnHasNewLevelFeature;

		public UnityEvent<bool> OnHasNotNewLevelFeature;

		public UnityEvent<string> OnHasNewLevelFeatureName;

		public UnityEvent<Sprite> OnHasNewLevelFeatureImage;

		public UnityEvent<string> OnHasNewLevelFeatureGifFileName;

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CCheckForNewLevelFeature_003Ed__8))]
		public void CheckForNewLevelFeature(NewLevelsData newLevelsData)
		{
		}

		public void TestWithLevelNumber(int level)
		{
		}
	}
}
