using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.IAP;
using ElephantSDK;
using UnityEngine;

public class DirectStoreManager : MonoBehaviour
{
	public enum DirectStoreStatusEnum
	{
		Disabled = 0,
		NotInitialized = 1,
		Pending = 2,
		Initialized = 3
	}

	[CompilerGenerated]
	private sealed class _003CDelayedDSPurchase_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string productID;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayedDSPurchase_003Ed__47(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static string DirectStoreProductPreKey;

	public static string DirectStoreBattlePassProductID;

	public static string DefaultBattlePassProductID;

	private const string DirectStoreFlowPrefKey = "DirectStoreFlowPrefKey";

	private const string LastSessionRemoteConfigDSDefaultStatusPlayerPrefKey = "last_session_ds_default_status";

	public Action<ElephantPayment, IIAPPurchaser> onPurchaseSuccess;

	public Action<ElephantPaymentsError, IIAPPurchaser> onPurchaseFailed;

	public Action onPaymentDialogueClosed;

	private bool _isInitialized;

	private bool _isInitializeStarted;

	private static IIAPPurchaser _lastPurchaser;

	private static List<ElephantProduct> _products;

	private static DirectStoreManager instance { get; set; }

	public bool DirectStoreRemoteConfigStatus => false;

	public int DirectStoreIncreaseValue => 0;

	public bool UseDirectStoreFlow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool _useDirectStoreFlow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static DirectStoreStatusEnum DirectStoreStatus => default(DirectStoreStatusEnum);

	public static event Action<bool> UseDirectStoreFlowChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private bool IsRemoteConfigActive()
	{
		return false;
	}

	private bool DirectStoreDefaultStatus()
	{
		return false;
	}

	private int GetDirectStoreIncreaseValue()
	{
		return 0;
	}

	private void CheckHasRemoteConfigUpdated()
	{
	}

	public static DirectStoreManager GetInstance()
	{
		return null;
	}

	public static string UnityToDirectStoreProductId(string productId)
	{
		return null;
	}

	public static string DirectStoreProductKeyToUnityProductId(string productId)
	{
		return null;
	}

	public void Init()
	{
	}

	private void OnProductsFetched(List<ElephantProduct> products)
	{
	}

	private void OnPaymentPending(ElephantPayment payment)
	{
	}

	private void OnPaymentsError(ElephantPaymentsError error)
	{
	}

	private DirectStoreStatusEnum GetDirectStoreStatus()
	{
		return default(DirectStoreStatusEnum);
	}

	public List<ElephantProduct> GetProductList()
	{
		return null;
	}

	public static bool HasProduct(string productID)
	{
		return false;
	}

	public static bool HasProduct(string productID, out ElephantProduct product)
	{
		product = null;
		return false;
	}

	[IteratorStateMachine(typeof(_003CDelayedDSPurchase_003Ed__47))]
	private static IEnumerator DelayedDSPurchase(string productID)
	{
		return null;
	}

	public static void Purchase(string productID, IIAPPurchaser purchaser)
	{
	}

	private static void OnPaymentDialogueClosed()
	{
	}

	public ElephantProduct GetProductInfo(string productID)
	{
		return null;
	}
}
