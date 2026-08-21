using Crescive.LadderOffer;
using UnityEngine;

public class DirectStoreLadderOfferItemHelper : MonoBehaviour
{
	[SerializeField]
	private LadderOfferItemView ladderOfferItemView;

	[SerializeField]
	private DirectStoreModifyTarget[] modifyTargets;

	[SerializeField]
	private DirectStoreModifyTargetWithData<LadderOfferItemData>[] modifyTargetsWithIAPData;

	[SerializeField]
	private Transform modifyTargetsMainParent;

	public DirectStoreSelectionPanelController _directStoreSelectionPanelController;

	private bool _initialized;

	public void CheckStatus()
	{
	}

	private bool IsDirectStoreSelectionPanelControllerActiveInThisPopUp()
	{
		return false;
	}

	private void UpdateText(bool obj)
	{
	}

	private void OnDestroy()
	{
	}
}
