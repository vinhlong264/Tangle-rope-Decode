using System.Collections.Generic;
using CresciveCore;
using UnityEngine;

namespace SegmentedOffers
{
	[DefaultExecutionOrder(int.MinValue)]
	public class UserSegmentManager : MonoBehaviour
	{
		public static UserSegmentManager Instance;

		public LevelSystem levelSystem;

		private UserSegmentRemote userSegmentRemote;

		private UserSegment[] userSegments;

		private ProductDetailRemote productDetailRemote;

		private AllIapSegmentData allIapSegmentData;

		private List<IAPSegmentData> iAPSegmentDatas;

		public UserSegmentRemote UserSegmentRemote => null;

		public UserSegment[] UserSegments => null;

		public ProductDetailRemote ProductDetailRemote => null;

		public AllIapSegmentData AllIapSegmentData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<IAPSegmentData> IAPSegmentDatas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserSegment GetUserSegment()
		{
			return null;
		}

		internal void ResetUserSegment()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void IAPSuccessfull(SegmentedOfferEvents.IAPSuccessfull p)
		{
		}

		private void IAPSuccessfullDirectStore(SegmentedOfferEvents.IAPSuccessfullDirectStore p)
		{
		}

		private void Update()
		{
		}
	}
}
