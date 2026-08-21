using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ElephantSocial.Model;
using ElephantSocial.Team.CoopEvent.Model.Request;
using ElephantSocial.Team.CoopEvent.Model.Response;
using ElephantSocial.Team.Model;
using ElephantSocial.Team.Model.Request;
using ElephantSocial.Team.Model.Response;
using ElephantSocial.Team.War.Model.Request;
using ElephantSocial.Team.War.Model.Response;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;
using UnityEngine.Networking;

namespace ElephantSocial.Team.Network
{
	public class TeamOps : GenericResponseOps
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CIsServerHealthyAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public TeamOps _003C_003E4__this;

			private UnityWebRequest _003Crequest_003E5__2;

			private UniTask<UnityWebRequest>.Awaiter _003C_003Eu__1;

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
		private struct _003CMakeRequestAsync_003Ed__0<T> : IAsyncStateMachine where T : new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public TeamOps _003C_003E4__this;

			public object data;

			public string url;

			private UniTask<T>.Awaiter _003C_003Eu__1;

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

		[AsyncStateMachine(typeof(_003CMakeRequestAsync_003Ed__0<>))]
		private UniTask<T> MakeRequestAsync<T>(string url, object data) where T : new()
		{
			return default(UniTask<T>);
		}

		public UniTask<Player> GetPlayerAsync()
		{
			return default(UniTask<Player>);
		}

		public UniTask<TeamsListResponse> SuggestTeamsAsync()
		{
			return default(UniTask<TeamsListResponse>);
		}

		public UniTask<TeamsListResponse> SearchTeamsAsync(string searchTerm)
		{
			return default(UniTask<TeamsListResponse>);
		}

		public UniTask<TeamResponse> GetTeamAsync(string teamId)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<TeamResponse> CreateTeamAsync(CreateTeamRequest request)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<TeamResponse> JoinTeamAsync(JoinTeamRequest request)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<TeamResponse> LeaveTeamAsync(LeaveTeamRequest request)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<TeamResponse> UpdateTeamAsync(UpdateTeamRequest request)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<TeamResponse> PromoteMemberAsync(PromoteMemberRequest request)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<TeamResponse> DemoteMemberAsync(DemoteMemberRequest request)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<TeamResponse> KickMemberAsync(KickMemberRequest request)
		{
			return default(UniTask<TeamResponse>);
		}

		public UniTask<JoinRequestsResponse> GetJoinRequestsAsync(JoinRequestsRequest request)
		{
			return default(UniTask<JoinRequestsResponse>);
		}

		public UniTask<PlayerJoinRequestsResponse> GetPlayerJoinRequestsAsync(PlayerJoinRequestsRequest request)
		{
			return default(UniTask<PlayerJoinRequestsResponse>);
		}

		public UniTask AcceptJoinRequestAsync(AcceptJoinRequest request)
		{
			return default(UniTask);
		}

		public UniTask RejectJoinRequestAsync(RejectJoinRequest request)
		{
			return default(UniTask);
		}

		public UniTask IncrementStat(IncrementStatRequest request)
		{
			return default(UniTask);
		}

		public UniTask UpdateTeamStat(UpdateStatRequest request)
		{
			return default(UniTask);
		}

		public UniTask UpdatePlayerStat(UpdateStatRequest request)
		{
			return default(UniTask);
		}

		public UniTask<TeamTopStatResponse> GetTeamTopStatAsync(TopStatRequest request)
		{
			return default(UniTask<TeamTopStatResponse>);
		}

		public UniTask<PlayerTopStatResponse> GetPlayerTopStatAsync(TopStatRequest request)
		{
			return default(UniTask<PlayerTopStatResponse>);
		}

		[AsyncStateMachine(typeof(_003CIsServerHealthyAsync_003Ed__21))]
		public UniTask<bool> IsServerHealthyAsync()
		{
			return default(UniTask<bool>);
		}

		public UniTask<TeamCoopEventResponse> GetTeamCoopEventAsync(TeamCoopEventRequest request)
		{
			return default(UniTask<TeamCoopEventResponse>);
		}

		public UniTask IncrementTeamCoopEventAsync(TeamCoopEventIncrementRequest request)
		{
			return default(UniTask);
		}

		public UniTask SetTeamCoopEventClaimedAsync(TeamCoopEventSetClaimedRequest request)
		{
			return default(UniTask);
		}

		public UniTask<TeamCoopEventResponse> CheckTeamCoopEventRewardsAsync(TeamCoopEventCheckRewardsRequest request)
		{
			return default(UniTask<TeamCoopEventResponse>);
		}

		public UniTask<TeamWarStateResponse> GetWarStateAsync(TeamWarRequest request)
		{
			return default(UniTask<TeamWarStateResponse>);
		}

		public UniTask<TeamWarRankingResponse> GetWarRankingAsync(TeamWarRankingRequest request)
		{
			return default(UniTask<TeamWarRankingResponse>);
		}

		public UniTask<TeamWarRankingResponse> GetWarPhaseRankingAsync(TeamWarPhaseRankingRequest request)
		{
			return default(UniTask<TeamWarRankingResponse>);
		}

		public UniTask AddWarScoreAsync(TeamWarAddScoreRequest request)
		{
			return default(UniTask);
		}
	}
}
