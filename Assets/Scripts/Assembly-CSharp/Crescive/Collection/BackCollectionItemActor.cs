using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.Collection
{
	public class BackCollectionItemActor : CollectionItemActor<BackCollectionItemGameData>
	{
		[SerializeField]
		private MeshRenderer backMeshRenderer;

		[SerializeField]
		private PinSlotsChannel pinSlotsChannel;

		[SerializeField]
		private PinSlotsColorSetter pinSlotsColorSetter;

		private BackCollectionItemGameData currentItemGameData;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private PinSlotColorsData GetColorsData()
		{
			return null;
		}

		protected override void OnItemSelectedInternal(BackCollectionItemGameData itemGameData)
		{
		}

		private void OnPinSlotAdded(PinSlotEntity pinSlotEntity)
		{
		}

		public void SetCurrentDataValues()
		{
		}
	}
}
