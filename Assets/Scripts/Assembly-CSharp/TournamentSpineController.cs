using Spine.Unity;
using UnityEngine;

public class TournamentSpineController : MonoBehaviour
{
	[Header("Spine")]
	[SerializeField]
	private SkeletonGraphic spine;

	[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
	public string idleAnimation;

	[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
	public string actionAnimation;

	public static TournamentSpineController Instance;

	private void Awake()
	{
	}

	public void ReloadSpine()
	{
	}

	public void PlayActionThenIdle()
	{
	}
}
